namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html"/>
public class ObjectXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_ChildObjects"/>
    public List<ObjectXmlModel> ChildObjects { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_ClassId"/>
    public int ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_ClassName"/>
    public string ClassName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_FullName"/>
    public string FullName { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_IsActive"/>
    public bool? IsActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_IsDefault"/>
    public bool IsDefault { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_IsDiscarded"/>
    public bool IsDiscarded { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_IsHidden"/>
    public bool IsHidden { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_IsTemplate"/>
    public bool IsTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_NotNullParentId"/>
    public int NotNullParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_ParentName"/>
    public string ParentName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_Properties"/>
    public List<ValuatedPropertyXmlModel> Properties { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_TemplateGuid"/>
    public Guid TemplateGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_bSwAllAllowed"/>
    public bool bSwAllAllowed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_intNodeId"/>
    public int intNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_intState"/>
    public int? intState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_lintParentId"/>
    public int? lintParentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ObjectXmlModel.html#Alvao_API_AM_Model_XmlExport_ObjectXmlModel_txtName"/>
    public string txtName { get; set; }
}
