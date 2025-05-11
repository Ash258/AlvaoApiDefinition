using Microsoft.Extensions.Logging;
using static AlvaoScrapper.Helpers2;

namespace AlvaoScrapper;

public static class MonkeyPatch2
{
    public static void AssertGenerationOK(AlvaoClass2 clazz)
    {
        var expectedNamespaceName = string.Empty;
        var expectedMethodCount = 0;
        var expectedPropsCount = 0;
        var expectedFieldsCount = 0;
        var expectedConstructorsCount = 0;
        var expectedEnumsCount = 0;

        switch (clazz.Name)
        {
            //#endregion Alvao.API.Common.Model
            case "AttachmentModel":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedConstructorsCount = 1;
                expectedMethodCount = 2;
                expectedPropsCount = 8;
                break;
            case "AadSetting":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedPropsCount = 3;
                break;
            case "LogOperation":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedEnumsCount = 1;
                break;
            case "ColumnModel":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedPropsCount = 13;
                break;
            case "HtmlTextModel":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedConstructorsCount = 1;
                expectedPropsCount = 4;
                expectedMethodCount = 3;
                break;
            case "ExternalServices":
                expectedNamespaceName = "Alvao.API.Common.Model";
                expectedFieldsCount = 9;
                break;
            //#endregion Alvao.API.Common.Model
            default:
                return;
                break;
        }

        if (expectedConstructorsCount != clazz.Constructors.Count ||
            expectedMethodCount != clazz.Methods.Count ||
            expectedPropsCount != clazz.Properties.Count ||
            expectedFieldsCount != clazz.Fields.Count ||
            expectedEnumsCount != clazz.Enums.Count ||
            !Equals(expectedNamespaceName, clazz.NamespaceName)
        )
        {
            Console.WriteLine($"{clazz.NamespaceName}/{clazz.Name} Class was processed incorrectly (" +
                $"C: {clazz.Constructors.Count} [{expectedConstructorsCount}], " +
                $"P: {clazz.Properties.Count} [{expectedPropsCount}], " +
                $"F: {clazz.Fields.Count} [{expectedFieldsCount}], " +
                $"M: {clazz.Methods.Count} [{expectedMethodCount}] " +
                $"E: {clazz.Enums.Count} [{expectedEnumsCount}] " +
                $"Namespace: {expectedNamespaceName}]" +
                ")"
            );
        }
    }

