using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Log of searched queries
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SearchLog.htm"/>
[TableAttribute("dbo.SearchLog")]
public class SearchLog
{
    /// <summary>Query</summary>
    public virtual string _Query { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>User ID</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>Date and time of search</summary>
    public virtual DateTime TimeStamp { get; set; }

    public SearchLog() { }
}
