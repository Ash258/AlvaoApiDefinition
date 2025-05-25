using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tickets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html"/>
[Table("dbo.tHdTicket")]
public class tHdTicket {
    /// <summary>ID of the record on the ongoing approval process (tHdTicketApproval.iHdTicketApprovalId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ApprovalId"/>
    public virtual int? ApprovalId { get; set; }
    /// <summary>ID of the person who closed the ticket</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ClosedByPersonId"/>
    public virtual int? ClosedByPersonId { get; set; }
    /// <summary>Ticket close date</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ClosedDate"/>
    public virtual DateTime? ClosedDate { get; set; }
    /// <summary>Date and time of the running SLA pause.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_CurrentSlaPauseStart"/>
    [Computed]
    public virtual DateTime? CurrentSlaPauseStart { get; set; }
    /// <summary>&quot;Comments and notes&quot; item on satisfaction survey.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackComment"/>
    public virtual string FeedbackComment { get; set; }
    /// <summary>The &quot;Expertise&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackExpertise"/>
    public virtual int? FeedbackExpertise { get; set; }
    /// <summary>The &quot;Overall satisfaction&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackGeneral"/>
    public virtual int? FeedbackGeneral { get; set; }
    /// <summary>Contains a unique guid ticket identifier.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackLinkId"/>
    public virtual Guid? FeedbackLinkId { get; set; }
    /// <summary>The &quot;Professionalism&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackProfessionality"/>
    public virtual int? FeedbackProfessionality { get; set; }
    /// <summary>The &quot;Resolution speed&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackSolveSpeed"/>
    public virtual int? FeedbackSolveSpeed { get; set; }
    /// <summary>The event ID that represents the first response (tAct.iActId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionActId"/>
    [Computed]
    public virtual int? FirstReactionActId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionDeadline"/>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <summary>The event ID that caused the first response. This is usually the same event as FirstReactionActId. In the case that FirstReactionActId is an automatically created event, such as a requester's notification of a change in the ticket status, this column indicates the event that triggered the submission of the notification, such as a change in the ticket status, a new ticket to the solver, etc. (tAct.iActId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionTriggeredByActId"/>
    [Computed]
    public virtual int? FirstReactionTriggeredByActId { get; set; }
    /// <summary>Column is used for full-text search and contains ticket tag, ticket name, requester name, solver name and service name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FullTextSearch"/>
    [Computed]
    public virtual string FullTextSearch { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Impact"/>
    public virtual int Impact { get; set; }
    /// <summary>Internal target name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_InternalTarget"/>
    public virtual string InternalTarget { get; set; }
    /// <summary>Internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_InternalTargetDeadline"/>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <summary>List of keywords extracted from ticket comunication separated by comma.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Keywords"/>
    public virtual string Keywords { get; set; }
    /// <summary>Date of the last reaction</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_LastActionDate"/>
    [Computed]
    public virtual DateTime? LastActionDate { get; set; }
    /// <summary>The current target date of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_NextActionDeadline"/>
    [Computed]
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>Original deadline for resolving tickets set according to SLA.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_OriginalDeadline"/>
    public virtual DateTime? OriginalDeadline { get; set; }
    /// <summary>Link to priority.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Priority"/>
    public virtual int? Priority { get; set; }
    /// <summary>Organization for which the ticket is implemented.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_RelatedAccountId"/>
    public virtual int? RelatedAccountId { get; set; }
    /// <summary>The person for whom the ticket is created (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_RequestedForPersonId"/>
    public virtual int RequestedForPersonId { get; set; }
    /// <summary>Ticket resolution deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ShiftedDeadline"/>
    [Computed]
    public virtual DateTime? ShiftedDeadline { get; set; }
    /// <summary>First response deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ShiftedFirstReactionDeadline"/>
    [Computed]
    public virtual DateTime? ShiftedFirstReactionDeadline { get; set; }
    /// <summary>Total SLA pause time within a specific requirement in hours (does not include an interval from the last event in the ticket log until present).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SlaPausedHours"/>
    [Computed]
    public virtual double? SlaPausedHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SolverGroupRoleId"/>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <summary>Time elapsed from the beginning of the next interval of the operating time up to the due date of the current target (in the operating hours).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SumOfAllOpeningHoursIntervalsToCurrentTarget"/>
    [Computed]
    public virtual double? SumOfAllOpeningHoursIntervalsToCurrentTarget { get; set; }
    /// <summary>Ticket status ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TicketStateId"/>
    public virtual int TicketStateId { get; set; }
    /// <summary>Most important alert of the ticket (TicketAlert.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TopTicketAlertId"/>
    [Computed]
    public virtual int? TopTicketAlertId { get; set; }
    /// <summary>Number of hours spent on the way in respect of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TravelHours"/>
    [Computed]
    public virtual double? TravelHours { get; set; }
    /// <summary>Number of kms reported in relation to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TravelKm"/>
    [Computed]
    public virtual double? TravelKm { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Urgency"/>
    public virtual int Urgency { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_UserEmail2"/>
    public virtual string UserEmail2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_UserPhone2"/>
    public virtual string UserPhone2 { get; set; }
    /// <summary>Number of hours waited for the requester. The sum does not include an interval from the last event to the present; it is to be added after the vHdTicket view is called.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WaitedForUserHours"/>
    [Computed]
    public virtual double? WaitedForUserHours { get; set; }
    /// <summary>If the ticket is waiting for requester, the value is tAct.iActId of the event that initiated waiting. Otherwise NULL.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WaitingActId"/>
    [Computed]
    public virtual int? WaitingActId { get; set; }
    /// <summary>Number of hours worked in relation to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WorkHours"/>
    [Computed]
    public virtual double? WorkHours { get; set; }
    /// <summary>Time at which the ticket was created. When the ticket was created by an e-mail, it is the moment the message was sent.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicket"/>
    public virtual DateTime? dHdTicket { get; set; }
    /// <summary>Deadline.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketDeadline"/>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <summary>Time at which the ticket was received. When the ticket was created by an e-mail, it is the moment the message was read from the mailbox.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketReceived"/>
    public virtual DateTime? dHdTicketReceived { get; set; }
    /// <summary>Time at which the ticket was deleted.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketRemoved"/>
    public virtual DateTime? dHdTicketRemoved { get; set; }
    /// <summary>Time to solve ticket by solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketResolved"/>
    public virtual DateTime? dHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_iHdTicketId"/>
    [ExplicitKey]
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_iHdTicketSolverOrder"/>
    public virtual int? iHdTicketSolverOrder { get; set; }
    /// <summary>Link to service in which the ticket is found.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketHdSectionId"/>
    public virtual int liHdTicketHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketResolvedPersonId"/>
    public virtual int? liHdTicketResolvedPersonId { get; set; }
    /// <summary>Link to SLA, used for this ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketSlaId"/>
    public virtual int liHdTicketSlaId { get; set; }
    /// <summary>ID of the ticket solver (see tPerson.iPersonId). If this is NULL, the ticket has no solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketSolverPersonId"/>
    public virtual int? liHdTicketSolverPersonId { get; set; }
    /// <summary>Link to event that establishes the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketStartingActId"/>
    public virtual int? liHdTicketStartingActId { get; set; }
    /// <summary>Link to requester.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketUserPersonId"/>
    public virtual int liHdTicketUserPersonId { get; set; }
    /// <summary>Notes to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_mHdTicketNotice"/>
    public virtual string mHdTicketNotice { get; set; }
    /// <summary>Requester contact details.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_mHdTicketUserContact"/>
    public virtual string mHdTicketUserContact { get; set; }
    /// <summary>Ticket name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicket"/>
    public virtual string sHdTicket { get; set; }
    /// <summary>device number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketDeviceCode"/>
    public virtual string sHdTicketDeviceCode { get; set; }
    /// <summary>Group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketGroup"/>
    public virtual string sHdTicketGroup { get; set; }
    /// <summary>Ticket number. Contains the prefix and suffix of the service in which the ticket is found as the root of the record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketMessageTag"/>
    public virtual string sHdTicketMessageTag { get; set; }
    /// <summary>Requester name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUser"/>
    public virtual string sHdTicketUser { get; set; }
    /// <summary>Requester's company.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserCompany"/>
    public virtual string sHdTicketUserCompany { get; set; }
    /// <summary>Requester's department.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserDepartment"/>
    public virtual string sHdTicketUserDepartment { get; set; }
    /// <summary>Requester email.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserEmail"/>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <summary>Requester cell phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserMobile"/>
    public virtual string sHdTicketUserMobile { get; set; }
    /// <summary>Requester office.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserOffice"/>
    public virtual string sHdTicketUserOffice { get; set; }
    /// <summary>Requester's phone.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserPhone"/>
    public virtual string sHdTicketUserPhone { get; set; }
    /// <summary>Requester's job.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserWorkPosition"/>
    public virtual string sHdTicketUserWorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketWaitingForEmail"/>
    public virtual string sHdTicketWaitingForEmail { get; set; }
}
