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
                expectedConstructorsCount = 2;
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
}
