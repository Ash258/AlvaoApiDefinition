using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - the right to &quot;Remove&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Delete.html"/>
[Table("dbo.vPersonNodeRight_Delete")]
public class vPersonNodeRight_Delete {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Delete.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Delete_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Delete.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Delete_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
