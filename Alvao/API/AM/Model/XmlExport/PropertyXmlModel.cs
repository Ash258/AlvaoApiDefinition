namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html"/>
public class PropertyXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_Category"/>
    public string Category { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_CleanByCopy"/>
    public bool CleanByCopy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_ColumnName"/>
    public string ColumnName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_KindDataTypeId"/>
    public int KindDataTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_Localizations"/>
    public List<LocalizationXmlModel> Localizations { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_OthersValueListPropertyName"/>
    public string OthersValueListPropertyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_Precision"/>
    public int? Precision { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_RequiredForAllClasses"/>
    public bool RequiredForAllClasses { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_bSelectOnly"/>
    public bool bSelectOnly { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_bolGlobalScope"/>
    public bool bolGlobalScope { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_bolUnique"/>
    public bool bolUnique { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_intFlags"/>
    public int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_intKindId"/>
    public int intKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_intOrder"/>
    public int? intOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_lintValueKindId"/>
    public int? lintValueKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyXmlModel_txtName"/>
    public string txtName { get; set; }
}
