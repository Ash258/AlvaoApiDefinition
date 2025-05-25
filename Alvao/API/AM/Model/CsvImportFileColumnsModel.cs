namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImportFileColumnsModel.html"/>
public class CsvImportFileColumnsModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImportFileColumnsModel.html#Alvao_API_AM_Model_CsvImportFileColumnsModel_ImportFileColumns"/>
    public IEnumerable<string> ImportFileColumns { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImportFileColumnsModel.html#Alvao_API_AM_Model_CsvImportFileColumnsModel_RequireObjectClass"/>
    public bool RequireObjectClass { get; set; }
}
