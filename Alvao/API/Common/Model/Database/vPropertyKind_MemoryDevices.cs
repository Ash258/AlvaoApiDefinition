using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Sockets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html"/>
[Table("dbo.vPropertyKind_MemoryDevices")]
public class vPropertyKind_MemoryDevices {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevices_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevices_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevices_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevices_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_MemoryDevices.html#Alvao_API_Common_Model_Database_vPropertyKind_MemoryDevices_txtValue"/>
    public virtual string txtValue { get; set; }
}
