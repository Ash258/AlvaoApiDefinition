using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Data query defined by an SQL query
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DataQuery.htm"/>
[TableAttribute("dbo.DataQuery")]
public class DataQuery
{
    /// <summary>Description</summary>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    public virtual string ErrorMessage { get; set; }
    public virtual bool Hidden { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = the query is enabled, 0 = disabled.</summary>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Query name</summary>
    public virtual string Name { get; set; }
    /// <summary>SQL query</summary>
    public virtual string SqlQuery { get; set; }

    public DataQuery() { }
}
