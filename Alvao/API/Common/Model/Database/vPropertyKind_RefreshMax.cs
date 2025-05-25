using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Maximum refresh.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html"/>
[Table("dbo.vPropertyKind_RefreshMax")]
public class vPropertyKind_RefreshMax {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html#Alvao_API_Common_Model_Database_vPropertyKind_RefreshMax_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html#Alvao_API_Common_Model_Database_vPropertyKind_RefreshMax_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html#Alvao_API_Common_Model_Database_vPropertyKind_RefreshMax_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html#Alvao_API_Common_Model_Database_vPropertyKind_RefreshMax_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_RefreshMax.html#Alvao_API_Common_Model_Database_vPropertyKind_RefreshMax_txtValue"/>
    public virtual string txtValue { get; set; }
}
