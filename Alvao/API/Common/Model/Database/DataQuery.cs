using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Data query defined by an SQL query</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DataQuery.htm"/>
[TableAttribute("dbo.DataQuery")]
public class DataQuery
{
    /// <summary>Description</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>Error message at the last SQL script run.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_ErrorMessage.htm"/>
    public virtual string ErrorMessage { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_Hidden.htm"/>
    public virtual bool Hidden { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = the query is enabled, 0 = disabled.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_IsEnabled.htm"/>
    public virtual bool IsEnabled { get; set; }
    /// <summary>Query name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>SQL query</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DataQuery_SqlQuery.htm"/>
    public virtual string SqlQuery { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DataQuery__ctor.htm"/>
    public DataQuery() { }
}
