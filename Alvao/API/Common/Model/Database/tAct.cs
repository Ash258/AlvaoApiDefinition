using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// The record in communication or ticket log.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAct.htm"/>
[TableAttribute("dbo.tAct")]
public class tAct
{
    public virtual string ActHtml { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    public virtual byte? ActMarkId { get; set; }
    /// <summary>Process kind ID</summary>
    public virtual int? ActOperationId { get; set; }
    /// <summary>If the value is 1, paid</summary>
    public virtual bool bNoCharge { get; set; }
    /// <summary>1 - Marks the start of waiting for the requisitioner from0 - Marks the end of waiting for the requisitionerNULL - does not change the status of waiting for the requisitioner</summary>
    public virtual bool? bWaitingForUser { get; set; }
    /// <summary>User ID of the event creator</summary>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>Time at which the event occurred:</summary>
    public virtual DateTime? dAct { get; set; }
    /// <summary>Time at which the event was removed. The event is not removed for NULL</summary>
    public virtual DateTime? dActRemoved { get; set; }
    /// <summary>Time at which the record was created. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    public virtual DateTime? dRecordCreated { get; set; }
    public virtual DateTime? EffectiveDate { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int iActId { get; set; }
    /// <summary>Process ID which created the record. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    public virtual int? iRecordCreatedByProcessPid { get; set; }
    /// <summary>Link to sender.</summary>
    public virtual int? liActFromPersonId { get; set; }
    /// <summary>Ticket to which the event belongs</summary>
    public virtual int? liActHdTicketId { get; set; }
    /// <summary>Link to record type</summary>
    public virtual int? liActKindId { get; set; }
    /// <summary>Link to recipient.</summary>
    public virtual int? liActToPersonId { get; set; }
    /// <summary>Sender contact details</summary>
    public virtual string mActFromContact { get; set; }
    /// <summary>Note to event</summary>
    public virtual string mActNotice { get; set; }
    /// <summary>Time traveled in hours</summary>
    public virtual double? nActTravelHours { get; set; }
    /// <summary>Travel distance in km</summary>
    public virtual double? nActTravelKm { get; set; }
    /// <summary>Number of work hours</summary>
    public virtual double? nActWorkHours { get; set; }
    /// <summary>Name of event</summary>
    public virtual string sAct { get; set; }
    /// <summary>Atribut AutoSubmitted read from email</summary>
    public virtual string sActAutoSubmitted { get; set; }
    /// <summary>Copy</summary>
    public virtual string sActCc { get; set; }
    /// <summary>Sender name</summary>
    public virtual string sActFrom { get; set; }
    /// <summary>Sender's company</summary>
    public virtual string sActFromCompany { get; set; }
    /// <summary>Sender's department</summary>
    public virtual string sActFromDepartment { get; set; }
    /// <summary>Sender email</summary>
    public virtual string sActFromEmail { get; set; }
    /// <summary>Sender cell phone</summary>
    public virtual string sActFromMobile { get; set; }
    /// <summary>Sender office</summary>
    public virtual string sActFromOffice { get; set; }
    /// <summary>Sender's phone</summary>
    public virtual string sActFromPhone { get; set; }
    /// <summary>Sender's job</summary>
    public virtual string sActFromWorkPosition { get; set; }
    /// <summary>Atribut MessageId read from email</summary>
    public virtual string sActMessageId { get; set; }
    /// <summary>Name of the recipient. At e-mail messages sent to multiple recipients, the column contains all message recipients.</summary>
    public virtual string sActTo { get; set; }
    /// <summary>Recipient e-mail. The column is empty at e-mail messages sent to multiple recipients.</summary>
    public virtual string sActToEmail { get; set; }
    /// <summary>Atribut XSpamLever read from email</summary>
    public virtual string sActXSpamLevel { get; set; }
    /// <summary>Atribut XSpamStatus read from email</summary>
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>Name of computer on which the record was created. This attribute is only filled in by the ALVAO Service. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    public virtual string sRecordCreatedByMachine { get; set; }
    /// <summary>The flag specifying whether this event can also be seen by requesters or ticket participants without additional permissions for the service</summary>
    public virtual bool UserRead { get; set; }

    public tAct() { }
}
