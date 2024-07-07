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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectEventLog_DetectId.htm"/>
    public virtual int DetectId { get; set; }
    /// <summary>Event date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectEventLog_EventDate.htm"/>
    public virtual DateTime? EventDate { get; set; }
    /// <summary>Event ID in the Event log</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectEventLog_EventID.htm"/>
    public virtual int? EventID { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectEventLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Event text</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DetectEventLog_Message.htm"/>
    public virtual string Message { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DetectEventLog__ctor.htm"/>
    public DetectEventLog() { }
}
