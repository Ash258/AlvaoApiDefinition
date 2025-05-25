using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - RAM size.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html"/>
[Table("dbo.vPropertyKind_VideoRAM")]
public class vPropertyKind_VideoRAM {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html#Alvao_API_Common_Model_Database_vPropertyKind_VideoRAM_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html#Alvao_API_Common_Model_Database_vPropertyKind_VideoRAM_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html#Alvao_API_Common_Model_Database_vPropertyKind_VideoRAM_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html#Alvao_API_Common_Model_Database_vPropertyKind_VideoRAM_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_VideoRAM.html#Alvao_API_Common_Model_Database_vPropertyKind_VideoRAM_txtValue"/>
    public virtual string txtValue { get; set; }
}
