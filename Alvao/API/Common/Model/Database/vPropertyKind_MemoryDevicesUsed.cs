using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Occupied sockets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html"/>
[Table("dbo.vPropertyKind_MemoryDevicesUsed")]
public class vPropertyKind_MemoryDevicesUsed {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevicesUsed_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevicesUsed_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevicesUsed_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevicesUsed_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevicesUsed.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevicesUsed_txtValue"/>
    public virtual string txtValue { get; set; }
}
