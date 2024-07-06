using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket log. The view collects data from various tables.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vAct.htm"/>
[TableAttribute("dbo.vAct")]
public class vAct
{
    public virtual int? ActLocaleId { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    public virtual byte? ActMarkId { get; set; }
    public virtual int? ActOperationId { get; set; }
    public virtual bool bNoCharge { get; set; }
    public virtual bool? bWaitingForUser { get; set; }
    public virtual int? CreatedByPersonId { get; set; }
    public virtual DateTime? dAct { get; set; }
    public virtual DateTime? dActRemoved { get; set; }
    public virtual int? iActId { get; set; }
    public virtual int? liActFromPersonId { get; set; }
    public virtual int? liActHdTicketApprovalItemId { get; set; }
    public virtual int? liActHdTicketId { get; set; }
    public virtual int? liActKindId { get; set; }
    public virtual int? liActToPersonId { get; set; }
    public virtual string mActFromContact { get; set; }
    public virtual string mActNotice { get; set; }
    public virtual double? nActTravelHours { get; set; }
    public virtual double? nActTravelKm { get; set; }
    public virtual double? nActWorkHours { get; set; }
    public virtual int? RelationId { get; set; }
    public virtual string sAct { get; set; }
    public virtual string sActAutoSubmitted { get; set; }
    public virtual string sActCc { get; set; }
    public virtual string sActFrom { get; set; }
    public virtual string sActFromCompany { get; set; }
    public virtual string sActFromDepartment { get; set; }
    public virtual string sActFromEmail { get; set; }
    public virtual string sActFromMobile { get; set; }
    public virtual string sActFromOffice { get; set; }
    public virtual string sActFromPhone { get; set; }
    public virtual string sActFromWorkPosition { get; set; }
    public virtual string sActMessageId { get; set; }
    public virtual string sActTo { get; set; }
    public virtual string sActToEmail { get; set; }
    public virtual string sActXSpamLevel { get; set; }
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>Custom notifications link.</summary>
    public virtual int? SlaAlertId { get; set; }
    public virtual int? TicketChangeId { get; set; }
    public virtual int? TicketNodeId { get; set; }
    public virtual bool UserRead { get; set; }

    public vAct() { }
}
