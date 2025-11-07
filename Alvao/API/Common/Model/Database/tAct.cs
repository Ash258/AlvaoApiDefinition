using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The record in communication or ticket log.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html"/>
[Table("dbo.tAct")]
public class tAct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActHtml"/>
    public virtual string ActHtml { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActMarkId"/>
    public virtual byte? ActMarkId { get; set; }
    /// <summary>Process kind ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActOperationId"/>
    public virtual int? ActOperationId { get; set; }
    /// <summary>User ID of the event creator</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_CreatedByPersonId"/>
    public virtual int? CreatedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_EffectiveDate"/>
    public virtual DateTime? EffectiveDate { get; set; }
    /// <summary>Time at which the record was modified.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_Modified"/>
    public virtual DateTime? Modified { get; set; }
    /// <summary>The flag specifying whether this event can also be seen by requesters or ticket participants without additional permissions for the service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_UserRead"/>
    public virtual bool UserRead { get; set; }
    /// <summary>If the value is 1, paid</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_bNoCharge"/>
    public virtual bool bNoCharge { get; set; }
    /// <summary>1 - Marks the start of waiting for the requisitioner from 0 - Marks the end of waiting for the requisitioner NULL - does not change the status of waiting for the requisitioner</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_bWaitingForUser"/>
    public virtual bool? bWaitingForUser { get; set; }
    /// <summary>Time at which the event occurred:</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dAct"/>
    public virtual DateTime? dAct { get; set; }
    /// <summary>Time at which the event was removed. The event is not removed for NULL</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dActRemoved"/>
    public virtual DateTime? dActRemoved { get; set; }
    /// <summary>Time at which the record was created. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dRecordCreated"/>
    public virtual DateTime? dRecordCreated { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_iActId"/>
    [Key]
    public virtual int iActId { get; set; }
    /// <summary>Process ID which created the record. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_iRecordCreatedByProcessPid"/>
    public virtual int? iRecordCreatedByProcessPid { get; set; }
    /// <summary>Link to sender.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActFromPersonId"/>
    public virtual int? liActFromPersonId { get; set; }
    /// <summary>Ticket to which the event belongs</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActHdTicketId"/>
    public virtual int? liActHdTicketId { get; set; }
    /// <summary>Link to record type</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActKindId"/>
    public virtual int? liActKindId { get; set; }
    /// <summary>Link to recipient.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActToPersonId"/>
    public virtual int? liActToPersonId { get; set; }
    /// <summary>Sender contact details</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_mActFromContact"/>
    public virtual string mActFromContact { get; set; }
    /// <summary>Note to event</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_mActNotice"/>
    public virtual string mActNotice { get; set; }
    /// <summary>Time traveled in hours</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActTravelHours"/>
    public virtual double? nActTravelHours { get; set; }
    /// <summary>Travel distance in km</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActTravelKm"/>
    public virtual double? nActTravelKm { get; set; }
    /// <summary>Number of work hours</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActWorkHours"/>
    public virtual double? nActWorkHours { get; set; }
    /// <summary>Name of event</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sAct"/>
    public virtual string sAct { get; set; }
    /// <summary>Atribut AutoSubmitted read from email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActAutoSubmitted"/>
    public virtual string sActAutoSubmitted { get; set; }
    /// <summary>Copy</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActCc"/>
    public virtual string sActCc { get; set; }
    /// <summary>Sender name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFrom"/>
    public virtual string sActFrom { get; set; }
    /// <summary>Sender's company</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromCompany"/>
    public virtual string sActFromCompany { get; set; }
    /// <summary>Sender's department</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromDepartment"/>
    public virtual string sActFromDepartment { get; set; }
    /// <summary>Sender email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromEmail"/>
    public virtual string sActFromEmail { get; set; }
    /// <summary>Sender cell phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromMobile"/>
    public virtual string sActFromMobile { get; set; }
    /// <summary>Sender office</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromOffice"/>
    public virtual string sActFromOffice { get; set; }
    /// <summary>Sender's phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromPhone"/>
    public virtual string sActFromPhone { get; set; }
    /// <summary>Sender's job</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromWorkPosition"/>
    public virtual string sActFromWorkPosition { get; set; }
    /// <summary>Atribut MessageId read from email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActMessageId"/>
    public virtual string sActMessageId { get; set; }
    /// <summary>Name of the recipient. At e-mail messages sent to multiple recipients, the column contains all message recipients.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActTo"/>
    public virtual string sActTo { get; set; }
    /// <summary>Recipient e-mail. The column is empty at e-mail messages sent to multiple recipients.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActToEmail"/>
    public virtual string sActToEmail { get; set; }
    /// <summary>Atribut XSpamLever read from email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActXSpamLevel"/>
    public virtual string sActXSpamLevel { get; set; }
    /// <summary>Atribut XSpamStatus read from email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActXSpamStatus"/>
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>Name of computer on which the record was created. This attribute is only filled in by the Alvao Service. This attribute is only available from version 2.9, records created with an older version will have a NULL value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sRecordCreatedByMachine"/>
    public virtual string sRecordCreatedByMachine { get; set; }
}
