using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected events from the Event log of computers</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html"/>
[Table("dbo.DetectEventLog")]
public class DetectEventLog {
    /// <summary>Detection ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_DetectId"/>
    /// <remarks>Column <c>DetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    public virtual int DetectId { get; set; }
    /// <summary>Event date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_EventDate"/>
    /// <remarks>Column <c>EventDate</c>: datetime, null.</remarks>
    public virtual DateTime? EventDate { get; set; }
    /// <summary>Event ID in the Event log</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_EventID"/>
    /// <remarks>Column <c>EventID</c>: int, null.</remarks>
    public virtual int? EventID { get; set; }
    /// <summary>Event text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_Message"/>
    /// <remarks>Column <c>Message</c>: nvarchar(max), null.</remarks>
    public virtual string Message { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DetectEventLog.html#Alvao_API_Common_Model_Database_DetectEventLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
