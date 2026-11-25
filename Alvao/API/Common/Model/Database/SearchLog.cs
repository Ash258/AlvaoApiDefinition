using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Log of searched queries</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SearchLog.html"/>
[Table("dbo.SearchLog")]
public class SearchLog {
    /// <summary>User ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SearchLog.html#Alvao_API_Common_Model_Database_SearchLog_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>Date and time of search</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SearchLog.html#Alvao_API_Common_Model_Database_SearchLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>Query</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SearchLog.html#Alvao_API_Common_Model_Database_SearchLog__Query"/>
    public virtual string _Query { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SearchLog.html#Alvao_API_Common_Model_Database_SearchLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
