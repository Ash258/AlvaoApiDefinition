using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Size.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html"/>
[Table("dbo.vPropertyKind_Size")]
public class vPropertyKind_Size {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html#Alvao_API_Common_Model_Database_vPropertyKind_Size_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html#Alvao_API_Common_Model_Database_vPropertyKind_Size_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html#Alvao_API_Common_Model_Database_vPropertyKind_Size_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html#Alvao_API_Common_Model_Database_vPropertyKind_Size_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Size.html#Alvao_API_Common_Model_Database_vPropertyKind_Size_txtValue"/>
    public virtual string txtValue { get; set; }
}
