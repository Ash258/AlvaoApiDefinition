using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Time zone list.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZone.html"/>
[Table("dbo.TimeZone")]
public class TimeZone {
    /// <summary>Localized name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZone.html#Alvao_API_Common_Model_Database_TimeZone_DisplayName"/>
    public virtual string DisplayName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZone.html#Alvao_API_Common_Model_Database_TimeZone_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <summary>Unique identifier (matches the key in the registry).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TimeZone.html#Alvao_API_Common_Model_Database_TimeZone_uid"/>
    public virtual string uid { get; set; }
}
