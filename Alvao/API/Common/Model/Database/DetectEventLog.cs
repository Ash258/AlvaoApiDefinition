using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected events from the Event log of computers
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DetectEventLog.htm"/>
[TableAttribute("dbo.DetectEventLog")]
public class DetectEventLog
{
    /// <summary>Detection ID</summary>
    public virtual int DetectId { get; set; }
    /// <summary>Event date and time (UTC)</summary>
    public virtual DateTime? EventDate { get; set; }
    /// <summary>Event ID in the Event log</summary>
    public virtual int? EventID { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Event text</summary>
    public virtual string Message { get; set; }

    public DetectEventLog() { }
}
