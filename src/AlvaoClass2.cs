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
    public List<DotnetField> Fields { get; set; }
    public List<string> Events { get; set; }
    public List<DotnetConstructor> Constructors { get; set; }
    public List<DotnetMethod> Methods { get; set; }

    public AlvaoClass2(string name, string href, string memberType, AlvaoNamespace2 ns)
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter("AlvaoScrapper", (LogLevel)int.Parse(Environment.GetEnvironmentVariable("Logging__LogLevel__AlvaoScrapper") ?? "2"));
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

    internal void RestructuralizeClassDocument()
    {
        Logger.LogInformation("Processing the class document {} {{{}}}", Name, NamespaceName);
        // Get all elements in main container
        var elements = HtmlDocument.DocumentNode.SelectNodes("//article/*");

        // First element should be h1
        var h1Index = elements.FindIndex(e => e.Name.Equals("h1"));
        if (h1Index == -1)
        {
            Logger.LogError("Page does not specify h1 element {} {{{}}}", Name, NamespaceName);
            throw new Exception($"Page does not specify h1 element {Name} {NamespaceName}");
        }

        var _Name = elements[h1Index].InnerText.Trim()
            .Replace("Class ", "")
            .Replace("Interface ", "")
            .Replace("Enum ", "")
            .Trim();

        if (!_Name.Equals(Name))
        {
            Logger.LogError("Page specify different class: {} {} {{{}}}", _Name, Name, NamespaceName);
            throw new Exception($"Page specify different class: {_Name} {Name} {NamespaceName}");
        }

        // Constructors, Properties, Fields, Events, Methods
        Logger.LogInformation("Finding class member groups {} {{{}}}", Name, NamespaceName);
        var h2Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h2")
                .Select(x => x.i).ToList();

        if (h2Indexes.Count == 0)
        {
            Logger.LogError("Class does not expose any members {} {{{}}}", Name, NamespaceName);
            throw new Exception($"Class does not expose any members {Name} {NamespaceName}");
        }

        // First pass is h1 (class specific items), until first h2
        var groupName = "Class";
        int startIndex = h1Index;
        List<HtmlNode> classRelatedElements = [];
        Dictionary<string, List<HtmlNode>> groups = [];

        Logger.LogDebug("There are {} h2 elements {} {{{}}}", h2Indexes.Count, Name, NamespaceName);

        // Workaround to force processing of last member
        h2Indexes.Add(elements.Count);
        foreach (var groupIndex in h2Indexes)
        {
            Logger.LogDebug("Group '{}' '{}' => '{}' ({})", groupName, startIndex, groupIndex, elements.Count);
            if (groupName.Equals("Class"))
            {
                classRelatedElements = [.. elements.Skip(startIndex).Take(groupIndex - startIndex)];
                // If there is only 1 group, the class and group needs to be process in 1 take
                // That means that grou span from h2index to all other elements
                if (h2Indexes.Count == 1)
                {
                    groupName = elements[groupIndex].InnerText.Trim();
                    Logger.LogDebug("Class has only one group {} {} {{{}}}", groupName, Name, NamespaceName);
                    groups.Add(groupName, [.. elements.Skip(groupIndex).Take(elements.Count - groupIndex)]);
                }
            }
            else
            {
                groups.Add(groupName, [.. elements.Skip(startIndex).Take(groupIndex - startIndex)]);
            }
            if (elements.Count == groupIndex)
            {
                break;
            }
            groupName = elements[groupIndex].InnerText.Trim();
            startIndex = groupIndex;
        }

        Logger.LogInformation("Found {} class members {} {{{}}}", groups.Count, Name, NamespaceName);

        List<DotnetProperty> properties = [];
        List<DotnetField> fields = [];
        List<DotnetConstructor> constructors = [];
        List<DotnetMethod> methods = [];

        foreach (var gr in groups)
        {
            Logger.LogInformation("Processing class member: {} {{{}}}", gr.Key, NamespaceName);
            switch (gr.Key)
            {
                case "Properties":
                    properties = _ProcessProperties(gr.Value);
                    break;
                case "Fields":
                    fields = _ProcessFields(gr.Value);
                    break;
                case "Constructors":
                    constructors = _ProcessConstructors(gr.Value);
                    break;
                case "Methods":
                    methods = _ProcessMethods(gr.Value);
                    break;
                default:
                    Logger.LogWarning("Skipping {}", gr.Key);
                    break;
            }
        }
        foreach (var el in properties)
        {
            Console.WriteLine(el);
        }
        foreach (var el in constructors)
        {
            Console.WriteLine(el);
        }
        foreach (var el in fields)
        {
            Console.WriteLine(el);
        }
        foreach (var el in methods)
        {
            Console.WriteLine(el);
        }

        // ! TODO: Do not rely on hardcoded indexes
        Summary = classRelatedElements[2].InnerText.Trim();
        Definition = classRelatedElements[4].InnerText.Trim();

        Properties = properties;
        Fields = fields;
        Constructors = constructors;
        Methods = methods;

        ProduceFinalCsFile();

        return;




        // // var memberGroupIndex = elements.FindIndex(e => e.Name.Equals("h2"));
        // if (memberGroupIndex == -1)
        // {
        //     Logger.LogWarning("Class {} does not have any members {{{}}}", Name, NamespaceName);
        //     return;
        // }

        // var classRelatedElements = elements.Take(memberGroupIndex);
        // var previousGroupEndIndex = memberGroupIndex;
        // var groups = new Dictionary<string, List<HtmlNode>>();
        // var groupName = elements[memberGroupIndex].InnerText.Trim();
        // var groupElements = elements.Skip(classRelatedElements.Count()).ToList();
        // groups.Add(groupName, groupElements);
        // // Logger.LogWarning("{}", groupName);
        // // foreach (var e in groupElements)
        // // {
        // // }
        // // Break rest of the elements into groups by h2 elements (Constructors, Properties, Fields, Events, Methods)
        // while (memberGroupIndex != -1)
        // {
        //     // First is always the group itself
        //     previousGroupEndIndex = memberGroupIndex;
        //     memberGroupIndex = elements.Skip(1).ToList().FindIndex(e => e.Name.Equals("h2"));
        //     Console.WriteLine(memberGroupIndex);
        //     continue;
        //     if (memberGroupIndex == -1)
        //     {
        //         // There are no other groups
        //         Logger.LogError("No other groups. -1 index");
        //     }

        //     groups.Add(elements[memberGroupIndex].InnerText.Trim(), elements.Skip(previousGroupEndIndex).Take(memberGroupIndex).ToList());
        // }
        // // Logger.LogError("{} [{}] {{{}}}", memberGroupIndex.ToString(), Name, NamespaceName);
        // // Logger.LogError("{} {}", h1Index, memberGroupIndex);
        // // Environment.Exit(20);

        // foreach (var gr in groups.Keys)
        // {
        //     Console.WriteLine(gr);
        //     foreach (var el in groups.GetValueOrDefault(gr, []))
        //     {
        //         Console.WriteLine("    " + el.Name);
        //     }
        // }

        // foreach (var el in classRelatedElements)
        // {
        //     Console.WriteLine(el.Name);
        // }
    }

    // TODO: merge propeties and fields
    // ! TODO: Void
    private List<DotnetProperty> _ProcessProperties(List<HtmlNode> elements)
    {
        List<DotnetProperty> properties = [];
        Logger.LogDebug("Processing class properties {} {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count - 1;

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                var _name = currentElements[0].InnerText.Trim();
                var sum = string.Empty;
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Property {} does not specify summary {} {{{}}}", _name, Name, NamespaceName);
                }
                properties.Add(
                    new DotnetProperty()
                    {
                        Name = _name,
                        Summary = sum,
                        Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    }
                );
            }
            else
            {
                Logger.LogError("Property does not have all divs");
            }
        }

        return properties;
    }

    // ! TODO: Void
    private List<DotnetField> _ProcessFields(List<HtmlNode> elements)
    {
        List<DotnetField> fields = [];
        Logger.LogDebug("Processing class fields {} {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count - 1;

        Logger.LogDebug("Found {} Fields {} {{{}}}", h3Indexes.Count, Name, NamespaceName);

        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                var _name = currentElements[0].InnerText.Trim();
                var sum = string.Empty;
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Field {} does not specify summary {} {{{}}}", _name, Name, NamespaceName);
                }
                fields.Add(
                    new DotnetField()
                    {
                        Name = _name,
                        Summary = sum,
                        Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    }
                );
            }
            else
            {
                Logger.LogError("Property does not have all divs");
            }
        }

        return fields;
    }

    // ! TODO: Void
    private List<DotnetConstructor> _ProcessConstructors(List<HtmlNode> elements)
    {
        List<DotnetConstructor> constructors = [];

        Logger.LogDebug("Processing class constructors {} {{{}}}", Name, NamespaceName);
        var h3Indexes = elements
                .Select((f, i) => new { f, i })
                .Where(x => x.f.Name == "h3")
                .Select(x => x.i).ToList();
        var lastIndex = elements.Count;
        // var lastIndex = elements.Count - 1;

        Logger.LogDebug("Found {} constructors {} {{{}}}", h3Indexes.Count, Name, NamespaceName);

        var _name = string.Empty;
        var sum = string.Empty;
        for (var i = 0; i < h3Indexes.Count; ++i)
        {
            var end = i == h3Indexes.Count - 1
                ? lastIndex
                : h3Indexes[i + 1];
            var currentElements = elements[h3Indexes[i]..end];
            var divs = currentElements.Where(x => x.Name.Equals("div")).ToList();
            if (divs.Count == 3)
            {
                _name = currentElements[0].InnerText.Trim();
                try
                {
                    sum = divs[0].SelectSingleNode(".//p").InnerText.Trim();
                }
                catch
                {
                    Logger.LogDebug("Constructor {} does not specify summary {} {{{}}}", _name, Name, NamespaceName);
                }
            }
            else
            {
                Logger.LogError("Property does not have all divs");
            }

            var h4Indexes = elements
                    .Select((f, i) => new { f, i })
                    .Where(x => x.f.Name == "h4")
                    .Select(x => x.i).ToList();

            Logger.LogDebug("Found {} constructor nested properties {} {{{}}}", h4Indexes.Count, Name, NamespaceName);

            List<string> examples = [];
            List<(string, string)> parameters = [];
            for (var j = 0; j < h4Indexes.Count; ++j)
            {
                var h4end = j == h4Indexes.Count - 1
                    ? lastIndex
                    // ? lastIndex + 1
                    : h4Indexes[j + 1];
                var h4CurrentElements = elements[h4Indexes[j]..h4end];

                Logger.LogDebug("h4 elements count {} {} {{{}}}", h4CurrentElements.Count, Name, NamespaceName);

                switch (h4CurrentElements[0].InnerText.Trim())
                {
                    case "Parameters":
                        Logger.LogDebug("Processing constructor parameters {} {{{}}}", Name, NamespaceName);
                        // THis has to be dl
                        var constrParams = h4CurrentElements[1].SelectNodes(".//dt/code").Select(x => x.InnerText).ToList();
                        var constrParamsDesc = h4CurrentElements[1].SelectNodes(".//dd/p").Select(x => x.InnerText).ToList();
                        if (constrParams.Count != constrParamsDesc.Count)
                        {
                            Logger.LogError("Mismatch between constructor paramter names and description {} {{{}}}", Name, NamespaceName);
                            break;
                        }
                        for (var _ci = 0; _ci < constrParams.Count; ++_ci)
                        {
                            Logger.LogDebug("Adding constructor parameter {} {} {{{}}}", constrParams[_ci], Name, NamespaceName);
                            parameters.Add((constrParams[_ci], constrParamsDesc[_ci]));
                        }
                        break;
                    case "Examples":
                        // ! TODO: Implement
                        // ? TODO: Investigate if there are more examples somewhere
                        // Logger.LogDebug("Processing constructor examples {} {{{}}}", Name, NamespaceName);
                        // Console.WriteLine(h4CurrentElements[1].Name);
                        // examples.Add(h4CurrentElements[1].Name);
                        // examples.Add(h4CurrentElements[1].SelectSingleNode(".//code").InnerText.Trim());
                        break;
                    default:
                        break;
                }
            }
            constructors.Add(
                new DotnetConstructor()
                {
                    Name = _name,
                    Summary = sum,
                    Definition = Helpers2.SanitizeXmlToString(divs[^1].SelectSingleNode(".//pre/code").InnerText.Trim()),
                    Parameters = parameters,
                    Examples = examples,
                }
            );
        }

        return constructors;
    }

    // ! TODO: Void
    private List<DotnetMethod> _ProcessMethods(List<HtmlNode> value)
    {
        List<DotnetMethod> methods = [];
        Logger.LogDebug("!!!!Methods {}", value.Count);
        return methods;
    }

    internal void Process()
    {
        RestructuralizeClassDocument();
        return;
        Logger.LogInformation("Processing {} class {{{}}}", Name, NamespaceName);
        AssertDocumentIsClass();

        ProcessDefinition();
        ProcessProperties();
        ProcessConstructors();

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

    private void ProcessProperties()
    {
        Logger.LogInformation("Processing properties of class {name} {{{ns}}}", Name, NamespaceName);
        var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='properties' and @class='section']/following-sibling::*");
        if (elements == null)
        {
            Logger.LogInformation("Class does not define properties {} {{{}}}", Name, NamespaceName);
            return;
        }

        var breakLoop = false;
        var member = new DotnetProperty
        {
            Name = string.Empty,
        };

        // ? TODO: Try to filter only h3, divs between two h2
        foreach (var element in elements)
        {
            switch (element.Name)
            {
                // ! TODO: Handle summary
                case "h3":
                    // Actual property name
                    Logger.LogInformation("Changing current property from '{}' to '{}' {{{}}}", member.Name, element.InnerText.Trim(), NamespaceName);

                    member.Reset();
                    member.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual property summary / definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        try
                        {
                            member.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;

                    member.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (member.Name.IsNullOrEmpty()) break;

                    // ??? TODO: Why Properties.Add(property) does not work?
                    Properties.Add(new DotnetProperty()
                    {
                        Name = member.Name,
                        Summary = member.Summary,
                        Definition = Helpers2.SanitizeXmlToString(member.Definition),
                    });
                    member.Reset();
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

    private void ProcessConstructors()
    {
        Logger.LogInformation("Processing constructors of class {name} {{{ns}}}", Name, NamespaceName);
        var elements = HtmlDocument.DocumentNode.SelectNodes("//h2[@id='constructors' and @class='section']/following-sibling::*");
        if (elements == null)
        {
            Logger.LogInformation("Class does not define constructors {} {{{}}}", Name, NamespaceName);
            return;
        }

        /*
        <h3> - Constructor name
        <div> - Summary
        <div> - Definition
        <h4> - Parameters
        <dl> - Parameter X
        <dl> - Parameter X
        */
        var breakLoop = false;
        var member = new DotnetConstructor()
        {
            Name = string.Empty,
        };

        // ! TODOOO: Rework to something more contextual
        foreach (var element in elements)
        {
            switch (element.Name)
            {
                case "h3":
                    // Actual Constructor name
                    Logger.LogInformation("Changing current constructor from '{}' to '{}' {{{}}}", constructor.Name, element.InnerText.Trim(), NamespaceName);

                    constructor.Reset();
                    constructor.Name = element.InnerText.Trim();
                    break;
                case "div":
                    // Actual constructor summary / definition
                    var divClass = element.GetAttributeValue("class", "none");
                    // // Summary handling
                    if (divClass.Equals("markdown level1 summary"))
                    {
                        Logger.LogInformation("Processing constructor summary {{{}}}", NamespaceName);
                        try
                        {
                            constructor.Summary = element.SelectSingleNode(".//p").InnerText.Trim();
                        }
                        catch
                        {
                            // There is no paragraph under div
                        }
                        break;
                    }

                    // Definition handling
                    if (!divClass.Equals("codewrapper")) break;
                    Logger.LogInformation("Processing constructor definition {{{}}}", NamespaceName);

                    constructor.Definition = element.SelectSingleNode(".//pre/code").InnerText.Trim();
                    if (constructor.Name.IsNullOrEmpty()) break;
                    break;
                case "dl":
                    // Actual constructor parameter
                    Logger.LogInformation("Processing constructor parameter {{{}}}", NamespaceName);
                    var name = element.SelectSingleNode(".//dt/code").InnerText.Trim();
                    var sum = element.SelectSingleNode(".//dd/p").InnerText.Trim();
                    constructor.Parameters.Add(
                        (name, sum)
                    );

                    // There is no other parameter defined, saved the constructor
                    if (!element.NextSibling.Name.Equals("dl"))
                    {

                        // ? TODO: Investigate better approach to elimate hardcoding of such types
                        if (constructor.Definition.Contains(" StreamingContext ")) Usings.Add("System.Runtime.Serialization");
                        if (constructor.Definition.Contains(" SerializationInfo ")) Usings.Add("System.Runtime.Serialization");

                        Constructors.Add(new DotnetConstructor()
                        {
                            Name = constructor.Name,
                            Summary = constructor.Summary,
                            Definition = Helpers2.SanitizeXmlToString(constructor.Definition),
                            Parameters = constructor.Parameters,
                        });
                        constructor.Reset();
                    }
                    break;
                case "h4":
                    // Skip header with parameters
                    break;
                case "h2":
                    // Skip other group of members
                    breakLoop = true;
                    break;
                case "a":
                    break;
            }

            if (breakLoop) break;
        }

    }

    public void ProduceFinalCsFile()
    {
        Logger.LogInformation("Producting final dotnet cl file for class {} {{{}}}", Name, NamespaceName);
        var sb = new StringBuilder();

        // First process usings
        if (Usings.Count != 0)
        {
            Logger.LogInformation("Adding usings for class {} {{{}}}", Name, NamespaceName);
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
            Logger.LogInformation("Adding properties for class {} {{{}}}", Name, NamespaceName);
            Properties.ForEach(el => sb.AppendLine(el.Produce()));
            // Fields.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));
            // Events.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));

            if ((Enums.Count > 0 || Properties.Count > 0 || Fields.Count > 0 || Events.Count > 0) && Constructors.Count > 0) sb.AppendLine("");
            Logger.LogInformation("Adding constructors for class {} {{{}}}", Name, NamespaceName);
            Constructors.ForEach(el => sb.AppendLine(el.Produce()));

            // Methods.ForEach((el) =>
            // {
            //     sb.AppendLine("");
            //     sb.AppendLine(Helpers.PrefixEachLineSpaces(el));
            // });
        }

        sb.AppendLine("}"); // End class

        Logger.LogInformation("Writing cs file for class {} {{{}}}", Name, NamespaceName);
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
