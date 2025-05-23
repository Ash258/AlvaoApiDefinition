using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Values for dynamically calculated ticket items.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdTicket.htm"/>
[TableAttribute("dbo.vHdTicket")]
public class vHdTicket
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_IsNextActionInternalTarget.htm"/>
    public virtual int IsNextActionInternalTarget { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_IsSlaPaused.htm"/>
    public virtual int IsSlaPaused { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_liHdTicketId.htm"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_NextActionDeadline.htm"/>
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>The ID name of the current target of the ticket (tString.iStringId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_NextActionStringId.htm"/>
    public virtual int? NextActionStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_nOpenTimeHours.htm"/>
    public virtual double? nOpenTimeHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_nOpenTimeWithoutWaitingHours.htm"/>
    public virtual double? nOpenTimeWithoutWaitingHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_nWaitedForUserHours.htm"/>
    public virtual double nWaitedForUserHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_nWaitingForUserHours.htm"/>
    public virtual double? nWaitingForUserHours { get; set; }
    /// <summary>1 = SLA may be paused while waiting for the requester or in any ticket status.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_SlaPause.htm"/>
    public virtual int SlaPause { get; set; }
    /// <summary>Total SLA pause time within a specific requirement in hours (including the currently running SLA pause).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_SlaPausedHours.htm"/>
    public virtual double? SlaPausedHours { get; set; }
    /// <summary>Number of hours of SLA pause being in progress (due to waiting for requester or ticket status).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdTicket_SlaPausingHours.htm"/>
    public virtual double? SlaPausingHours { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdTicket__ctor.htm"/>
    public vHdTicket() { }
}
