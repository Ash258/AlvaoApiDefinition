using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Model.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html"/>
[Table("dbo.vPropertyKind_Model")]
public class vPropertyKind_Model {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html#Alvao_API_Common_Model_Database_vPropertyKind_Model_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html#Alvao_API_Common_Model_Database_vPropertyKind_Model_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html#Alvao_API_Common_Model_Database_vPropertyKind_Model_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html#Alvao_API_Common_Model_Database_vPropertyKind_Model_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Model.html#Alvao_API_Common_Model_Database_vPropertyKind_Model_txtValue"/>
    public virtual string txtValue { get; set; }
}
