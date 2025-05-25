using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Computer - MAC address.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer2.html"/>
[Table("dbo.vNodePropertyMix_Computer2")]
public class vNodePropertyMix_Computer2 {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer2.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2_intNodeId4"/>
    public virtual int intNodeId4 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer2.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Computer2_txtMACAddress"/>
    public virtual string txtMACAddress { get; set; }
}
