using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Serial number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html"/>
[Table("dbo.vPropertyKind_SerialNumber")]
public class vPropertyKind_SerialNumber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_SerialNumber_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_SerialNumber_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_SerialNumber_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_SerialNumber_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_SerialNumber.html#Alvao_API_Common_Model_Database_vPropertyKind_SerialNumber_txtValue"/>
    public virtual string txtValue { get; set; }
}
