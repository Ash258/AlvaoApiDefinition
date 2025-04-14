using System.Text;
using HtmlAgilityPack;
using Microsoft.Extensions.Logging;

namespace AlvaoScrapper;

public class AlvaoClass2
{
    public ILogger Logger;

    public AlvaoNamespace2 Namespace { get; set; }
    public string NamespaceName { get; set; }
    public string Name { get; set; }
    public string Summary { get; set; }
    public string Type { get; set; }
    public string? FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FinalCsFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public string Definition { get; set; } = "";
    public List<string> Usings { get; set; }

    public List<string> Enums { get; set; }
    public List<DotnetProperty> Properties { get; set; }
    public List<string> Fields { get; set; }
    public List<string> Events { get; set; }
    public List<string> Constructors { get; set; }
    public List<string> Methods { get; set; }

    public AlvaoClass2(string name, string href, string memberType, AlvaoNamespace2 ns)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter("AlvaoScrapper", (LogLevel)int.Parse(Environment.GetEnvironmentVariable("Logging__LogLevel__AlvaoScrappeasdfr") ?? "2"));
            builder.AddSimpleConsole(options =>
            {
                options.IncludeScopes = true;
                options.SingleLine = true;
            });
        });
        Logger = loggerFactory.CreateLogger<AlvaoClass2>();

        Name = name;
        Type = memberType;
        FullUrl = $"{Helpers.BASE_HTML_URL}/{href.Split("/").Last()}";
        Namespace = ns;
        NamespaceName = ns.Name;
        LocalHtmlFile = $"{Helpers.LOCAL_HTML_FOLDER}/{FullUrl.Split("/").Last()}";
        HtmlDocument = Helpers.LoadDocument(FullUrl, LocalHtmlFile);
        FinalCsFile = $"{NamespaceName.Replace(".", "/")}/{Name}.cs";

        Summary = Helpers2.GetSummary(HtmlDocument);
        Usings = [];
        Fields = [];
        Properties = [];
        Enums = [];
        Methods = [];
        Events = [];
        Constructors = [];
    }

    internal void Process()
    {
        Logger.LogInformation("Processing {} class {{{}}}", Name, NamespaceName);
        AssertDocumentIsClass();

        ProcessDefinition();
        ProcessProperties();

        ProduceFinalCsFile();
    }

    private void AssertDocumentIsClass()
    {
        Logger.LogDebug("Verifying HTML document is class");
        var h1 = HtmlDocument.DocumentNode.SelectSingleNode("//article/h1");
        if (h1 == null)
        {
            Logger.LogError("");
            throw new Exception("Page does not have h1");
        }

        var fqdnId = NamespaceName.Replace(".", "_");
        fqdnId = fqdnId + "_" + Name.Replace(".", "_");
        var actual = h1.InnerText.Trim();
        var expected = $"{Type} {Name}";
        if (!h1.GetAttributeValue("id", "none").Equals(fqdnId) || !actual.Equals(expected))
        {
            Logger.LogError("Page contains different class: Expected {}, Actual: {}", expected, actual);
            throw new Exception($"Page contains different class: Expected {expected}, Actual: {actual}");
        }
    }

    private void ProcessDefinition()
    {
        Logger.LogInformation("Processing definitition of class {name} {{{ns}}}", Name, NamespaceName);
        var _def = Helpers2.ExtractObjectDefinition(HtmlDocument);
        if (_def == null) return;

        Definition = _def;
    }

    public void ProcessProperties()
    {
        Logger.LogInformation("Processing properties of class {name} {{{ns}}}", Name, NamespaceName);
        var properties = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='properties' and @class='section']/following-sibling::*");
        if (properties == null) return;

        var breakLoop = false;
        var property = new DotnetProperty
        {
            Name = string.Empty,
        };

        // ? TODO: Try to filter only h3, divs between two h2
        foreach (var element in properties)
        {
            switch (element.Name)
            {
                // ! TODO: Handle summary
                case "h3":
                    // Actual property name
                    Logger.LogInformation("Changing current property from '{}' to '{}' {{{}}}", property.Name, element.InnerText.Trim(), NamespaceName);

                    property.Reset();
                    property.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual code definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        try
                        {
                            property.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;

                    property.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (property.Name.IsNullOrEmpty()) break;

                    Logger.LogInformation("saving {}: {}", property.Name, property.Definition);
                    // ??? TODO: Why Properties.Add(property) does not work?
                    Properties.Add(new DotnetProperty()
                    {
                        Name = property.Name,
                        Summary = property.Summary,
                        Definition = Helpers2.SanitizeXmlToString(property.Definition),
                    });
                    property.Reset();
                    break;
                case "h2":
                    // This means there is change in the member type (properties, fields)
                    breakLoop = true;
                    break;
                case "a":
                    // In some cases there is link element. Skip it
                    break;
            }
            if (breakLoop) break;
        }
    }

    public void ProduceFinalCsFile()
    {
        var sb = new StringBuilder();

        // First process usings
        if (Usings.Count != 0)
        {
            Usings.Distinct().Order().ToList().ForEach(el => sb.AppendLine($"using {el};"));
            sb.AppendLine("");
        }

        // Set namespace
        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");

        // Set class specific docs
        if (!Summary.Equals("")) sb.AppendLine($"/// <summary>{Summary}</summary>");
        if (!FullUrl.IsNullOrEmpty()) sb.AppendLine($"/// <see href=\"{FullUrl}\"/>");
        sb.AppendLine(Definition);
        sb.AppendLine("{");
        {
            Properties.ForEach(el => sb.AppendLine(el.Produce()));
            // Fields.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));
        }

        //     Fields.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));
        //     Events.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));

        //     if ((Enums.Count > 0 || Properties.Count > 0 || Fields.Count > 0 || Events.Count > 0) && Constructors.Count > 0) sb.AppendLine("");
        //     Constructors.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)} {{}}"));

        //     Methods.ForEach((el) =>
        //     {
        //         sb.AppendLine("");
        //         sb.AppendLine(Helpers.PrefixEachLineSpaces(el));
        //     });
        sb.AppendLine("}"); // End class

        File.WriteAllText(FinalCsFile, sb.ToString());
    }

    // public AlvaoClass(bool manual, string namespaceName, string name, string summary)
    // {
    //     using var loggerFactory = LoggerFactory.Create(builder =>
    //     {
    //         builder.AddFilter("AlvaoScrapper", LogLevel.Debug);
    //         builder.AddConsole();
    //     });
    //     Logger = loggerFactory.CreateLogger<AlvaoClass>();

    //     Name = name.Replace(" Class", "").Replace(" Interface", "").Trim();
    //     Type = name.EndsWith("Interface") ? ClassType.INTERFACE : ClassType.CLASS;
    //     NamespaceName = namespaceName;
    //     FinalCsFile = $"{namespaceName.Replace(".", "/")}/{Name}.cs";

    //     Summary = summary;
    //     Version = "";
    //     Usings = [];
    //     Fields = [];
    //     Properties = [];
    //     Enums = [];
    //     Methods = [];
    //     Events = [];

    //     Constructors = [];
    //     LocalHtmlFile = "";
    //     HtmlDocument = null;
    // }

    // internal static void ProcessClass(HtmlNode cl, AlvaoNamespace an)
    // {
    //     var aNode = cl.SelectNodes(".//a").Last();
    //     var className = aNode.GetAttributeValue("title", "");
    //     if (!className.EndsWith(" Class") && !className.EndsWith(" Interface")) return;

    //     var clazz = new AlvaoClass(aNode.GetAttributeValue("href", ""), an.Name, className);
    //     clazz.Process();
    // }

    // public void Process()
    // {
    //     Logger.LogInformation("Processing member '{}' ({}) [{}]", Name, Type, NamespaceName);

    //     // TODO: Drop
    //     // ! TODO: Check if needed
    //     if (MonkeyPatch.IsInvalidClass(NamespaceName, Name)) return;

    //     Logger.LogInformation("Processing definitition of class {name} [{ns}]", Name, NamespaceName);
    //     var _def = Helpers.ExtractObjectDefinition(HtmlDocument);
    //     if (_def == null) return;

    //     Definition = _def;
    //     ProcessProperties();
    //     // ProcessFields();
    //     // ProcessEvents();
    //     ProcessConstructors();
    //     // ProcessMethods();

    //     // TODO: Drop
    //     // MonkeyPatch.Using(this);

    //     State.Classes.Add($"{NamespaceName}.{Name}", this);
    //     ProduceFinalCsFile();
    // }

    // private static StringBuilder ProcessDocumentationComments(string link, HtmlDocument document, out bool skip)
    // {
    //     skip = false;
    //     var _summary = Helpers.GetSummary(document);
    //     if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) skip = true;
    //     var _sb = new StringBuilder();
    //     if (!_summary.Equals("")) _sb.AppendLine(_summary);
    //     _sb.AppendLine(Helpers.GenerateSeeDoc(link));

    //     return _sb;
    // }

    // public void ProcessProperties()
    // {
    //     var properties = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='properties' and @class='section']/following-sibling::*");
    //     if (properties == null) return;

    //     var currentProperty = string.Empty;
    //     foreach (var element in properties)
    //     {
    //         switch (element.Name)
    //         {
    //             case "h2":
    //                 break;
    //             case "a":
    //                 break;
    //             case "div":
    //                 var divClass = element.GetAttributeValue("class", "none");
    //                 if (divClass.Equals("codewrapper"))
    //                 {
    //                     Properties.Add(element.SelectSingleNode(".//pre/code").InnerText.Trim());
    //                 }
    //                 break;
    //             case "h3":
    //                 if (!currentProperty.Equals(element.InnerText.Trim()))
    //                 {
    //                     Logger.LogInformation("Changing current property to '{}'", element.InnerText.Trim());
    //                     currentProperty = element.InnerText.Trim();
    //                 }
    //                 break;
    //         }
    //     }
    //     // ! TODO: Drop 11 version
    //     return;
    //     // var currentProperty = properties

    //     foreach (var p in properties)
    //     {
    //         Console.WriteLine(properties);
    //         continue;
    //         var propName = Helpers.ExtractObjectName(p);
    //         Console.WriteLine($"    Processing {propName} Property");

    //         // TODO: Drop
    //         if (MonkeyPatch.IsInvalidProperty(NamespaceName, Name, propName)) return;

    //         var propHtmlBaseFileName = p.GetAttributeValue("href", "").Split("/").Last();
    //         var propLink = $"{Helpers.BASE_HTML_URL}/{propHtmlBaseFileName}";
    //         var propLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{propHtmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(propLink)) continue;

    //         var propDocument = Helpers.LoadDocument(propLink, propLocalHtml);
    //         var _sb = ProcessDocumentationComments(propLink, propDocument, out bool obsolete);
    //         if (obsolete) continue;

    //         var propDef = Helpers.ExtractObjectDefinition(propDocument);
    //         if (propDef == null) continue;

    //         // TODO: Drop
    //         if (Helpers.IsClass(this, "Alvao.API.Common.Model", "ColumnValue") && propName.Equals("DataType"))
    //             propDef = propDef.Replace(" Database.ValueDataType ", " Alvao.API.Common.Database.ValueDataType ");

    //         propDef = Helpers.SanitizeXmlToString(propDef);

    //         // TODO: Drop
    //         MonkeyPatch.UsingProperties(this, propDef);

    //         _sb.AppendLine(propDef);
    //         Properties.Add(_sb.ToString());
    //     }
    // }

    // public void ProcessFields()
    // {
    //     return;
    //     var fields = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"FieldList\"]/tr/td[2]/a");
    //     if (fields == null) return;

    //     foreach (var f in fields)
    //     {
    //         var fieldName = Helpers.ExtractObjectName(f);
    //         Console.WriteLine($"    Processing {fieldName} Field");

    //         var fieldHtmlBaseFileName = f.GetAttributeValue("href", "").Split("/").Last();
    //         var fieldLink = $"{Helpers.BASE_HTML_URL}/{fieldHtmlBaseFileName}";
    //         var fieldLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{fieldHtmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(fieldLink)) continue;

    //         var fieldDocument = Helpers.LoadDocument(fieldLink, fieldLocalHtml);
    //         var _sb = ProcessDocumentationComments(fieldLink, fieldDocument, out bool obsolete);
    //         if (obsolete) continue;

    //         var fieldDef = Helpers.ExtractObjectDefinition(fieldDocument);
    //         if (fieldDef == null) continue;
    //         fieldDef = Helpers.SanitizeXmlToString(fieldDef);

    //         // TODO: Drop
    //         if (fieldName.Equals("EmailFormat")) fieldDef = fieldDef.Replace("\"]", "\"\"]");
    //         if (new[] { "EmailFormat", "EmailPattern" }.Contains(fieldName)) fieldDef = fieldDef.Replace("= \"", "= @\"");

    //         _sb.AppendLine(fieldDef);
    //         Fields.Add(_sb.ToString());
    //     }
    // }

    // private void ProcessEvents()
    // {
    //     var elements = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"EventList\"]/tr/td[2]/a");
    //     if (elements == null) return;

    //     foreach (var e in elements)
    //     {
    //         var _name = Helpers.ExtractObjectName(e);
    //         Console.WriteLine($"    Processing {_name} Method");

    //         var _htmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
    //         var _link = $"{Helpers.BASE_HTML_URL}/{_htmlBaseFileName}";
    //         var _localHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{_htmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(_link)) continue;

    //         var _document = Helpers.LoadDocument(_link, _localHtml);
    //         var _sb = ProcessDocumentationComments(_link, _document, out bool obsolete);
    //         if (obsolete) continue;

    //         var _definition = Helpers.ExtractObjectDefinition(_document);
    //         if (_definition == null) continue;

    //         _sb.AppendLine(Helpers.SanitizeXmlToString(_definition));
    //         Events.Add(_sb.ToString());
    //     }
    // }

    // private void ProcessConstructors()
    // {
    //     var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='constructors' and @class='section']/following-sibling::*");
    //     if (elements == null) return;

    //     var currentConstructorName = string.Empty;
    //     foreach (var el in elements)
    //     {
    //         switch (el.Name)
    //         {
    //             case "h2":
    //                 // Skip other group of members
    //                 break;
    //             case "a":
    //                 break;
    //             case "h3":
    //                 break;
    //             default:
    //                 Console.WriteLine(el.Name);
    //                 break;
    //         }
    //     }

    //     return;


    //     // foreach (var c in constructors)
    //     // {
    //     //     var constrName = Helpers.ExtractObjectName(c);
    //     //     Console.WriteLine($"    Processing {constrName} Constructor");

    //     //     var constrHtmlBaseFileName = c.GetAttributeValue("href", "").Split("/").Last();
    //     //     var constrLink = $"{Helpers.BASE_HTML_URL}/{constrHtmlBaseFileName}";
    //     //     var constrLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{constrHtmlBaseFileName}";
    //     //     if (Helpers.IsInvalidAlvaoUrl(constrLink)) continue;

    //     //     var constrDocument = Helpers.LoadDocument(constrLink, constrLocalHtml);
    //     //     var _sb = ProcessDocumentationComments(constrLink, constrDocument, out bool obsolete);
    //     //     if (obsolete) continue;

    //     //     var constrDef = Helpers.ExtractObjectDefinition(constrDocument);
    //     //     if (constrDef == null) continue;

    //     //     constrDef = Helpers.SanitizeXmlToString(constrDef);

    //     //     // TODO: Drop
    //     //     if (constrDef.Contains(" StreamingContext ")) Usings.Add("System.Runtime.Serialization");
    //     //     if (constrDef.Contains(" SerializationInfo ")) Usings.Add("System.Runtime.Serialization");

    //     //     _sb.AppendLine(constrDef);

    //     //     Constructors.Add(_sb.ToString());
    //     // }
    // }

    // private void ProcessMethods()
    // {
    //     var elements = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"MethodList\"]/tr/td[2]/a");
    //     if (elements == null) return;

    //     bool emailQueueProcessed = false;

    //     foreach (var e in elements)
    //     {
    //         var _name = Helpers.ExtractObjectName(e);

    //         // TODO: Drop
    //         if (emailQueueProcessed) continue;
    //         if (Helpers.IsClass(this, "Alvao.API.Common", "Email") && _name.Contains("Queue")) emailQueueProcessed = true;
    //         if (MonkeyPatch.IsInvalidMethod(NamespaceName, Name, _name)) continue;

    //         Console.WriteLine($"    Processing {_name} Method");

    //         var _htmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
    //         var _link = $"{Helpers.BASE_HTML_URL}/{_htmlBaseFileName}";
    //         var _localHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{_htmlBaseFileName}";
    //         if (Helpers.IsInvalidAlvaoUrl(_link)) continue;

    //         var _document = Helpers.LoadDocument(_link, _localHtml);
    //         var _sb = ProcessDocumentationComments(_link, _document, out bool obsolete);
    //         if (obsolete) continue;

    //         var _definition = Helpers.ExtractObjectDefinition(_document);
    //         if (_definition == null) continue;
    //         if (_definition.Contains("ObsoleteAttribute")) continue;

    //         var _params = _document.DocumentNode.SelectSingleNode("//*[@id=\"IDBSection\"]/dl");
    //         if (_params != null)
    //         {
    //             _sb.AppendLine($"///");
    //             var _dts = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dt");
    //             var _dds = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dd");

    //             for (int i = 0; i < _dts.Count; i++)
    //             {
    //                 var _var = _dts[i].SelectSingleNode(".//span")?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " ");
    //                 var _description = _dds[i]?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " ");
    //                 if (_description == null) continue;

    //                 _description = Helpers.ReplaceEndLinesWithSpace(_description);
    //                 _sb.AppendLine($"/// <param name=\"{_var}\">{_description}</param>");
    //             }
    //         }

    //         _definition = Helpers.SanitizeXmlToString(_definition);

    //         // TODO: Drop
    //         _definition = MonkeyPatch.Methods(this, _name, _definition);

    //         _sb.AppendLine($"{_definition}{Helpers.GenerateMethodBody(Type)}");
    //         Methods.Add(_sb.ToString());
    //     }
    // }
}
