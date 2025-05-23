using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Type Designation, Serial Number, Manufacturer, Registration Number, Name.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Public.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Public")]
public class vNodePropertyMix_Public {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_intNodeId1.htm"/>
    public virtual int intNodeId1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtEvidentiaryNumber.htm"/>
    public virtual string txtEvidentiaryNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtManufacturer.htm"/>
    public virtual string txtManufacturer { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtProp_Name.htm"/>
    public virtual string txtProp_Name { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtSerialNumber.htm"/>
    public virtual string txtSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Public_txtTypeMark.htm"/>
    public virtual string txtTypeMark { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodePropertyMix_Public__ctor.htm"/>
    public vNodePropertyMix_Public() { }
}
