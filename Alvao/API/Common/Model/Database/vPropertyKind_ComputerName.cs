using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Name in the network.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html"/>
[Table("dbo.vPropertyKind_ComputerName")]
public class vPropertyKind_ComputerName {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerName_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerName_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerName_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerName_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ComputerName.html#Alvao_API_Common_Model_Database_vPropertyKind_ComputerName_txtValue"/>
    public virtual string txtValue { get; set; }
}
