using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket log. The view collects data from various tables.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html"/>
[Table("dbo.vAct")]
public class vAct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_ActLocaleId"/>
    public virtual int? ActLocaleId { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_ActMarkId"/>
    public virtual byte? ActMarkId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_ActOperationId"/>
    public virtual int? ActOperationId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_CreatedByPersonId"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_RelationId"/>
    public virtual int? RelationId { get; set; }
    /// <summary>Custom notifications link.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_SlaAlertId"/>
    public virtual int? SlaAlertId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_TicketChangeId"/>
    public virtual int? TicketChangeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_TicketNodeId"/>
    public virtual int? TicketNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_UserRead"/>
    public virtual bool UserRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_bNoCharge"/>
    public virtual bool bNoCharge { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_bWaitingForUser"/>
    public virtual bool? bWaitingForUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_dAct"/>
    public virtual DateTime? dAct { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_dActRemoved"/>
    public virtual DateTime? dActRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_iActId"/>
    public virtual int? iActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_liActFromPersonId"/>
    public virtual int? liActFromPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_liActHdTicketApprovalItemId"/>
    public virtual int? liActHdTicketApprovalItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_liActHdTicketId"/>
    public virtual int? liActHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_liActKindId"/>
    public virtual int? liActKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_liActToPersonId"/>
    public virtual int? liActToPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_mActFromContact"/>
    public virtual string mActFromContact { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_mActNotice"/>
    public virtual string mActNotice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_nActTravelHours"/>
    public virtual double? nActTravelHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_nActTravelKm"/>
    public virtual double? nActTravelKm { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_nActWorkHours"/>
    public virtual double? nActWorkHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sAct"/>
    public virtual string sAct { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActAutoSubmitted"/>
    public virtual string sActAutoSubmitted { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActCc"/>
    public virtual string sActCc { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFrom"/>
    public virtual string sActFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromCompany"/>
    public virtual string sActFromCompany { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromDepartment"/>
    public virtual string sActFromDepartment { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromEmail"/>
    public virtual string sActFromEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromMobile"/>
    public virtual string sActFromMobile { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromOffice"/>
    public virtual string sActFromOffice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromPhone"/>
    public virtual string sActFromPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActFromWorkPosition"/>
    public virtual string sActFromWorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActMessageId"/>
    public virtual string sActMessageId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActTo"/>
    public virtual string sActTo { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActToEmail"/>
    public virtual string sActToEmail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActXSpamLevel"/>
    public virtual string sActXSpamLevel { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vAct.html#Alvao_API_Common_Model_Database_vAct_sActXSpamStatus"/>
    public virtual string sActXSpamStatus { get; set; }
}
