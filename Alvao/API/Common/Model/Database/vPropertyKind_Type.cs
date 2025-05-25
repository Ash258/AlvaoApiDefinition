using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Type.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html"/>
[Table("dbo.vPropertyKind_Type")]
public class vPropertyKind_Type {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html#Alvao_API_Common_Model_Database_vPropertyKind_Type_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html#Alvao_API_Common_Model_Database_vPropertyKind_Type_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html#Alvao_API_Common_Model_Database_vPropertyKind_Type_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html#Alvao_API_Common_Model_Database_vPropertyKind_Type_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Type.html#Alvao_API_Common_Model_Database_vPropertyKind_Type_txtValue"/>
    public virtual string txtValue { get; set; }
}
