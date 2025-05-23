namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Model_CsvImportFileColumnsModel.htm"/>
public class CsvImportFileColumnsModel {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_CsvImportFileColumnsModel_ImportFileColumns.htm"/>
    public IEnumerable<string> ImportFileColumns { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AM_Model_CsvImportFileColumnsModel_RequireObjectClass.htm"/>
    public bool RequireObjectClass { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Model_CsvImportFileColumnsModel__ctor.htm"/>
    public CsvImportFileColumnsModel() { }
}
