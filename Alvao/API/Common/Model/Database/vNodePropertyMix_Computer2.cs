using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Computer - MAC address.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Computer2")]
public class vNodePropertyMix_Computer2
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2_intNodeId4.htm"/>
    public virtual int intNodeId4 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2_txtMACAddress.htm"/>
    public virtual string txtMACAddress { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2__ctor.htm"/>
    public vNodePropertyMix_Computer2() { }
}
