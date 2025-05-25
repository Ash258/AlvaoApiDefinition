using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Data query defined by an SQL query</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html"/>
[Table("dbo.DataQuery")]
public class DataQuery {
    /// <summary>Description</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_Description"/>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_ErrorMessage"/>
    public virtual string ErrorMessage { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_Hidden"/>
    public virtual bool Hidden { get; set; }
    /// <summary>1 = the query is enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_IsEnabled"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Query name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_Name"/>
    public virtual string Name { get; set; }
    /// <summary>SQL query</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_SqlQuery"/>
    public virtual string SqlQuery { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DataQuery.html#Alvao_API_Common_Model_Database_DataQuery_id"/>
    [Key]
    public virtual int id { get; set; }
}
