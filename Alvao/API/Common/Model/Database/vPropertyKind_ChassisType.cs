using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Type of rack.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html"/>
[Table("dbo.vPropertyKind_ChassisType")]
public class vPropertyKind_ChassisType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html#Alvao_API_Common_Model_Database_vPropertyKind_ChassisType_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html#Alvao_API_Common_Model_Database_vPropertyKind_ChassisType_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html#Alvao_API_Common_Model_Database_vPropertyKind_ChassisType_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html#Alvao_API_Common_Model_Database_vPropertyKind_ChassisType_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_ChassisType.html#Alvao_API_Common_Model_Database_vPropertyKind_ChassisType_txtValue"/>
    public virtual string txtValue { get; set; }
}
