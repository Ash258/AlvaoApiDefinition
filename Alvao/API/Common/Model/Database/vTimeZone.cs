using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Overview of time zones and shifts compared to UTC.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html"/>
[Table("dbo.vTimeZone")]
public class vTimeZone {
    /// <summary>Shift compared to UTC in minutes</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_Bias"/>
    public virtual int Bias { get; set; }
    /// <summary>Localized name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_DisplayName"/>
    public virtual string DisplayName { get; set; }
    /// <summary>From date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_FromDate"/>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Until.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_ToDate"/>
    public virtual DateTime? ToDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_id"/>
    public virtual int id { get; set; }
    /// <summary>Unique identifier (matches the key in the registry).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTimeZone.html#Alvao_API_Common_Model_Database_vTimeZone_uid"/>
    public virtual string uid { get; set; }
}
