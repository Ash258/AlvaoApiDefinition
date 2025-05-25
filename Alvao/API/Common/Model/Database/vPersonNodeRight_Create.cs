using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the objects tree - the right to &quot;Create any objects&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Create.html"/>
[Table("dbo.vPersonNodeRight_Create")]
public class vPersonNodeRight_Create {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Create.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Create_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Create.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Create_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
