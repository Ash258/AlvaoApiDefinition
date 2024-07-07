using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The record in communication or ticket log.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAct.htm"/>
[TableAttribute("dbo.tAct")]
public class tAct
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_ActHtml.htm"/>
    public virtual string ActHtml { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_ActMarkId.htm"/>
    public virtual byte? ActMarkId { get; set; }
    /// <summary>Process kind ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_ActOperationId.htm"/>
    public virtual int? ActOperationId { get; set; }
    /// <summary>If the value is 1, paid</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_bNoCharge.htm"/>
    public virtual bool bNoCharge { get; set; }
    /// <summary>1 - Marks the start of waiting for the requisitioner from0 - Marks the end of waiting for the requisitionerNULL - does not change the status of waiting for the requisitioner</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_bWaitingForUser.htm"/>
    public virtual bool? bWaitingForUser { get; set; }
    /// <summary>User ID of the event creator</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_CreatedByPersonId.htm"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>Time at which the event occurred:</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_dAct.htm"/>
    public virtual DateTime? dAct { get; set; }
    /// <summary>Time at which the event was removed. The event is not removed for NULL</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_dActRemoved.htm"/>
    public virtual DateTime? dActRemoved { get; set; }
    /// <summary>Time at which the record was created. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_dRecordCreated.htm"/>
    public virtual DateTime? dRecordCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_EffectiveDate.htm"/>
    public virtual DateTime? EffectiveDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_iActId.htm"/>
    [KeyAttribute]
    public virtual int iActId { get; set; }
    /// <summary>Process ID which created the record. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_iRecordCreatedByProcessPid.htm"/>
    public virtual int? iRecordCreatedByProcessPid { get; set; }
    /// <summary>Link to sender.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_liActFromPersonId.htm"/>
    public virtual int? liActFromPersonId { get; set; }
    /// <summary>Ticket to which the event belongs</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_liActHdTicketId.htm"/>
    public virtual int? liActHdTicketId { get; set; }
    /// <summary>Link to record type</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_liActKindId.htm"/>
    public virtual int? liActKindId { get; set; }
    /// <summary>Link to recipient.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_liActToPersonId.htm"/>
    public virtual int? liActToPersonId { get; set; }
    /// <summary>Sender contact details</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_mActFromContact.htm"/>
    public virtual string mActFromContact { get; set; }
    /// <summary>Note to event</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_mActNotice.htm"/>
    public virtual string mActNotice { get; set; }
    /// <summary>Time traveled in hours</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_nActTravelHours.htm"/>
    public virtual double? nActTravelHours { get; set; }
    /// <summary>Travel distance in km</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_nActTravelKm.htm"/>
    public virtual double? nActTravelKm { get; set; }
    /// <summary>Number of work hours</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_nActWorkHours.htm"/>
    public virtual double? nActWorkHours { get; set; }
    /// <summary>Name of event</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sAct.htm"/>
    public virtual string sAct { get; set; }
    /// <summary>Atribut AutoSubmitted read from email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActAutoSubmitted.htm"/>
    public virtual string sActAutoSubmitted { get; set; }
    /// <summary>Copy</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActCc.htm"/>
    public virtual string sActCc { get; set; }
    /// <summary>Sender name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFrom.htm"/>
    public virtual string sActFrom { get; set; }
    /// <summary>Sender's company</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromCompany.htm"/>
    public virtual string sActFromCompany { get; set; }
    /// <summary>Sender's department</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromDepartment.htm"/>
    public virtual string sActFromDepartment { get; set; }
    /// <summary>Sender email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromEmail.htm"/>
    public virtual string sActFromEmail { get; set; }
    /// <summary>Sender cell phone</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromMobile.htm"/>
    public virtual string sActFromMobile { get; set; }
    /// <summary>Sender office</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromOffice.htm"/>
    public virtual string sActFromOffice { get; set; }
    /// <summary>Sender's phone</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromPhone.htm"/>
    public virtual string sActFromPhone { get; set; }
    /// <summary>Sender's job</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActFromWorkPosition.htm"/>
    public virtual string sActFromWorkPosition { get; set; }
    /// <summary>Atribut MessageId read from email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActMessageId.htm"/>
    public virtual string sActMessageId { get; set; }
    /// <summary>Name of the recipient. At e-mail messages sent to multiple recipients, the column contains all message recipients.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActTo.htm"/>
    public virtual string sActTo { get; set; }
    /// <summary>Recipient e-mail. The column is empty at e-mail messages sent to multiple recipients.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActToEmail.htm"/>
    public virtual string sActToEmail { get; set; }
    /// <summary>Atribut XSpamLever read from email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActXSpamLevel.htm"/>
    public virtual string sActXSpamLevel { get; set; }
    /// <summary>Atribut XSpamStatus read from email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sActXSpamStatus.htm"/>
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>Name of computer on which the record was created. This attribute is only filled in by the ALVAO Service. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_sRecordCreatedByMachine.htm"/>
    public virtual string sRecordCreatedByMachine { get; set; }
    /// <summary>The flag specifying whether this event can also be seen by requesters or ticket participants without additional permissions for the service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAct_UserRead.htm"/>
    public virtual bool UserRead { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tAct__ctor.htm"/>
    public tAct() { }
}
