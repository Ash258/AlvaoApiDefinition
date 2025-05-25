using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Type designation.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html"/>
[Table("dbo.vPropertyKind_TypeMark")]
public class vPropertyKind_TypeMark {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html#Alvao_API_Common_Model_Database_vPropertyKind_TypeMark_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html#Alvao_API_Common_Model_Database_vPropertyKind_TypeMark_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html#Alvao_API_Common_Model_Database_vPropertyKind_TypeMark_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html#Alvao_API_Common_Model_Database_vPropertyKind_TypeMark_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_TypeMark.html#Alvao_API_Common_Model_Database_vPropertyKind_TypeMark_txtValue"/>
    public virtual string txtValue { get; set; }
}
