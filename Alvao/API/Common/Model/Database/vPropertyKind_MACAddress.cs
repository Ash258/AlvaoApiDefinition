using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - MAC address.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html"/>
[Table("dbo.vPropertyKind_MACAddress")]
public class vPropertyKind_MACAddress {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_MACAddress_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_MACAddress_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_MACAddress_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_MACAddress_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MACAddress.html#Alvao_API_Common_Model_Database_vPropertyKind_MACAddress_txtValue"/>
    public virtual string txtValue { get; set; }
}