    public static void PatchUnDocumentedClasses(ILogger Logger)
    {
        var caution = "!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable";
        var swLibraryNs = State.Namespaces.GetValueOrDefault("Alvao.API.AM.Model.SwLibrary");
        var commonModelDataseNs = State.Namespaces.GetValueOrDefault("Alvao.API.Common.Model.Database");
        if (null == swLibraryNs || null == commonModelDataseNs)
        {
            Logger.LogWarning("Cannot generate undocumented classes");
            return;
        }

        foreach (var name in new string[] { "ArchiveStream", "ISwLibRepository" })
        {
            var clazz = new AlvaoClass2(
                name,
                "Class",
                swLibraryNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }

        foreach (var name in new string[] { "IDocumentRepository", "IDetectionRepository" })
        {
            var clazz = new AlvaoClass2(
                name,
                "Class",
                commonModelDataseNs,
                caution,
                $"public class {name}",
                [],
                [],
                [],
                [],
                []
            );

            clazz.ProduceFinalCsFile();
        }
    }

    public static void PatchUsings(AlvaoClass2 clazz, ILogger Logger)
    {
        List<string> toAdd = [];

        switch (clazz.NamespaceName)
        {
            case "Alvao.API.AM":
                toAdd.Add("Alvao.API.Common.Model.Database");
                break;
            case "Alvao.API.Common.Model.Database":
                AddUsingByClassName("DatabaseModelAutomapperProfile", "AutoMapper", clazz.Name, toAdd);
                break;
            case "Alvao.API.SD":
                toAdd.Add("Alvao.API.Common.Model.Database");
                AddUsingByClassName("TicketState", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                break;
            case "Alvao.API.SD.Model":
                AddUsingByClassName("TicketTemplateColumnModel", "Alvao.API.Common.Model.Database", clazz.Name, toAdd);
                break;
        }

        if (toAdd.Count == 0) return;

        Logger.LogInformation("Monkeypatching usings [{}] {{{}}}", clazz.Name, clazz.NamespaceName);
        clazz.Usings.AddRange(toAdd);
    }

    // TODO: It will be faster when this will be done while the definitions are processed
    public static void UsingsBasedOnDefinitions(AlvaoClass2 clazz, ILogger Logger)
    {
        List<string> definitions = clazz.GetAllDefinitionsAsList();

        List<(string, string)> map =
        [
            // Exceptions
            ("ValidationInExecuteException", "System.Runtime.Serialization"),
            ("TicketApprovalNotInProgressException", "System.Runtime.Serialization"),
            ("UserTokenServiceError", "System.Runtime.Serialization"),
            ("TranslationsSecretsInvalidException", "System.Runtime.Serialization"),

            // ORM specific annotations
            ("[ExplicitKey]", "Dapper.Contrib"),
            ("[Key]", "Dapper.Contrib.Extensions"),
            ("[Table(", "Dapper.Contrib.Extensions"),
            ("[JsonIgnore]", "Newtonsoft.Json"),
            ("[JsonProperty", "Newtonsoft.Json"),
            (" ILogger", "Microsoft.Extensions.Logging"),

            (" ISerializable", "System.Runtime.Serialization"),
            (" CultureInfo ", "System.Globalization"),
            (" XmlDetection", "System.Xml"),
            (" HttpStatusCode ", "System.Net"),

            // AI
            (" AssistantTicketTabModel ", "Alvao.API.AI.Model"),

            ("IDocumentRepository", "Alvao.API.Common.Model.Database"),
            ("HtmlTextModel ", "Alvao.API.Common.Model"),
            ("CostModel ", "Alvao.API.SD.Model"),

            // ("EmbeddingCreateResponse ", "System.Net.Http"),
            // ("AssistantTicketTabModel ", "Alvao.API.AI.Model"),
            // ("AddUnknownSwRequest ", "Alvao.API.AM.Model.SwLibrary"),
            // ("TicketTemplateColumnValue ", "Alvao.API.Common.Model.Database"),
            // (" IProfileConfiguration", "AutoMapper"),
            // (" vColumnLoc", "Alvao.API.Common.Model.Database"),
            // ("tPerson ", "Alvao.API.Common.Model.Database"),
            // ("<tPerson>", "Alvao.API.Common.Model.Database"),
            // ("tRole", "Alvao.API.Common.Model.Database"),
            // ("ActMark.ActMarkId", "Alvao.API.Common.Model.Database"),
            // ("TicketTemplate", "Alvao.API.Common.Model.Database"),
            // ("tblKind", "Alvao.API.Common.Model.Database"),
            // ("tHdTicket", "Alvao.API.Common.Model.Database"),
            // ("tHdSection", "Alvao.API.Common.Model.Database"),
            // ("tSlaRights", "Alvao.API.Common.Model.Database"),
            // ("tAccount", "Alvao.API.Common.Model.Database"),
            // ("tHdSectionRights", "Alvao.API.Common.Model.Database"),
            // ("tAct", "Alvao.API.Common.Model.Database"),
            // // TODO: Determine which TicketState is correct - Model or static class
            // ("TicketState", "Alvao.API.Common.Model.Database"),
            // // ("<TicketState>", "Alvao.API.SD"),
            // (" CommandDesc", "Alvao.API.Common.Model.CustomApps"),
            // ("IDetectionRepository", "Alvao.API.Common.Model.Database"),
            // ("static class WorkLoad", "Alvao.API.Common.Model.Database"),
        ];

        foreach (var d in definitions)
        {
            foreach (var m in map)
            {
                if (d.Contains(m.Item1))
                {
                    Logger.LogDebug("Monkeypatching using {} [{}] {{{}}}", m.Item2, clazz.Name, clazz.NamespaceName);
                    clazz.Usings.Add(m.Item2);
                }
            }
        }
    }

    public static void CreateMethods(AlvaoClass2 clazz, ILogger Logger)
    {
        Logger.LogDebug("Monkeypatching missing methods [{}] {{{}}}", clazz.Name, clazz.NamespaceName);

        List<(string, string)> map =
        [
            ("XmlDetection", "public object Clone()"),
        ];

        foreach (var m in map)
        {
            if (clazz.Name.Contains(m.Item1))
            {
                Logger.LogDebug("Creating method {} [{}] {{{}}}", m.Item2, clazz.Name, clazz.NamespaceName);
                clazz.Methods.Add(new DotnetMethod()
                {
                    Name = $"Patched {m.Item2}",
                    Definition = m.Item2,
                    Summary = "!!!CAUTION: This method is not document. It was generated as empty, to make the project compilable",
                    Parameters = [],
                    Exceptions = [],
                    Returns = string.Empty,
                });
            }
        }
    }

    // Monkeypatch methods and usings based on classes and it's methods
    public static void SpecificMethod(AlvaoClass2 clazz, DotnetMethod method, ILogger Logger)
    {
        var _def = string.Empty;

        if (IsClass(clazz, "Alvao.API.Common", "ProfileValue") && string.Equals(method.Name, "Get"))
            _def = method.Definition.Replace(" ProfileValue ", " Alvao.API.Common.Model.Database.ProfileValue ");

        if (IsClass(clazz, "Alvao.API.Common", "Role") || IsClass(clazz, "Alvao.API.Common", "Person"))
        {
            clazz.Usings.Add("Alvao.API.Common.Model.Database");
        }

        if (IsClass(clazz, "Alvao.API.AM", "CustomApps") || IsClass(clazz, "Alvao.API.SD", "CustomApps"))
        {
            clazz.Usings.AddRange(["Alvao.API.Common.Model.CustomApps", "Alvao.API.Common.Model.CustomApps.Requests"]);
        }

        if (IsClass(clazz, "Alvao.API.AM.Model.Detection", "XmlDetection"))
        {
            clazz.Usings.Add("System.Xml.XPath");
        }

        if (IsClass(clazz, "Alvao.API.AM.Model.Detection", "CompareProperty"))
        {
            clazz.Usings.AddRange(["Alvao.API.Common.Model.Database", "System.Data", "static Alvao.API.Common.Model.Database.KindDataType"]);
        }
        if (IsClass(clazz, "Alvao.API.AM.Model.Detection", "DetectLog"))
        {
            clazz.Usings.Add("Alvao.API.Common.Model.Database");
        }

        if (IsClass(clazz, "Alvao.API.Common", "Email"))
        {
            clazz.Usings.Add("Rebex");
            // TODO: Find better way, idealy with example contains
            switch (method.Name)
            {
                case "Queue":
                    _def = method.Definition.Replace("(MailMessage ", "(Rebex.Mail.MailMessage ");
                    if (clazz.Methods.Count == 1)
                        _def = method.Definition.Replace("(MailMessage ", "(System.Net.Mail.MailMessage ");
                    break;
                case "QueueMailMessage":
                    _def = method.Definition.Replace("(MailMessage ", "(Rebex.Mail.MailMessage ");
                    if (clazz.Methods.Count == 3)
                        _def = method.Definition.Replace("(MailMessage ", "(System.Net.Mail.MailMessage ");
                    break;
            }
        }

        if (IsClass(clazz, "Alvao.API.SD", "TicketState"))
        {
            clazz.Usings.Add("Alvao.API.SD.Model");

            switch (method.Name)
            {
                case "GetStatesFromProcess":
                case "GetFromProcess":
                    _def = method.Definition.Replace("<TicketState>", "<Alvao.API.Common.Model.Database.TicketState>");
                    break;
                case "GetByBehaviorId":
                case "GetById":
                case "GetByName":
                case "GetCurrentStateByTicketId":
                    _def = method.Definition.Replace(" TicketState ", " Alvao.API.Common.Model.Database.TicketState ");
                    break;
            }
        }
        if (IsClass(clazz, "Alvao.API.Common", "Webhook"))
        {
            switch (method.Name)
            {
                case "Create":
                case "Delete":
                case "GetById":
                    _def = method.Definition.Replace(" Webhook ", " Alvao.API.Common.Model.Database.Webhook ");
                    break;
                case "GetTopicById":
                    _def = method.Definition.Replace(" WebhookTopic ", " Alvao.API.Common.Model.Database.WebhookTopic ");
                    break;
            }
        }

        if (string.IsNullOrEmpty(_def)) return;

        Logger.LogInformation("Monkeypatching method {} [{}] {{{}}}", method.Name, clazz.Name, clazz.NamespaceName);
        method.Definition = _def;
    }
}

public class MonkeyPatchLogger
{

}
