using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache for storing alerts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html"/>
[Table("dbo.TicketAlert")]
public class TicketAlert {
    /// <summary>A parameter which is inserted into the alert text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_Param1"/>
    /// <remarks>Column <c>Param1</c>: float, null.</remarks>
    public virtual double? Param1 { get; set; }
    /// <summary>Alert date and time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_Raised"/>
    /// <remarks>Column <c>Raised</c>: datetime, not null.</remarks>
    public virtual DateTime Raised { get; set; }
    /// <summary>Severity (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_SeverityId"/>
    /// <remarks>Column <c>SeverityId</c>: int, not null. References <see cref="TicketAlertSeverity"/>.</remarks>
    public virtual int SeverityId { get; set; }
    /// <summary>
    /// Alert type: 0 = ticket not being resolved, 1 = first reaction due date, 2 = resolution due date, 3 = internal
    /// target date.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_TicketAlertTypeId"/>
    /// <remarks>Column <c>TicketAlertTypeId</c>: int, not null. References <see cref="TicketAlertType"/>.</remarks>
    public virtual int TicketAlertTypeId { get; set; }
    /// <summary>Ticket (tHdTicket.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_TicketId"/>
    /// <remarks>Column <c>TicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int TicketId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlert.html#Alvao_API_Common_Model_Database_TicketAlert_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
