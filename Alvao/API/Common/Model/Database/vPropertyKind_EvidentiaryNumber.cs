using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - registration number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html"/>
[Table("dbo.vPropertyKind_EvidentiaryNumber")]
public class vPropertyKind_EvidentiaryNumber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_EvidentiaryNumber_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_EvidentiaryNumber_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_EvidentiaryNumber_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_EvidentiaryNumber_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_EvidentiaryNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_EvidentiaryNumber_txtValue"/>
    public virtual string txtValue { get; set; }
}
