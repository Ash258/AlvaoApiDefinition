namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.AlvaoExportConfigXmlModel.html"/>
public class AlvaoExportConfigXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.AlvaoExportConfigXmlModel.html#Alvao_API_AM_Model_XmlExport_AlvaoExportConfigXmlModel_ActualModelVersion"/>
    public const int ActualModelVersion = 1;

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.AlvaoExportConfigXmlModel.html#Alvao_API_AM_Model_XmlExport_AlvaoExportConfigXmlModel_DbLocaleId"/>
    public int DbLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.AlvaoExportConfigXmlModel.html#Alvao_API_AM_Model_XmlExport_AlvaoExportConfigXmlModel_ModelVersion"/>
    public int ModelVersion { get; set; }
}
