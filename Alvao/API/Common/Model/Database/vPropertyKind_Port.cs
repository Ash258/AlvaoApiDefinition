using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Port.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html"/>
[Table("dbo.vPropertyKind_Port")]
public class vPropertyKind_Port {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html#Alvao_API_Common_Model_Database_vPropertyKind_Port_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html#Alvao_API_Common_Model_Database_vPropertyKind_Port_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html#Alvao_API_Common_Model_Database_vPropertyKind_Port_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html#Alvao_API_Common_Model_Database_vPropertyKind_Port_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Port.html#Alvao_API_Common_Model_Database_vPropertyKind_Port_txtValue"/>
    public virtual string txtValue { get; set; }
}
