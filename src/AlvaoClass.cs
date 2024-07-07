using System.Text;
using System.Text.RegularExpressions;
using HtmlAgilityPack;

namespace AlvaoScapper;

public class AlvaoClass
{
    public enum ClassType
    {
        CLASS,
        INTERFACE,
    }
    public AlvaoNamespace Namespace { get; set; }
    public string NamespaceName { get; set; }
    public string Version { get; set; }
    public string Name { get; set; }
    public string Summary { get; set; }
    public ClassType Type { get; set; }
    public string FullUrl { get; set; }
    public string LocalHtmlFile { get; set; }
    public string FinalCsFile { get; set; }
    public HtmlDocument HtmlDocument { get; set; }
    public string Definition { get; set; } = "";
    public List<string> Usings { get; set; }

    public List<string> Enums { get; set; }
    public List<string> Properties { get; set; }
    public List<string> Fields { get; set; }
    public List<string> Events { get; set; }
    public List<string> Constructors { get; set; }
    public List<string> Methods { get; set; }

    public AlvaoClass(string fullUrl, string localHtmlFile, string namespaceName, string name, ClassType type = ClassType.CLASS)
    {
        Type = type;
        Usings = [];
        Fields = [];
        Version = "";
        Properties = [];
        Enums = [];
        Methods = [];
        Events = [];
        Constructors = [];
        FullUrl = fullUrl;
        LocalHtmlFile = localHtmlFile;
        NamespaceName = namespaceName;
        Name = name;
        HtmlDocument = Helpers.LoadDocument(fullUrl, localHtmlFile);
        FinalCsFile = $"{namespaceName.Replace(".", "/")}/{name}.cs";
        Summary = Helpers.GetSummary(HtmlDocument);
    }

    internal static void ProcessClass(HtmlNode cl, AlvaoNamespace an)
    {
        var aNode = cl.SelectNodes(".//a").Last();
        var className = aNode.GetAttributeValue("title", "");
        if (!className.EndsWith(" Class") && !className.EndsWith(" Interface")) return;

        var classHtmlBaseFileName = aNode.GetAttributeValue("href", "").Split("/").Last();
        var clazz = new AlvaoClass(
            $"{Helpers.BASE_HTML_URL}/{classHtmlBaseFileName}",
            $"{Helpers.LOCAL_HTML_FOLDER}/{classHtmlBaseFileName}",
            an.Name,
            className.Replace(" Class", "").Replace(" Interface", "").Trim(),
            className.EndsWith("Interface") ? ClassType.INTERFACE : ClassType.CLASS
        );
        clazz.Process();
    }

    public void Process()
    {
        Console.WriteLine($"  Processing {Name} Class");

        // TODO: Drop
        if (Helpers.IsInvalidClass(NamespaceName, Name)) return;

        var _def = Helpers.ExtractObjectDefinition(HtmlDocument);
        if (_def == null) return;

        Definition = Helpers.SanitizeXmlToString(_def);

        Helpers.ProcessVersion(HtmlDocument);
        ProcessProperties();
        ProcessFields();
        ProcessEvents();
        ProcessConstructors();
        ProcessMethods();

        // TODO: Drop
        MonkeyPatching();

        State.Classes.Add($"{NamespaceName}.{Name}", this);

        ProduceFinalCsFile();
    }

    public void ProcessProperties()
    {
        var properties = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"PropertyList\"]/tr/td[2]/a");
        if (properties == null) return;

