namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyValueListXmlModel.html"/>
public class PropertyValueListXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyValueListXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyValueListXmlModel_PropertyName"/>
    public string PropertyName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.PropertyValueListXmlModel.html#Alvao_API_AM_Model_XmlExport_PropertyValueListXmlModel_Values"/>
    public List<PropertyValueXmlModel> Values { get; set; }
}
