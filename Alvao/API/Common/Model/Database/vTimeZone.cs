using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Overview of time zones and shifts compared to UTC.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTimeZone.htm"/>
[TableAttribute("dbo.vTimeZone")]
public class vTimeZone
{
    /// <summary>Shift compared to UTC in minutes</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_Bias.htm"/>
    public virtual int Bias { get; set; }
    /// <summary>Localized name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_DisplayName.htm"/>
    public virtual string DisplayName { get; set; }
    /// <summary>From date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_FromDate.htm"/>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_id.htm"/>
    public virtual int id { get; set; }
    /// <summary>Until.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_ToDate.htm"/>
    public virtual DateTime? ToDate { get; set; }
    /// <summary>Unique identifier (matches the key in the registry).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTimeZone_uid.htm"/>
    public virtual string uid { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vTimeZone__ctor.htm"/>
    public vTimeZone() { }
}
