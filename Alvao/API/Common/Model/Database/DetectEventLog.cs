using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected events from the Event log of computers</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html"/>
[Table("dbo.DetectEventLog")]
public class DetectEventLog {
    /// <summary>Detection ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_DetectId"/>
    public virtual int DetectId { get; set; }
    /// <summary>Event date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_EventDate"/>
    public virtual DateTime? EventDate { get; set; }
    /// <summary>Event ID in the Event log</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_EventID"/>
    public virtual int? EventID { get; set; }
    /// <summary>Event text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_Message"/>
    public virtual string Message { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_id"/>
    [Key]
    public virtual int id { get; set; }
}
