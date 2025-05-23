using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Enumeration of log levels</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LogLevel.htm"/>
[TableAttribute("dbo.LogLevel")]
public class LogLevel
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LogLevel_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Log level name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LogLevel_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LogLevel__ctor.htm"/>
    public LogLevel() { }
}
