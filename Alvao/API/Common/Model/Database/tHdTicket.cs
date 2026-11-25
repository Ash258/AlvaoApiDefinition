using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tickets.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html"/>
[Table("dbo.tHdTicket")]
public class tHdTicket {
    /// <summary>Description of the problem and solution of the current ticket created by AI.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_AIDescription"/>
    /// <remarks>Column <c>AIDescription</c>: nvarchar(max), null.</remarks>
    public virtual string AIDescription { get; set; }
    /// <summary>ID of the record on the ongoing approval process (tHdTicketApproval.iHdTicketApprovalId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ApprovalId"/>
    /// <remarks>Column <c>ApprovalId</c>: int, null. References <see cref="tHdTicketApproval"/>.</remarks>
    public virtual int? ApprovalId { get; set; }
    /// <summary>ID of the person who closed the ticket</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ClosedByPersonId"/>
    /// <remarks>Column <c>ClosedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? ClosedByPersonId { get; set; }
    /// <summary>Ticket close date</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ClosedDate"/>
    /// <remarks>Column <c>ClosedDate</c>: datetime, null.</remarks>
    public virtual DateTime? ClosedDate { get; set; }
    /// <summary>Date and time of the running SLA pause.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_CurrentSlaPauseStart"/>
    /// <remarks>Column <c>CurrentSlaPauseStart</c>: datetime, null.</remarks>
    [Computed]
    public virtual DateTime? CurrentSlaPauseStart { get; set; }
    /// <summary>&quot;Comments and notes&quot; item on satisfaction survey.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackComment"/>
    /// <remarks>Column <c>FeedbackComment</c>: nvarchar(max), null.</remarks>
    public virtual string FeedbackComment { get; set; }
    /// <summary>
    /// The &quot;Expertise&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue table.
    /// tColumnValue.nOrder contains a numerical representation of the score.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackExpertise"/>
    /// <remarks>Column <c>FeedbackExpertise</c>: int, null.</remarks>
    public virtual int? FeedbackExpertise { get; set; }
    /// <summary>
    /// The &quot;Overall satisfaction&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue
    /// table. tColumnValue.nOrder contains a numerical representation of the score.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackGeneral"/>
    /// <remarks>Column <c>FeedbackGeneral</c>: int, null. References <see cref="tColumnValue"/>.</remarks>
    public virtual int? FeedbackGeneral { get; set; }
    /// <summary>Contains a unique guid ticket identifier.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackLinkId"/>
    /// <remarks>Column <c>FeedbackLinkId</c>: uniqueidentifier, null.</remarks>
    public virtual Guid? FeedbackLinkId { get; set; }
    /// <summary>
    /// The &quot;Professionalism&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue
    /// table. tColumnValue.nOrder contains a numerical representation of the score.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackProfessionality"/>
    /// <remarks>Column <c>FeedbackProfessionality</c>: int, null.</remarks>
    public virtual int? FeedbackProfessionality { get; set; }
    /// <summary>
    /// The &quot;Resolution speed&quot; item of the satisfaction survey. This is a foreign key in the tColumnValue
    /// table. tColumnValue.nOrder contains a numerical representation of the score.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FeedbackSolveSpeed"/>
    /// <remarks>Column <c>FeedbackSolveSpeed</c>: int, null.</remarks>
    public virtual int? FeedbackSolveSpeed { get; set; }
    /// <summary>The event ID that represents the first response (tAct.iActId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionActId"/>
    /// <remarks>Column <c>FirstReactionActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    [Computed]
    public virtual int? FirstReactionActId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionDeadline"/>
    /// <remarks>Column <c>FirstReactionDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <summary>
    /// The event ID that caused the first response. This is usually the same event as FirstReactionActId. In the case
    /// that FirstReactionActId is an automatically created event, such as a requester's notification of a change in the
    /// ticket status, this column indicates the event that triggered the submission of the notification, such as a
    /// change in the ticket status, a new ticket to the solver, etc. (tAct.iActId).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FirstReactionTriggeredByActId"/>
    /// <remarks>Column <c>FirstReactionTriggeredByActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    [Computed]
    public virtual int? FirstReactionTriggeredByActId { get; set; }
    /// <summary>
    /// Column is used for full-text search and contains ticket tag, ticket name, requester name, solver name and
    /// service name.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_FullTextSearch"/>
    /// <remarks>Column <c>FullTextSearch</c>: nvarchar(max), null.</remarks>
    [Computed]
    public virtual string FullTextSearch { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Impact"/>
    /// <remarks>Column <c>Impact</c>: int, not null. References <see cref="tColumnValue"/>.</remarks>
    public virtual int Impact { get; set; }
    /// <summary>Internal target name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_InternalTarget"/>
    /// <remarks>Column <c>InternalTarget</c>: nvarchar(255), null.</remarks>
    public virtual string InternalTarget { get; set; }
    /// <summary>Internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_InternalTargetDeadline"/>
    /// <remarks>Column <c>InternalTargetDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <summary>Is data sample.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>List of keywords extracted from ticket comunication separated by comma.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Keywords"/>
    /// <remarks>Column <c>Keywords</c>: nvarchar(max), null.</remarks>
    public virtual string Keywords { get; set; }
    /// <summary>Date of the last reaction</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_LastActionDate"/>
    /// <remarks>Column <c>LastActionDate</c>: datetime, null.</remarks>
    [Computed]
    public virtual DateTime? LastActionDate { get; set; }
    /// <summary>The current target date of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_NextActionDeadline"/>
    /// <remarks>Column <c>NextActionDeadline</c>: datetime, null.</remarks>
    [Computed]
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>Original deadline for resolving tickets set according to SLA.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_OriginalDeadline"/>
    /// <remarks>Column <c>OriginalDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? OriginalDeadline { get; set; }
    /// <summary>Link to priority.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Priority"/>
    /// <remarks>Column <c>Priority</c>: int, null. References <see cref="tColumnValue"/>.</remarks>
    public virtual int? Priority { get; set; }
    /// <summary>Organization for which the ticket is implemented.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_RelatedAccountId"/>
    /// <remarks>Column <c>RelatedAccountId</c>: int, null. References <see cref="tAccount"/>.</remarks>
    public virtual int? RelatedAccountId { get; set; }
    /// <summary>The person for whom the ticket is created (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_RequestedForPersonId"/>
    /// <remarks>Column <c>RequestedForPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int RequestedForPersonId { get; set; }
    /// <summary>
    /// Ticket resolution deadline shifted by the SLA pause period (does not include the interval from the last event in
    /// the ticket log to the present).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ShiftedDeadline"/>
    /// <remarks>Column <c>ShiftedDeadline</c>: datetime, null.</remarks>
    [Computed]
    public virtual DateTime? ShiftedDeadline { get; set; }
    /// <summary>
    /// First response deadline shifted by the SLA pause period (does not include the interval from the last event in
    /// the ticket log to the present).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_ShiftedFirstReactionDeadline"/>
    /// <remarks>Column <c>ShiftedFirstReactionDeadline</c>: datetime, null.</remarks>
    [Computed]
    public virtual DateTime? ShiftedFirstReactionDeadline { get; set; }
    /// <summary>
    /// Total SLA pause time within a specific requirement in hours (does not include an interval from the last event in
    /// the ticket log until present).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SlaPausedHours"/>
    /// <remarks>Column <c>SlaPausedHours</c>: float, null.</remarks>
    [Computed]
    public virtual double? SlaPausedHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SolverGroupRoleId"/>
    /// <remarks>Column <c>SolverGroupRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <summary>
    /// Time elapsed from the beginning of the next interval of the operating time up to the due date of the current
    /// target (in the operating hours).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_SumOfAllOpeningHoursIntervalsToCurrentTarget"/>
    /// <remarks>Column <c>SumOfAllOpeningHoursIntervalsToCurrentTarget</c>: float, null.</remarks>
    [Computed]
    public virtual double? SumOfAllOpeningHoursIntervalsToCurrentTarget { get; set; }
    /// <summary>Ticket status ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TicketStateId"/>
    /// <remarks>Column <c>TicketStateId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int TicketStateId { get; set; }
    /// <summary>Most important alert of the ticket (TicketAlert.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TopTicketAlertId"/>
    /// <remarks>Column <c>TopTicketAlertId</c>: int, null. References <see cref="TicketAlert"/>.</remarks>
    [Computed]
    public virtual int? TopTicketAlertId { get; set; }
    /// <summary>Number of hours spent on the way in respect of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TravelHours"/>
    /// <remarks>Column <c>TravelHours</c>: float, null.</remarks>
    [Computed]
    public virtual double? TravelHours { get; set; }
    /// <summary>Number of kms reported in relation to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_TravelKm"/>
    /// <remarks>Column <c>TravelKm</c>: float, null.</remarks>
    [Computed]
    public virtual double? TravelKm { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_Urgency"/>
    /// <remarks>Column <c>Urgency</c>: int, not null. References <see cref="tColumnValue"/>.</remarks>
    public virtual int Urgency { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_UserEmail2"/>
    /// <remarks>Column <c>UserEmail2</c>: nvarchar(255), null.</remarks>
    public virtual string UserEmail2 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_UserPhone2"/>
    /// <remarks>Column <c>UserPhone2</c>: nvarchar(255), null.</remarks>
    public virtual string UserPhone2 { get; set; }
    /// <summary>
    /// Number of hours waited for the requester. The sum does not include an interval from the last event to the
    /// present; it is to be added after the vHdTicket view is called.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WaitedForUserHours"/>
    /// <remarks>Column <c>WaitedForUserHours</c>: float, null.</remarks>
    [Computed]
    public virtual double? WaitedForUserHours { get; set; }
    /// <summary>
    /// If the ticket is waiting for requester, the value is tAct.iActId of the event that initiated waiting. Otherwise
    /// NULL.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WaitingActId"/>
    /// <remarks>Column <c>WaitingActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    [Computed]
    public virtual int? WaitingActId { get; set; }
    /// <summary>Number of hours worked in relation to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_WorkHours"/>
    /// <remarks>Column <c>WorkHours</c>: float, null.</remarks>
    [Computed]
    public virtual double? WorkHours { get; set; }
    /// <summary>
    /// Time at which the ticket was created. When the ticket was created by an email, it is the moment the message was
    /// sent.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicket"/>
    /// <remarks>Column <c>dHdTicket</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicket { get; set; }
    /// <summary>Deadline.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketDeadline"/>
    /// <remarks>Column <c>dHdTicketDeadline</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <summary>
    /// Time at which the ticket was received. When the ticket was created by an email, it is the moment the message was
    /// read from the mailbox.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketReceived"/>
    /// <remarks>Column <c>dHdTicketReceived</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketReceived { get; set; }
    /// <summary>Time at which the ticket was deleted.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketRemoved"/>
    /// <remarks>Column <c>dHdTicketRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketRemoved { get; set; }
    /// <summary>Time to solve ticket by solver.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_dHdTicketResolved"/>
    /// <remarks>Column <c>dHdTicketResolved</c>: datetime, null.</remarks>
    public virtual DateTime? dHdTicketResolved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_iHdTicketId"/>
    /// <remarks>Column <c>iHdTicketId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_iHdTicketSolverOrder"/>
    /// <remarks>Column <c>iHdTicketSolverOrder</c>: int, null.</remarks>
    public virtual int? iHdTicketSolverOrder { get; set; }
    /// <summary>Link to service in which the ticket is found.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketHdSectionId"/>
    /// <remarks>Column <c>liHdTicketHdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int liHdTicketHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketResolvedPersonId"/>
    /// <remarks>Column <c>liHdTicketResolvedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdTicketResolvedPersonId { get; set; }
    /// <summary>Link to SLA, used for this ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketSlaId"/>
    /// <remarks>Column <c>liHdTicketSlaId</c>: int, not null. References <see cref="tSla"/>.</remarks>
    public virtual int liHdTicketSlaId { get; set; }
    /// <summary>ID of the ticket solver (see tPerson.iPersonId). If this is NULL, the ticket has no solver.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketSolverPersonId"/>
    /// <remarks>Column <c>liHdTicketSolverPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdTicketSolverPersonId { get; set; }
    /// <summary>Link to event that establishes the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketStartingActId"/>
    /// <remarks>Column <c>liHdTicketStartingActId</c>: int, null. References <see cref="tAct"/>.</remarks>
    public virtual int? liHdTicketStartingActId { get; set; }
    /// <summary>Link to requester.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_liHdTicketUserPersonId"/>
    /// <remarks>Column <c>liHdTicketUserPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int liHdTicketUserPersonId { get; set; }
    /// <summary>Notes to the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_mHdTicketNotice"/>
    /// <remarks>Column <c>mHdTicketNotice</c>: nvarchar(max), null.</remarks>
    public virtual string mHdTicketNotice { get; set; }
    /// <summary>Requester contact details.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_mHdTicketUserContact"/>
    /// <remarks>Column <c>mHdTicketUserContact</c>: nvarchar(max), null.</remarks>
    public virtual string mHdTicketUserContact { get; set; }
    /// <summary>Ticket name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicket"/>
    /// <remarks>Column <c>sHdTicket</c>: nvarchar(1024), null.</remarks>
    public virtual string sHdTicket { get; set; }
    /// <summary>Device number.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketDeviceCode"/>
    /// <remarks>Column <c>sHdTicketDeviceCode</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketDeviceCode { get; set; }
    /// <summary>Group.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketGroup"/>
    /// <remarks>Column <c>sHdTicketGroup</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketGroup { get; set; }
    /// <summary>
    /// Ticket number. Contains the prefix and suffix of the service in which the ticket is found as the root of the
    /// record ID.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketMessageTag"/>
    /// <remarks>Column <c>sHdTicketMessageTag</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketMessageTag { get; set; }
    /// <summary>Requester name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUser"/>
    /// <remarks>Column <c>sHdTicketUser</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUser { get; set; }
    /// <summary>Requester's company.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserCompany"/>
    /// <remarks>Column <c>sHdTicketUserCompany</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserCompany { get; set; }
    /// <summary>Requester's department.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserDepartment"/>
    /// <remarks>Column <c>sHdTicketUserDepartment</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserDepartment { get; set; }
    /// <summary>Requester email.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserEmail"/>
    /// <remarks>Column <c>sHdTicketUserEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <summary>Requester cell phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserMobile"/>
    /// <remarks>Column <c>sHdTicketUserMobile</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserMobile { get; set; }
    /// <summary>Requester office.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserOffice"/>
    /// <remarks>Column <c>sHdTicketUserOffice</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserOffice { get; set; }
    /// <summary>Requester's phone.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserPhone"/>
    /// <remarks>Column <c>sHdTicketUserPhone</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserPhone { get; set; }
    /// <summary>Requester's job.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketUserWorkPosition"/>
    /// <remarks>Column <c>sHdTicketUserWorkPosition</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketUserWorkPosition { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicket.html#Alvao_API_Common_Model_Database_tHdTicket_sHdTicketWaitingForEmail"/>
    /// <remarks>Column <c>sHdTicketWaitingForEmail</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketWaitingForEmail { get; set; }
}
