using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - the right to &quot;Move&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Move.html"/>
[Table("dbo.vPersonNodeRight_Move")]
public class vPersonNodeRight_Move {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Move.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Move_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Move.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Move_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
