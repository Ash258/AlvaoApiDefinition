using System.Text;

namespace Alvao.API.AM.Model.CsvImport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html"/>
public class ImportCsvProgress {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_CheckFinished"/>
    public bool CheckFinished { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_CreatedAmount"/>
    public int CreatedAmount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_CreatedObjectId"/>
    public int CreatedObjectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_Error"/>
    public bool Error { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_ImportFinished"/>
    public bool ImportFinished { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_OutputBuffer"/>
    public StringBuilder OutputBuffer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_Percentage"/>
    public int Percentage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_Preview"/>
    public List<ObjectPreview> Preview { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_TextWriter"/>
    public IFormattedTextWriter TextWriter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ImportCsvProgress.html#Alvao_API_AM_Model_CsvImport_ImportCsvProgress_UpdatedAmount"/>
    public int UpdatedAmount { get; set; }
}
