using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Enumeration of log levels
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LogLevel.htm"/>
[TableAttribute("dbo.LogLevel")]
public class LogLevel
{
    /// <summary>Record ID</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Log level name</summary>
    public virtual string Name { get; set; }

    public LogLevel() { }
}
