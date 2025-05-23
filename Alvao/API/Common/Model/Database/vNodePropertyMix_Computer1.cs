using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Computer - Motherboard (type), BIOS Serial Number.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Computer1")]
public class vNodePropertyMix_Computer1
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_intNodeId3.htm"/>
    public virtual int intNodeId3 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_txtBIOSSerialNumber.htm"/>
    public virtual string txtBIOSSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_txtType.htm"/>
    public virtual string txtType { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1__ctor.htm"/>
    public vNodePropertyMix_Computer1() { }
}
