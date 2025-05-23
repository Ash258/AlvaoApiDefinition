using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Summary SLA alerts for approver inactivity.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary.htm"/>
[TableAttribute("dbo.vSlaAlertInactiveApproversSummary")]
public class vSlaAlertInactiveApproversSummary {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_fSummarySendHour.htm"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_iHdTicketId.htm"/>
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_iPersonLocaleId.htm"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_liSlaAlertRuleId.htm"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_liToPersonId.htm"/>
    public virtual int? liToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sHdTicket.htm"/>
    public virtual string sHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sHdTicketUserEmail.htm"/>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sPerson.htm"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sPersonEmail.htm"/>
    public virtual string sPersonEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sPortalURL.htm"/>
    public virtual string sPortalURL { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sSolver.htm"/>
    public virtual string sSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary_sTag.htm"/>
    public virtual string sTag { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertInactiveApproversSummary__ctor.htm"/>
    public vSlaAlertInactiveApproversSummary() { }
}
