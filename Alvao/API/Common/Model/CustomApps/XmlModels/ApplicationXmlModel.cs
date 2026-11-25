namespace Alvao.API.Common.Model.CustomApps.XmlModels;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html"/>
public class ApplicationXmlModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_AdvancedSettings"/>
    public SettingsXmlModel[] AdvancedSettings { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_Description"/>
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_NewApplicationId"/>
    public int NewApplicationId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_Scripts"/>
    public ScriptXmlModel[] Scripts { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_UniqueId"/>
    public Guid? UniqueId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_Version"/>
    public int Version { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.XmlModels.ApplicationXmlModel.html#Alvao_API_Common_Model_CustomApps_XmlModels_ApplicationXmlModel_id"/>
    public int id { get; set; }
}
