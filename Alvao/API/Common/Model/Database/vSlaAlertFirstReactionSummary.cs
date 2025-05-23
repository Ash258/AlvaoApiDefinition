using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Summary SLA notifications for the ticket first responses.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary.htm"/>
[TableAttribute("dbo.vSlaAlertFirstReactionSummary")]
public class vSlaAlertFirstReactionSummary {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_iHdTicketId.htm"/>
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_iPersonLocaleId.htm"/>
    public virtual int? iPersonLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_iSlaAlertRuleId.htm"/>
    public virtual int iSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_liToPersonId.htm"/>
    public virtual int? liToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_NextActionDeadline.htm"/>
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sHdSectionEmail.htm"/>
    public virtual string sHdSectionEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sHdTicket.htm"/>
    public virtual string sHdTicket { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sHdTicketUserEmail.htm"/>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sPerson.htm"/>
    public virtual string sPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sPersonEmail.htm"/>
    public virtual string sPersonEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sPortalURL.htm"/>
    public virtual string sPortalURL { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sSolver.htm"/>
    public virtual string sSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary_sTag.htm"/>
    public virtual string sTag { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSlaAlertFirstReactionSummary__ctor.htm"/>
    public vSlaAlertFirstReactionSummary() { }
}
