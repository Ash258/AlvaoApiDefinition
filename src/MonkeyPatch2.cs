using Microsoft.Extensions.Logging;

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
        if (null == swLibraryNs)
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
    }

    // TODO: It will be faster when this will be done while the definitions are processed
    public static void PatchDefinitions(AlvaoClass2 clazz)
    {
        List<string> definitions = clazz.GetAllDefinitionsAsList();

        List<(string, string)> map =
        [
            ("CultureInfo ", "System.Globalization"),
            ("HttpStatusCode ", "System.Net"),
            ("EmbeddingCreateResponse ", "System.Net.Http"),
            ("[JsonProperty", "Newtonsoft.Json"),
            ("AssistantTicketTabModel ", "Alvao.API.AI.Model"),
            ("AddUnknownSwRequest ", "Alvao.API.AM.Model.SwLibrary"),
            ("[ExplicitKey]", "Dapper.Contrib"),
            ("[Key]", "Dapper.Contrib.Extensions"),
            ("[Table(", "Dapper.Contrib.Extensions"),
            ("TicketTemplateColumnValue ", "Alvao.API.Common.Model.Database"),
            (" IProfileConfiguration", "AutoMapper"),
            (" vColumnLoc", "Alvao.API.Common.Model.Database"),
            ("tPerson ", "Alvao.API.Common.Model.Database"),
            ("tRole", "Alvao.API.Common.Model.Database"),
            ("[JsonIgnore", "Newtonsoft.Json"),
            (" ILogger", "Microsoft.Extensions.Logging"),
            ("ActMark.ActMarkId", "Alvao.API.Common.Model.Database"),
        ];

        foreach (var d in definitions)
        {
            foreach (var m in map)
            {
                if (d.Contains(m.Item1)) clazz.Usings.Add(m.Item2);
            }
        }
    }

    public static void SpecificMethod(AlvaoClass2 clazz, DotnetMethod method, ILogger Logger)
    {
        Logger.LogInformation("Monkeypatching method {} [{}] {{{}}}", method.Name, clazz.Name, clazz.NamespaceName);

        if (IsClass(clazz, "Alvao.API.Common", "ProfileValue"))
        {
            // ! TODO: Make it more context aware with Returns property
            switch (method.Name)
            {
                case "Get":
                    Logger.LogInformation("Monkeypatching method {} [{}] {{{}}}", method.Name, clazz.Name, clazz.NamespaceName);
                    method.Definition = method.Definition.Replace(" ProfileValue ", " Alvao.API.Common.Model.Database.ProfileValue ");
                    break;
            }
        }
    }
}

public class MonkeyPatchLogger
{

}
