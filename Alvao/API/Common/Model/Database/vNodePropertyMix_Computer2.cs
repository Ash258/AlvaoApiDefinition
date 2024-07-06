using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects and properties - Computer - MAC address.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Computer2")]
public class vNodePropertyMix_Computer2
{
    public virtual int intNodeId4 { get; set; }
    public virtual string txtMACAddress { get; set; }

    public vNodePropertyMix_Computer2() { }
}
