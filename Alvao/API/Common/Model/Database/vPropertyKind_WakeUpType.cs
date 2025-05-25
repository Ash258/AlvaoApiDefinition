using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Wake-up method.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html"/>
[Table("dbo.vPropertyKind_WakeUpType")]
public class vPropertyKind_WakeUpType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html#Alvao_API_Common_Model_Database_vPropertyKind_WakeUpType_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html#Alvao_API_Common_Model_Database_vPropertyKind_WakeUpType_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html#Alvao_API_Common_Model_Database_vPropertyKind_WakeUpType_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html#Alvao_API_Common_Model_Database_vPropertyKind_WakeUpType_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_WakeUpType.html#Alvao_API_Common_Model_Database_vPropertyKind_WakeUpType_txtValue"/>
    public virtual string txtValue { get; set; }
}
