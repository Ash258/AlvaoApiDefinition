using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - DNS domain.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html"/>
[Table("dbo.vPropertyKind_Domain")]
public class vPropertyKind_Domain {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html#Alvao_API_Common_Model_Database_vPropertyKind_Domain_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html#Alvao_API_Common_Model_Database_vPropertyKind_Domain_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html#Alvao_API_Common_Model_Database_vPropertyKind_Domain_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html#Alvao_API_Common_Model_Database_vPropertyKind_Domain_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Domain.html#Alvao_API_Common_Model_Database_vPropertyKind_Domain_txtValue"/>
    public virtual string txtValue { get; set; }
}
