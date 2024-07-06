using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects and properties - Computer - Motherboard (type), BIOS Serial Number.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1.htm"/>
[TableAttribute("dbo.vNodePropertyMix_Computer1")]
public class vNodePropertyMix_Computer1
{
    public virtual int intNodeId3 { get; set; }
    public virtual string txtBIOSSerialNumber { get; set; }
    public virtual string txtType { get; set; }

    public vNodePropertyMix_Computer1() { }
}
