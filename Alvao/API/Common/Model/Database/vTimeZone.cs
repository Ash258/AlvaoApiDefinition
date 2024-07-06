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
    public virtual int Bias { get; set; }
    /// <summary>Localized name.</summary>
    public virtual string DisplayName { get; set; }
    /// <summary>From date.</summary>
    public virtual DateTime? FromDate { get; set; }
    /// <summary>Record ID.</summary>
    public virtual int id { get; set; }
    /// <summary>Until.</summary>
    public virtual DateTime? ToDate { get; set; }
    /// <summary>Unique identifier (matches the key in the registry).</summary>
    public virtual string uid { get; set; }

    public vTimeZone() { }
}
