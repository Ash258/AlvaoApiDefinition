using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Manufacturer.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html"/>
[Table("dbo.vPropertyKind_Manufacturer")]
public class vPropertyKind_Manufacturer {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html#Alvao_API_Common_Model_Database_vPropertyKind_Manufacturer_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html#Alvao_API_Common_Model_Database_vPropertyKind_Manufacturer_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html#Alvao_API_Common_Model_Database_vPropertyKind_Manufacturer_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html#Alvao_API_Common_Model_Database_vPropertyKind_Manufacturer_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Manufacturer.html#Alvao_API_Common_Model_Database_vPropertyKind_Manufacturer_txtValue"/>
    public virtual string txtValue { get; set; }
}
