using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket log. The view collects data from various tables.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAct.htm"/>
[TableAttribute("dbo.vAct")]
public class vAct
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_ActLocaleId.htm"/>
    public virtual int? ActLocaleId { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_ActMarkId.htm"/>
    public virtual byte? ActMarkId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_ActOperationId.htm"/>
    public virtual int? ActOperationId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_bNoCharge.htm"/>
    public virtual bool bNoCharge { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_bWaitingForUser.htm"/>
    public virtual bool? bWaitingForUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_CreatedByPersonId.htm"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_dAct.htm"/>
    public virtual DateTime? dAct { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_dActRemoved.htm"/>
    public virtual DateTime? dActRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_iActId.htm"/>
    public virtual int? iActId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_liActFromPersonId.htm"/>
    public virtual int? liActFromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_liActHdTicketApprovalItemId.htm"/>
    public virtual int? liActHdTicketApprovalItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_liActHdTicketId.htm"/>
    public virtual int? liActHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_liActKindId.htm"/>
    public virtual int? liActKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_liActToPersonId.htm"/>
    public virtual int? liActToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_mActFromContact.htm"/>
    public virtual string mActFromContact { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_mActNotice.htm"/>
    public virtual string mActNotice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_nActTravelHours.htm"/>
    public virtual double? nActTravelHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_nActTravelKm.htm"/>
    public virtual double? nActTravelKm { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_nActWorkHours.htm"/>
    public virtual double? nActWorkHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_RelationId.htm"/>
    public virtual int? RelationId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sAct.htm"/>
    public virtual string sAct { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActAutoSubmitted.htm"/>
    public virtual string sActAutoSubmitted { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActCc.htm"/>
    public virtual string sActCc { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFrom.htm"/>
    public virtual string sActFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromCompany.htm"/>
    public virtual string sActFromCompany { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromDepartment.htm"/>
    public virtual string sActFromDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromEmail.htm"/>
    public virtual string sActFromEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromMobile.htm"/>
    public virtual string sActFromMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromOffice.htm"/>
    public virtual string sActFromOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromPhone.htm"/>
    public virtual string sActFromPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActFromWorkPosition.htm"/>
    public virtual string sActFromWorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActMessageId.htm"/>
    public virtual string sActMessageId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActTo.htm"/>
    public virtual string sActTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActToEmail.htm"/>
    public virtual string sActToEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActXSpamLevel.htm"/>
    public virtual string sActXSpamLevel { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_sActXSpamStatus.htm"/>
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>Custom notifications link.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_SlaAlertId.htm"/>
    public virtual int? SlaAlertId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_TicketChangeId.htm"/>
    public virtual int? TicketChangeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_TicketNodeId.htm"/>
    public virtual int? TicketNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vAct_UserRead.htm"/>
    public virtual bool UserRead { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vAct__ctor.htm"/>
    public vAct() { }
}
