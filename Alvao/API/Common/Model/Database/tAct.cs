using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The record in communication or ticket log.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html"/>
[Table("dbo.tAct")]
public class tAct {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActHtml"/>
    /// <remarks>Column <c>ActHtml</c>: nvarchar(max), null.</remarks>
    public virtual string ActHtml { get; set; }
    /// <summary>Record marking. A foreign key to the ActMark table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActMarkId"/>
    /// <remarks>Column <c>ActMarkId</c>: tinyint, null. References <see cref="ActMark"/>.</remarks>
    public virtual byte? ActMarkId { get; set; }
    /// <summary>Process kind ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_ActOperationId"/>
    /// <remarks>Column <c>ActOperationId</c>: int, null. References <see cref="ActOperation"/>.</remarks>
    public virtual int? ActOperationId { get; set; }
    /// <summary>User ID of the event creator</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CreatedByPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_EffectiveDate"/>
    /// <remarks>Column <c>EffectiveDate</c>: datetime, null.</remarks>
    public virtual DateTime? EffectiveDate { get; set; }
    /// <summary>Time at which the record was modified.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_Modified"/>
    /// <remarks>Column <c>Modified</c>: datetime, null.</remarks>
    public virtual DateTime? Modified { get; set; }
    /// <summary>
    /// The flag specifying whether this event can also be seen by requesters or ticket participants without additional
    /// permissions for the service
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_UserRead"/>
    /// <remarks>Column <c>UserRead</c>: bit, not null.</remarks>
    public virtual bool UserRead { get; set; }
    /// <summary>If the value is 1, paid</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_bNoCharge"/>
    /// <remarks>Column <c>bNoCharge</c>: bit, not null.</remarks>
    public virtual bool bNoCharge { get; set; }
    /// <summary>
    /// 1 - Marks the start of waiting for the requisitioner from 0 - Marks the end of waiting for the requisitioner
    /// NULL - does not change the status of waiting for the requisitioner
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_bWaitingForUser"/>
    /// <remarks>Column <c>bWaitingForUser</c>: bit, null.</remarks>
    public virtual bool? bWaitingForUser { get; set; }
    /// <summary>Time at which the event occurred:</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dAct"/>
    /// <remarks>Column <c>dAct</c>: datetime, null.</remarks>
    public virtual DateTime? dAct { get; set; }
    /// <summary>Time at which the event was removed. The event is not removed for NULL</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dActRemoved"/>
    /// <remarks>Column <c>dActRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dActRemoved { get; set; }
    /// <summary>
    /// Time at which the record was created. This attribute is only available from version 2.9, records created with an
    /// older version will have a NULL value
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_dRecordCreated"/>
    /// <remarks>Column <c>dRecordCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dRecordCreated { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_iActId"/>
    /// <remarks>Column <c>iActId</c>: int, not null.</remarks>
    [Key]
    public virtual int iActId { get; set; }
    /// <summary>
    /// Process ID which created the record. This attribute is only available from version 2.9, records created with an
    /// older version will have a NULL value
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_iRecordCreatedByProcessPid"/>
    /// <remarks>Column <c>iRecordCreatedByProcessPid</c>: int, null.</remarks>
    public virtual int? iRecordCreatedByProcessPid { get; set; }
    /// <summary>Link to sender.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActFromPersonId"/>
    /// <remarks>Column <c>liActFromPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liActFromPersonId { get; set; }
    /// <summary>Ticket to which the event belongs</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActHdTicketId"/>
    /// <remarks>Column <c>liActHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int liActHdTicketId { get; set; }
    /// <summary>Link to record type</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActKindId"/>
    /// <remarks>Column <c>liActKindId</c>: int, null. References <see cref="tActKind"/>.</remarks>
    public virtual int? liActKindId { get; set; }
    /// <summary>Link to recipient.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_liActToPersonId"/>
    /// <remarks>Column <c>liActToPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liActToPersonId { get; set; }
    /// <summary>Sender contact details</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_mActFromContact"/>
    /// <remarks>Column <c>mActFromContact</c>: nvarchar(max), null.</remarks>
    public virtual string mActFromContact { get; set; }
    /// <summary>Note to event</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_mActNotice"/>
    /// <remarks>Column <c>mActNotice</c>: nvarchar(max), null.</remarks>
    public virtual string mActNotice { get; set; }
    /// <summary>Time traveled in hours</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActTravelHours"/>
    /// <remarks>Column <c>nActTravelHours</c>: float, null.</remarks>
    public virtual double? nActTravelHours { get; set; }
    /// <summary>Travel distance in km</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActTravelKm"/>
    /// <remarks>Column <c>nActTravelKm</c>: float, null.</remarks>
    public virtual double? nActTravelKm { get; set; }
    /// <summary>Number of work hours</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_nActWorkHours"/>
    /// <remarks>Column <c>nActWorkHours</c>: float, null.</remarks>
    public virtual double? nActWorkHours { get; set; }
    /// <summary>Name of event</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sAct"/>
    /// <remarks>Column <c>sAct</c>: nvarchar(max), null.</remarks>
    public virtual string sAct { get; set; }
    /// <summary>Atribut AutoSubmitted read from email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActAutoSubmitted"/>
    /// <remarks>Column <c>sActAutoSubmitted</c>: nvarchar(255), null.</remarks>
    public virtual string sActAutoSubmitted { get; set; }
    /// <summary>Copy</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActCc"/>
    /// <remarks>Column <c>sActCc</c>: nvarchar(4000), null.</remarks>
    public virtual string sActCc { get; set; }
    /// <summary>Sender name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFrom"/>
    /// <remarks>Column <c>sActFrom</c>: nvarchar(1024), null.</remarks>
    public virtual string sActFrom { get; set; }
    /// <summary>Sender's company</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromCompany"/>
    /// <remarks>Column <c>sActFromCompany</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromCompany { get; set; }
    /// <summary>Sender's department</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromDepartment"/>
    /// <remarks>Column <c>sActFromDepartment</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromDepartment { get; set; }
    /// <summary>Sender email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromEmail"/>
    /// <remarks>Column <c>sActFromEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromEmail { get; set; }
    /// <summary>Sender cell phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromMobile"/>
    /// <remarks>Column <c>sActFromMobile</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromMobile { get; set; }
    /// <summary>Sender office</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromOffice"/>
    /// <remarks>Column <c>sActFromOffice</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromOffice { get; set; }
    /// <summary>Sender's phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromPhone"/>
    /// <remarks>Column <c>sActFromPhone</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromPhone { get; set; }
    /// <summary>Sender's job</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActFromWorkPosition"/>
    /// <remarks>Column <c>sActFromWorkPosition</c>: nvarchar(255), null.</remarks>
    public virtual string sActFromWorkPosition { get; set; }
    /// <summary>Atribut MessageId read from email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActMessageId"/>
    /// <remarks>Column <c>sActMessageId</c>: nvarchar(255), null.</remarks>
    public virtual string sActMessageId { get; set; }
    /// <summary>
    /// Name of the recipient. At email messages sent to multiple recipients, the column contains all message
    /// recipients.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActTo"/>
    /// <remarks>Column <c>sActTo</c>: nvarchar(4000), null.</remarks>
    public virtual string sActTo { get; set; }
    /// <summary>Recipient email. The column is empty at email messages sent to multiple recipients.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActToEmail"/>
    /// <remarks>Column <c>sActToEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sActToEmail { get; set; }
    /// <summary>Atribut XSpamLever read from email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActXSpamLevel"/>
    /// <remarks>Column <c>sActXSpamLevel</c>: nvarchar(255), null.</remarks>
    public virtual string sActXSpamLevel { get; set; }
    /// <summary>Atribut XSpamStatus read from email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sActXSpamStatus"/>
    /// <remarks>Column <c>sActXSpamStatus</c>: nvarchar(255), null.</remarks>
    public virtual string sActXSpamStatus { get; set; }
    /// <summary>
    /// Name of computer on which the record was created. This attribute is only filled in by the Alvao Service. This
    /// attribute is only available from version 2.9, records created with an older version will have a NULL value
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAct.html#Alvao_API_Common_Model_Database_tAct_sRecordCreatedByMachine"/>
    /// <remarks>Column <c>sRecordCreatedByMachine</c>: nvarchar(255), null.</remarks>
    public virtual string sRecordCreatedByMachine { get; set; }
}
