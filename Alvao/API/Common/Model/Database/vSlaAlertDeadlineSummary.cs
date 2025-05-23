using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Summary SLA notifications for the expiration of the ticket deadline.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary.htm"/>
[TableAttribute("dbo.vSlaAlertDeadlineSummary")]
public class vSlaAlertDeadlineSummary {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_dHdTicketDeadline.htm"/>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_iHdTicketId.htm"/>
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_iPersonLocaleId.htm"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_iSlaAlertRuleId.htm"/>
    public virtual int iSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_liToPersonId.htm"/>
    public virtual int? liToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sHdTicket.htm"/>
    public virtual string sHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sHdTicketUserEmail.htm"/>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sPerson.htm"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sPersonEmail.htm"/>
    public virtual string sPersonEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sPortalURL.htm"/>
    public virtual string sPortalURL { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sSolver.htm"/>
    public virtual string sSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary_sTag.htm"/>
    public virtual string sTag { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertDeadlineSummary__ctor.htm"/>
    public vSlaAlertDeadlineSummary() { }
}
