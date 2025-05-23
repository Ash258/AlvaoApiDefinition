using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Time zone list.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TimeZone.htm"/>
[TableAttribute("dbo.TimeZone")]
public class TimeZone {
    /// <summary>Localized name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TimeZone_DisplayName.htm"/>
    public virtual string DisplayName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TimeZone_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Unique identifier (matches the key in the registry).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TimeZone_uid.htm"/>
    public virtual string uid { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TimeZone__ctor.htm"/>
    public TimeZone() { }
}
