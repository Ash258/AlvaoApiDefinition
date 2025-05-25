using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Interface.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html"/>
[Table("dbo.vPropertyKind_Interface")]
public class vPropertyKind_Interface {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html#Alvao_API_Common_Model_Database_vPropertyKind_Interface_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html#Alvao_API_Common_Model_Database_vPropertyKind_Interface_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html#Alvao_API_Common_Model_Database_vPropertyKind_Interface_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html#Alvao_API_Common_Model_Database_vPropertyKind_Interface_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Interface.html#Alvao_API_Common_Model_Database_vPropertyKind_Interface_txtValue"/>
    public virtual string txtValue { get; set; }
}
