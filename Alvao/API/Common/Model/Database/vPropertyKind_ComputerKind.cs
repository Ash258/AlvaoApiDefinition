using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Type of computer.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html"/>
[Table("dbo.vPropertyKind_ComputerKind")]
public class vPropertyKind_ComputerKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerKind_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerKind_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerKind_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerKind_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerKind.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerKind_txtValue"/>
    public virtual string txtValue { get; set; }
}
