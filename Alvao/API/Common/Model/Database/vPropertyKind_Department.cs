using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Cost center.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html"/>
[Table("dbo.vPropertyKind_Department")]
public class vPropertyKind_Department {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html#Alvao_API_Common_Model_Database_vPropertyKind_Department_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html#Alvao_API_Common_Model_Database_vPropertyKind_Department_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html#Alvao_API_Common_Model_Database_vPropertyKind_Department_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html#Alvao_API_Common_Model_Database_vPropertyKind_Department_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Department.html#Alvao_API_Common_Model_Database_vPropertyKind_Department_txtValue"/>
    public virtual string txtValue { get; set; }
}
