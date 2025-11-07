namespace Alvao.API.AM.Model.XmlExport;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ValuatedPropertyXmlModel.html"/>
public class ValuatedPropertyXmlModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ValuatedPropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_ValuatedPropertyXmlModel_IsInheritable"/>
    public bool IsInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ValuatedPropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_ValuatedPropertyXmlModel_IsMandatory"/>
    public bool IsMandatory { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ValuatedPropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_ValuatedPropertyXmlModel_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.XmlExport.ValuatedPropertyXmlModel.html#Alvao_API_AM_Model_XmlExport_ValuatedPropertyXmlModel_Value"/>
    public PropertyValueXmlModel Value { get; set; }
}
