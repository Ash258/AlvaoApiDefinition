using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects and properties - Computer - Motherboard (type), BIOS Serial Number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer1.html"/>
[Table("dbo.vNodePropertyMix_Computer1")]
public class vNodePropertyMix_Computer1 {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer1.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_intNodeId3"/>
    public virtual int intNodeId3 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer1.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_txtBIOSSerialNumber"/>
    public virtual string txtBIOSSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodePropertyMix_Computer1.html#Alvao_API_Common_Model_Database_vNodePropertyMix_Computer1_txtType"/>
    public virtual string txtType { get; set; }
}
