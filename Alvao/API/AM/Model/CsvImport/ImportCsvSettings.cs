namespace Alvao.API.AM.Model.CsvImport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettings.html"/>
public class ImportCsvSettings {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettings.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettings_MaxRowsForSynchronousCheck"/>
    public const int MaxRowsForSynchronousCheck = 500;

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettings.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettings_InputFileStream"/>
    public Stream InputFileStream { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvSettings.html#Alvao_API_AM_Model_CsvImport_ImportCsvSettings_Settings"/>
    public ImportCsvSettingsInternal Settings { get; set; }
}
