namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html"/>
public class ClassXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_ClassId"/>
    public int? ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_ClassProperties"/>
    public List<string> ClassProperties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_DefaultObjectTemplateNodeId"/>
    public int? DefaultObjectTemplateNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_Icon"/>
    public IconXmlModel Icon { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_IsComputer"/>
    public bool IsComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_IsNew"/>
    public bool IsNew { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_Localizations"/>
    public List<LocalizationXmlModel> Localizations { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ClassXmlModel.html#Alvao_API_AM_Model_XmlExport_ClassXmlModel_NameTemplate"/>
    public string NameTemplate { get; set; }
}
