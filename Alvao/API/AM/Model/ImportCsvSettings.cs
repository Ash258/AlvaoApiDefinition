namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_ImportCsvSettings.htm"/>
public class ImportCsvSettings {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ConnectionString.htm"/>
    public string ConnectionString { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_DateTimeFormat.htm"/>
    public string DateTimeFormat { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_DbName.htm"/>
    public string DbName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ImportedByPersonId.htm"/>
    public int? ImportedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ImportedObjectsParentId.htm"/>
    public int? ImportedObjectsParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ImportObjectKind.htm"/>
    public string ImportObjectKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ImportToDb.htm"/>
    public bool ImportToDb { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_IncludeScrapped.htm"/>
    public bool IncludeScrapped { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_InputFile.htm"/>
    public Stream InputFile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_Separator.htm"/>
    public string Separator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_ServerName.htm"/>
    public string ServerName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_SkipErrors.htm"/>
    public bool SkipErrors { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_ImportCsvSettings_SkipCheck.htm"/>
    public bool SkipCheck { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ImportCsvSettings__ctor.htm"/>
    public ImportCsvSettings() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ImportCsvSettings_GetKeyFields.htm"/>
    public string[] GetKeyFields() { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_ImportCsvSettings_SetKeyFields.htm"/>
    ///
    /// <param name="value"> </param>
    public void SetKeyFields(
        string[] value
    ) { throw new System.NotImplementedException(); }
}
