namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportDataXmlModel.html"/>
public class ExportDataXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportDataXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportDataXmlModel_Classes"/>
    public List<ClassXmlModel> Classes { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportDataXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportDataXmlModel_Objects"/>
    public List<ObjectXmlModel> Objects { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportDataXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportDataXmlModel_Properties"/>
    public List<PropertyXmlModel> Properties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportDataXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportDataXmlModel_PropertyValueLists"/>
    public List<PropertyValueListXmlModel> PropertyValueLists { get; set; }
}
