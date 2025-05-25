using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Purchase date.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html"/>
[Table("dbo.vPropertyKind_Purchased")]
public class vPropertyKind_Purchased {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html#Alvao_API_Common_Model_Database_vPropertyKind_Purchased_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html#Alvao_API_Common_Model_Database_vPropertyKind_Purchased_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html#Alvao_API_Common_Model_Database_vPropertyKind_Purchased_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html#Alvao_API_Common_Model_Database_vPropertyKind_Purchased_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Purchased.html#Alvao_API_Common_Model_Database_vPropertyKind_Purchased_txtValue"/>
    public virtual DateTime? txtValue { get; set; }
}
