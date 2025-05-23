namespace Alvao.API.Common.Model.Translations;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html"/>
public class ExportItem {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem_AliasTableColumn"/>
    public string AliasTableColumn { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem_Condition"/>
    public string Condition { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem_KeyColumn"/>
    public string KeyColumn { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem_MaxColumnLenght"/>
    public int MaxColumnLenght { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem_TableColumn"/>
    public string TableColumn { get; set; }


    /// <param name="tableColumn"></param>
    /// <param name="keyColumn"></param>
    /// <param name="condition"></param>
    /// <param name="aliasTableColumn"></param>
    /// <param name="maxColumnLenght"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Translations.ExportItem.html#Alvao_API_Common_Model_Translations_ExportItem__ctor_System_String_System_String_System_String_System_String_System_Int32_"/>
    public ExportItem(string tableColumn, string keyColumn, string condition, string aliasTableColumn = null, int maxColumnLenght = 2147483647) { }
}
