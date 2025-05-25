using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Processor ID.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html"/>
[Table("dbo.vPropertyKind_ProcessorId")]
public class vPropertyKind_ProcessorId {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html#Alvao_API_Common_Model_Database_vPropertyKind_ProcessorId_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html#Alvao_API_Common_Model_Database_vPropertyKind_ProcessorId_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html#Alvao_API_Common_Model_Database_vPropertyKind_ProcessorId_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html#Alvao_API_Common_Model_Database_vPropertyKind_ProcessorId_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ProcessorId.html#Alvao_API_Common_Model_Database_vPropertyKind_ProcessorId_txtValue"/>
    public virtual string txtValue { get; set; }
}
