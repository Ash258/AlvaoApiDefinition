namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportRootXmlModel.html"/>
public class ExportRootXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportRootXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportRootXmlModel_Configuration"/>
    public AlvaoExportConfigXmlModel Configuration { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ExportRootXmlModel.html#Alvao_API_AM_Model_XmlExport_ExportRootXmlModel_Data"/>
    public ExportDataXmlModel Data { get; set; }
}
