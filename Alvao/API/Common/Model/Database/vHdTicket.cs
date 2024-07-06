using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Values for dynamically calculated ticket items.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicket.htm"/>
[TableAttribute("dbo.vHdTicket")]
public class vHdTicket
{
    public virtual int IsNextActionInternalTarget { get; set; }
    public virtual int IsSlaPaused { get; set; }
    public virtual int liHdTicketId { get; set; }
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>The ID name of the current target of the ticket (tString.iStringId).</summary>
    public virtual int? NextActionStringId { get; set; }
    public virtual double? nOpenTimeHours { get; set; }
    public virtual double? nOpenTimeWithoutWaitingHours { get; set; }
    public virtual double nWaitedForUserHours { get; set; }
    public virtual double? nWaitingForUserHours { get; set; }
    /// <summary>1 = SLA may be paused while waiting for the requester or in any ticket status.</summary>
    public virtual int SlaPause { get; set; }
    /// <summary>Total SLA pause time within a specific requirement in hours (including the currently running SLA pause).</summary>
    public virtual double? SlaPausedHours { get; set; }
    /// <summary>Number of hours of SLA pause being in progress (due to waiting for requester or ticket status).</summary>
    public virtual double? SlaPausingHours { get; set; }

    public vHdTicket() { }
}
