using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - the right to &quot;Change&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Write.html"/>
[Table("dbo.vPersonNodeRight_Write")]
public class vPersonNodeRight_Write {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Write.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Write_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Write.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Write_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
