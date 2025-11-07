using Newtonsoft.Json;

namespace Alvao.API.AM.Model.CsvImport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html"/>
public class ObjectPreview {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_ClassId"/>
    public int ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_ClassName"/>
    public string ClassName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_ExistingNodeId"/>
    [JsonIgnore]
    public int ExistingNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_IsNew"/>
    public bool IsNew { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_IsProblematic"/>
    [JsonIgnore]
    public bool IsProblematic { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_Properties"/>
    public List<Property> Properties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_RowPositionInDataTable"/>
    [JsonIgnore]
    public int RowPositionInDataTable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.CsvImport.ObjectPreview.html#Alvao_API_AM_Model_CsvImport_ObjectPreview_ShouldGenerateValues"/>
    [JsonIgnore]
    public bool ShouldGenerateValues { get; set; }
}
