namespace Alvao.API.Common.Model.CustomApps.XmlModels;

/// <summary>Model root class for export/import xml applications XML.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.AlvaoApplicationXmlModel.html"/>
public class AlvaoApplicationXmlModel {
    /// <summary>Current model version. If we make an incompatible change, this number should be incremented.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.AlvaoApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_AlvaoApplicationXmlModel_ActualModelVersion"/>
    protected const string ActualModelVersion = "1";

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.AlvaoApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_AlvaoApplicationXmlModel_Applications"/>
    public List<ApplicationXmlModel> Applications { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.AlvaoApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_AlvaoApplicationXmlModel_ModelVersion"/>
    public string ModelVersion { get; set; }
}
