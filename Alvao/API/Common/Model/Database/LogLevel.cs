using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Enumeration of log levels</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LogLevel.html"/>
[Table("dbo.LogLevel")]
public class LogLevel {
    /// <summary>Log level name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LogLevel.html#Alvao_API_Common_Model_Database_LogLevel_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LogLevel.html#Alvao_API_Common_Model_Database_LogLevel_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
