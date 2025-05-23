using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Summary SLA alerts for requester inactivity.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveRequestersSummary")]
public class vSlaAlertInactiveRequestersSummary {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_fSummarySendHour.htm"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_iHdTicketId.htm"/>
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_iPersonLocaleId.htm"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_liSlaAlertRuleId.htm"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_liToPersonId.htm"/>
    public virtual int? liToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sHdTicket.htm"/>
    public virtual string sHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sHdTicketUserEmail.htm"/>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sPerson.htm"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sPersonEmail.htm"/>
    public virtual string sPersonEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sPortalURL.htm"/>
    public virtual string sPortalURL { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sSolver.htm"/>
    public virtual string sSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary_sTag.htm"/>
    public virtual string sTag { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertInactiveRequestersSummary__ctor.htm"/>
    public vSlaAlertInactiveRequestersSummary() { }
}