        foreach (var p in properties)
        {
            var propName = Helpers.ExtractObjectName(p);
            Console.WriteLine($"    Processing {propName} Property");

            // TODO: Drop
            if (Helpers.IsClass(this, "Alvao.Context", "AlvaoContext") && propName.Equals("DbContextProvider")) continue;
            if (Helpers.IsClass(this, "Alvao.API.AM.Model", "ImportCsvSettings") && propName.Equals("TextOutput")) continue;

            var propHtmlBaseFileName = p.GetAttributeValue("href", "").Split("/").Last();
            var propLink = $"{Helpers.BASE_HTML_URL}/{propHtmlBaseFileName}";
            var propLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{propHtmlBaseFileName}";
            if (!propLink.StartsWith("https://doc.alvao")) continue;
            if (!propLink.EndsWith(".htm")) continue;

            var propDocument = Helpers.LoadDocument(propLink, propLocalHtml);
            var _summary = Helpers.GetSummary(propDocument);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var _sb = new StringBuilder();
            if (!_summary.Equals("")) _sb.AppendLine(_summary);
            _sb.AppendLine(Helpers.GenerateSeeDoc(propLink));

            var propDef = Helpers.ExtractObjectDefinition(propDocument);
            if (propDef == null) continue;

            // TODO: Drop
            if (Helpers.IsClass(this, "Alvao.API.Common.Model", "ColumnValue") && propName.Equals("DataType"))
                propDef = propDef.Replace(" Database.ValueDataType ", " Alvao.API.Common.Database.ValueDataType ");

            propDef = Helpers.SanitizeXmlToString(propDef);

            // TODO: Drop
            if (propDef.Contains(" IDbContextProvider ")) Usings.Add("Volo.Abp.EntityFrameworkCore");
            if (propDef.Contains(" IDbConnection ")) Usings.Add("System.Data");
            if (propDef.Contains(" SqlConnection ")) Usings.Add("Microsoft.Data.SqlClient");
            if (propDef.Contains(" HttpStatusCode ")) Usings.Add("System.Net");
            if (propDef.Contains(" CultureInfo ")) Usings.Add("System.Globalization");
            if (propDef.Contains("[JsonPropertyAttribute(")) Usings.Add("Newtonsoft.Json");
            if (propDef.Contains("[JsonIgnoreAttribute]")) Usings.Add("Newtonsoft.Json");
            if (propDef.Contains("[KeyAttribute]")) Usings.Add("Dapper.Contrib.Extensions");
            if (propDef.Contains("[ComputedAttribute]")) Usings.Add("Dapper.Contrib.Extensions");

            _sb.AppendLine(propDef);
            Properties.Add(_sb.ToString());
        }
    }

    public void ProcessFields()
    {
        var fields = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"FieldList\"]/tr/td[2]/a");
        if (fields == null) return;

        foreach (var f in fields)
        {
            var fieldName = Helpers.ExtractObjectName(f);
            Console.WriteLine($"    Processing {fieldName} Field");

            var fieldHtmlBaseFileName = f.GetAttributeValue("href", "").Split("/").Last();
            var fieldLink = $"{Helpers.BASE_HTML_URL}/{fieldHtmlBaseFileName}";
            var fieldLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{fieldHtmlBaseFileName}";
            if (!fieldLink.StartsWith("https://doc.alvao")) continue;
            if (!fieldLink.EndsWith(".htm")) continue;

            var fieldDocument = Helpers.LoadDocument(fieldLink, fieldLocalHtml);
            var _summary = Helpers.GetSummary(fieldDocument);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var _sb = new StringBuilder();
            if (!_summary.Equals("")) _sb.AppendLine(_summary);
            _sb.AppendLine(Helpers.GenerateSeeDoc(fieldLink));

            var fieldDef = Helpers.ExtractObjectDefinition(fieldDocument);
            if (fieldDef == null) continue;
            fieldDef = Helpers.SanitizeXmlToString(fieldDef);

            // TODO: Drop
            if (fieldName.Equals("EmailFormat")) fieldDef = fieldDef.Replace("\"]", "\"\"]");
            if (new[] { "EmailFormat", "EmailPattern" }.Contains(fieldName)) fieldDef = fieldDef.Replace("= \"", "= @\"");

            _sb.AppendLine(fieldDef);
            Fields.Add(_sb.ToString());
        }
    }

    private void ProcessEvents()
    {
        var elements = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"EventList\"]/tr/td[2]/a");
        if (elements == null) return;

        foreach (var e in elements)
        {
            var _name = Helpers.ExtractObjectName(e);
            Console.WriteLine($"    Processing {_name} Method");

            var _htmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
            var _link = $"{Helpers.BASE_HTML_URL}/{_htmlBaseFileName}";
            var _localHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{_htmlBaseFileName}";
            if (!_link.StartsWith("https://doc.alvao")) continue;
            if (!_link.EndsWith(".htm")) continue;

            var _document = Helpers.LoadDocument(_link, _localHtml);
            var _summary = Helpers.GetSummary(_document);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var _sb = new StringBuilder();
            if (!_summary.Equals("")) _sb.AppendLine(_summary);
            _sb.AppendLine(Helpers.GenerateSeeDoc(_link));

            var _definition = Helpers.ExtractObjectDefinition(_document);
            if (_definition == null) continue;

            _sb.AppendLine(Helpers.SanitizeXmlToString(_definition));

            Events.Add(_sb.ToString());
        }
    }

    private void ProcessConstructors()
    {
        var constructors = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"ConstructorList\"]/tr/td[2]/a");
        if (constructors == null) return;

        foreach (var c in constructors)
        {
            var constrName = Helpers.ExtractObjectName(c);
            Console.WriteLine($"    Processing {constrName} Constructor");

            var constrHtmlBaseFileName = c.GetAttributeValue("href", "").Split("/").Last();
            var constrLink = $"{Helpers.BASE_HTML_URL}/{constrHtmlBaseFileName}";
            var constrLocalHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{constrHtmlBaseFileName}";

            var constrDocument = Helpers.LoadDocument(constrLink, constrLocalHtml);
            var constrDef = Helpers.ExtractObjectDefinition(constrDocument);
            if (constrDef == null) continue;

            var _summary = Helpers.GetSummary(constrDocument);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var _sb = new StringBuilder();
            if (!_summary.Equals("")) _sb.AppendLine(_summary);
            _sb.AppendLine(Helpers.GenerateSeeDoc(constrLink));

            constrDef = Helpers.SanitizeXmlToString(constrDef);

            // TODO: Drop
            if (constrDef.Contains(" StreamingContext ")) Usings.Add("System.Runtime.Serialization");
            if (constrDef.Contains(" SerializationInfo ")) Usings.Add("System.Runtime.Serialization");

            _sb.AppendLine(constrDef);

            Constructors.Add(_sb.ToString());
        }
    }

    private void ProcessMethods()
    {
        var elements = HtmlDocument.DocumentNode.SelectNodes("//table[@id=\"MethodList\"]/tr/td[2]/a");
        if (elements == null) return;

        bool emailQueueProcessed = false;

        foreach (var e in elements)
        {
            var _name = Helpers.ExtractObjectName(e);

            // TODO: Drop
            if (emailQueueProcessed) continue;
            if (Helpers.IsClass(this, "Alvao.API.Common.Model", "AttachmentModel") && _name.Equals("SaveToDB")) continue;
            if (Helpers.IsClass(this, "Alvao.API.Common.Model", "HtmlTextModel") && _name.Equals("AddAttachmentsBasedOnTemplate")) continue;
            if (Helpers.IsClass(this, "Alvao.API.Common", "Email") && _name.Contains("Queue")) emailQueueProcessed = true;
            if (Helpers.IsClass(this, "Alvao.API.SD", "Sections") && _name.Equals("Import")) continue;
            if (Helpers.IsClass(this, "Alvao.API.SD", "Sections") && _name.Equals("ValidateBeforeImport")) continue;

            Console.WriteLine($"    Processing {_name} Method");

            var _htmlBaseFileName = e.GetAttributeValue("href", "").Split("/").Last();
            var _link = $"{Helpers.BASE_HTML_URL}/{_htmlBaseFileName}";
            var _localHtml = $"{Helpers.LOCAL_HTML_FOLDER}/{_htmlBaseFileName}";
            if (!_link.StartsWith("https://doc.alvao")) continue;
            if (!_link.EndsWith(".htm")) continue;

            var _document = Helpers.LoadDocument(_link, _localHtml);
            var _summary = Helpers.GetSummary(_document);
            if (_summary.Contains("Obsolete") || _summary.Contains("obsolete")) continue;
            var _sb = new StringBuilder();
            if (!_summary.Equals("")) _sb.AppendLine(_summary);
            _sb.AppendLine(Helpers.GenerateSeeDoc(_link));

            var _definition = Helpers.ExtractObjectDefinition(_document);
            if (_definition == null) continue;
            if (_definition.Contains("ObsoleteAttribute")) continue;

            var _params = _document.DocumentNode.SelectSingleNode("//*[@id=\"IDBSection\"]/dl");
            if (_params != null)
            {
                _sb.AppendLine($"///");
                var _dts = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dt");
                var _dds = _document.DocumentNode.SelectNodes("//*[@id=\"IDBSection\"]/dl/dd");

                for (int i = 0; i < _dts.Count; i++)
                {
                    var _var = _dts[i].SelectSingleNode(".//span")?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " "); ;
                    var _description = _dds[i]?.InnerText.Trim().Replace("&lt;", "<").Replace("&gt;", ">").Replace("&nbsp;", " ");
                    if (_description == null) continue;

                    _description = Helpers.ReplaceEndLinesWithSpace(_description);
                    _sb.AppendLine($"/// <param name=\"{_var}\">{_description}</param>");
                }
            }

            _definition = Helpers.SanitizeXmlToString(_definition);
            // TODO: Drop
            _definition = MonkeyPatch.Methods(this, _name, _definition);
            _sb.AppendLine(_definition);

            Methods.Add(_sb.ToString());
        }
    }

    public void ProduceFinalCsFile()
    {
        var sb = new StringBuilder();

        if (Usings.Count != 0)
        {
            Usings.Distinct().Order().ToList().ForEach(el => sb.AppendLine($"using {el};"));
            sb.AppendLine("");
        }

        sb.AppendLine($"namespace {NamespaceName};");
        sb.AppendLine("");

        if (!Summary.Equals("")) sb.AppendLine(Summary);
        sb.AppendLine($"/// <see href=\"{FullUrl}\"/>");
        sb.AppendLine(Definition);
        sb.AppendLine("{");

        Enums.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)}"));
        Properties.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)}"));
        Fields.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));
        Events.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)};"));

        if ((Enums.Count > 0 || Properties.Count > 0 || Fields.Count > 0 || Events.Count > 0) && Constructors.Count > 0) sb.AppendLine("");
        Constructors.ForEach(el => sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)} {{}}"));

        Methods.ForEach((el) =>
        {
            var del = Type == ClassType.CLASS
                ? " { throw new System.NotImplementedException(); }"
                : ";";
            sb.AppendLine("");
            sb.AppendLine($"{Helpers.PrefixEachLineSpaces(el)}{del}");
        });
        sb.AppendLine("}");

        File.WriteAllText(FinalCsFile, sb.ToString());
    }

    private void MonkeyPatching()
    {
        if (Definition.Contains("TableAttribute(")) Usings.Add("Dapper.Contrib.Extensions");
        if (Definition.Contains(": Profile")) Usings.Add("AutoMapper");
        if (Definition.Contains(": tbl")) Usings.Add("Alvao.API.Common.Model.Database");
        if (Definition.Contains(": vColumnLoc")) Usings.Add("Alvao.API.Common.Model.Database");

        switch (NamespaceName)
        {
            case "Alvao.API.AI":
                switch (Name)
                {
                    case "Assistant":
                        Usings.Add("Alvao.API.AI.Model");
                        break;
                }
                break;
            case "Alvao.API.AM.Exceptions":
                switch (Name)
                {
                    case "InvalidMoveException":
                    case "InvalidBulkMoveException":
                        Usings.Add("System.Runtime.Serialization");
                        break;
                }
                break;
            case "Alvao.API.AM":
                switch (Name)
                {
                    case "Installation":
                    case "Product":
                    case "ObjectRight":
                    case "License":
                    case "Scim":
                        Usings.Add("Alvao.API.Common.Model.Database");
                        break;

                    case "Object":
                    case "ObjectProperty":
                        Usings.AddRange(["Alvao.API.AM.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                }
                break;
            case "Alvao.API.SD.Exceptions":
                switch (Name)
                {
                    case "RequiredFieldsException":
                        Usings.Add("Alvao.API.SD.Model");
                        break;
                }
                break;
            case "Alvao.API.SD":
                switch (Name)
                {
                    case "WorkLoad":
                    case "Section":
                    case "TicketParticipant":
                    case "TeamsNotification":
                    case "Organization":
                        Usings.Add("Alvao.API.Common.Model.Database");
                        break;
                    case "Approval":
                        Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                    case "MessageTemplate":
                        Usings.AddRange(["Alvao.API.Common.Model", "System.Globalization"]);
                        break;
                    case "TicketProcess":
                        Usings.AddRange(["Alvao.API.SD.Model", "System.Globalization"]);
                        break;
                    case "TicketState":
                        Usings.AddRange(["Alvao.API.Common.Model.Database", "Alvao.API.SD.Model"]);
                        break;
                    case "Message":
                    case "Ticket":
                    case "Act":
                        Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database", "Alvao.API.SD.Model"]);
                        break;
                }
                break;
            case "Alvao.Context.DB":
                switch (Name)
                {
                    case "IConnectionScope":
                        Usings.AddRange(["System.Data", "Microsoft.Data.SqlClient"]);
                        break;
                }
                break;
            case "Alvao.Context":
                switch (Name)
                {
                    case "AlvaoContext":
                        Usings.AddRange(["Alvao.Context.DB", "Volo.Abp.EntityFrameworkCore"]);
                        break;
                }
                break;
            case "Alvao.API.SD.Model":
                switch (Name)
                {
                    case "TicketProcessColumnModel":
                    case "TicketTemplateColumnModel":
                    case "InitialActSettings":
                    case "RelatedTicketRuleModel":
                    case "SendMessageSettingsModel":
                    case "ActCreateSettings":
                        Usings.Add("Alvao.API.Common.Model.Database");
                        break;

                    case "NewTicketModel":
                        Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;

                    case "ChangeTicketStateSettingsModel":
                        Usings.AddRange(["Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                }
                break;
            case "Alvao.API.Common":
                switch (Name)
                {
                    case "CustomColumn":
                        Usings.AddRange(["System.Globalization", "Alvao.API.Common.Model", "Alvao.API.Common.Model.Database"]);
                        break;
                    case "AuditLog":
                        Usings.Add("Alvao.API.Common.Model");
                        break;
                    case "Email":
                        Usings.Add("System.Net.Mail");
                        break;
                    case "Person":
                        Usings.AddRange(["System.Globalization", "Alvao.API.Common.Model.Database"]);
                        break;

                    case "Role":
                    case "PersonRights":
                        Usings.Add("Alvao.API.Common.Model.Database");
                        break;
                }
                break;
        }
    }
}
