namespace Alvao.API.AM.Model.CsvImport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html"/>
public class ImportCsvSettingsInternal {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_Action"/>
    public ImportAction Action { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ConnectionString"/>
    public string ConnectionString { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_DateTimeFormat"/>
    public string DateTimeFormat { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_DbName"/>
    public string DbName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_HangfireJobIdentifier"/>
    public string HangfireJobIdentifier { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ImportObjectKind"/>
    public string ImportObjectKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ImportToDb"/>
    public bool ImportToDb { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ImportedByPersonId"/>
    public int? ImportedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ImportedObjectsParentId"/>
    public int? ImportedObjectsParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_IncludeScrapped"/>
    public bool IncludeScrapped { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_Origin"/>
    public ImportOrigin Origin { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ProgressReporter"/>
    public ImportCsvProgress ProgressReporter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_RecordId"/>
    public int RecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_RunInBackground"/>
    public bool RunInBackground { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_Separator"/>
    public string Separator { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_ServerName"/>
    public string ServerName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_SkipCheck"/>
    public bool SkipCheck { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_SkipErrors"/>
    public bool SkipErrors { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_TicketId"/>
    public int? TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettingsInternal.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettingsInternal_keyFields"/>
    public string[] keyFields { get; set; }
}
