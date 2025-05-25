using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects -Domain components.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html"/>
[Table("dbo.vPropertyKind_PartOfDomain")]
public class vPropertyKind_PartOfDomain {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html#Alvao_API_Common_Model_Database_vPropertyKind_PartOfDomain_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html#Alvao_API_Common_Model_Database_vPropertyKind_PartOfDomain_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html#Alvao_API_Common_Model_Database_vPropertyKind_PartOfDomain_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html#Alvao_API_Common_Model_Database_vPropertyKind_PartOfDomain_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_PartOfDomain.html#Alvao_API_Common_Model_Database_vPropertyKind_PartOfDomain_txtValue"/>
    public virtual string txtValue { get; set; }
}
