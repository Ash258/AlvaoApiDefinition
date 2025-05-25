using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - the right to &quot;Read&quot;.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Read.html"/>
[Table("dbo.vPersonNodeRight_Read")]
public class vPersonNodeRight_Read {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Read.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Read_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight_Read.html#Alvao_API_Common_Model_Database_vPersonNodeRight_Read_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
