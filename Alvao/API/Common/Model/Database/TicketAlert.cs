using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache for storing alerts.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlert.htm"/>
[TableAttribute("dbo.TicketAlert")]
public class TicketAlert
{
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>A parameter which is inserted into the alert text.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_Param1.htm"/>
    public virtual double? Param1 { get; set; }
    /// <summary>Alert date and time</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_Raised.htm"/>
    public virtual DateTime Raised { get; set; }
    /// <summary>Severity (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_SeverityId.htm"/>
    public virtual int SeverityId { get; set; }
    /// <summary>Alert type: 0 = ticket not being resolved, 1 = first reaction due date, 2 = resolution due date, 3 = internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_TicketAlertTypeId.htm"/>
    public virtual int TicketAlertTypeId { get; set; }
    /// <summary>Ticket (tHdTicket.Id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlert_TicketId.htm"/>
    public virtual int TicketId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketAlert__ctor.htm"/>
    public TicketAlert() { }
}
