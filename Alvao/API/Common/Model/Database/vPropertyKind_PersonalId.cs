using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Personal number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html"/>
[Table("dbo.vPropertyKind_PersonalId")]
public class vPropertyKind_PersonalId {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html#Alvao_API_Common_Model_Database_vPropertyKind_PersonalId_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html#Alvao_API_Common_Model_Database_vPropertyKind_PersonalId_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html#Alvao_API_Common_Model_Database_vPropertyKind_PersonalId_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html#Alvao_API_Common_Model_Database_vPropertyKind_PersonalId_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PersonalId.html#Alvao_API_Common_Model_Database_vPropertyKind_PersonalId_txtValue"/>
    public virtual string txtValue { get; set; }
}
