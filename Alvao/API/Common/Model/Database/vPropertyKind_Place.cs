using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Properties of objects - Location.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html"/>
[Table("dbo.vPropertyKind_Place")]
public class vPropertyKind_Place {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html#Alvao_API_Common_Model_Database_vPropertyKind_Place_bolInheritable"/>
    public virtual int bolInheritable { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html#Alvao_API_Common_Model_Database_vPropertyKind_Place_lintKindId"/>
    public virtual int lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html#Alvao_API_Common_Model_Database_vPropertyKind_Place_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html#Alvao_API_Common_Model_Database_vPropertyKind_Place_txtKind"/>
    public virtual string txtKind { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPropertyKind_Place.html#Alvao_API_Common_Model_Database_vPropertyKind_Place_txtValue"/>
    public virtual string txtValue { get; set; }
}
