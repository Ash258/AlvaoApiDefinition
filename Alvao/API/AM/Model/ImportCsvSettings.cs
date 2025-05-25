namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html"/>
public class ImportCsvSettings {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ConnectionString"/>
    public string ConnectionString { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_DateTimeFormat"/>
    public string DateTimeFormat { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_DbName"/>
    public string DbName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ImportObjectKind"/>
    public string ImportObjectKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ImportToDb"/>
    public bool ImportToDb { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ImportedByPersonId"/>
    public int? ImportedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ImportedObjectsParentId"/>
    public int? ImportedObjectsParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_IncludeScrapped"/>
    public bool IncludeScrapped { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_InputFile"/>
    public Stream InputFile { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_Separator"/>
    public string Separator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_ServerName"/>
    public string ServerName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_SkipCheck"/>
    public bool SkipCheck { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_SkipErrors"/>
    public bool SkipErrors { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_TextOutput"/>
    public IFormattedTextWriter TextOutput { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_GetKeyFields"/>
    public string[] GetKeyFields() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.ImportCsvSettings.html#Alvao_API_AM_Model_ImportCsvSettings_SetKeyFields_System_String___"/>
    public void SetKeyFields(string[] value) { throw new NotImplementedException(); }
}
