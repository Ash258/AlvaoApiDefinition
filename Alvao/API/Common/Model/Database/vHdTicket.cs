using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Values for dynamically calculated ticket items.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html"/>
[Table("dbo.vHdTicket")]
public class vHdTicket {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_IsNextActionInternalTarget"/>
    public virtual int IsNextActionInternalTarget { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_IsSlaPaused"/>
    public virtual int IsSlaPaused { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_NextActionDeadline"/>
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>The ID name of the current target of the ticket (tString.iStringId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_NextActionStringId"/>
    public virtual int? NextActionStringId { get; set; }
    /// <summary>1 = SLA may be paused while waiting for the requester or in any ticket status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_SlaPause"/>
    public virtual int SlaPause { get; set; }
    /// <summary>Total SLA pause time within a specific requirement in hours (including the currently running SLA pause).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_SlaPausedHours"/>
    public virtual double? SlaPausedHours { get; set; }
    /// <summary>Number of hours of SLA pause being in progress (due to waiting for requester or ticket status).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_SlaPausingHours"/>
    public virtual double? SlaPausingHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_nOpenTimeHours"/>
    public virtual double? nOpenTimeHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_nOpenTimeWithoutWaitingHours"/>
    public virtual double? nOpenTimeWithoutWaitingHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_nWaitedForUserHours"/>
    public virtual double nWaitedForUserHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdTicket.html#Alvao_API_Common_Model_Database_vHdTicket_nWaitingForUserHours"/>
    public virtual double? nWaitingForUserHours { get; set; }
}
