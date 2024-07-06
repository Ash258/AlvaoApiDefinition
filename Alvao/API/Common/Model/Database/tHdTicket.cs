using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Tickets.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicket.htm"/>
[TableAttribute("dbo.tHdTicket")]
public class tHdTicket
{
    /// <summary>ID of the record on the ongoing approval process (tHdTicketApproval.iHdTicketApprovalId).</summary>
    public virtual int? ApprovalId { get; set; }
    /// <summary>ID of the person who closed the ticket</summary>
    public virtual int? ClosedByPersonId { get; set; }
    /// <summary>Ticket close date</summary>
    public virtual DateTime? ClosedDate { get; set; }
    /// <summary>Date and time of the running SLA pause.</summary>
    [ComputedAttribute]
    public virtual DateTime? CurrentSlaPauseStart { get; set; }
    /// <summary>Time at which the ticket was created. When the ticket was created by an e-mail, it is the moment the message was sent.</summary>
    public virtual DateTime? dHdTicket { get; set; }
    /// <summary>Deadline.</summary>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <summary>Time at which the ticket was received. When the ticket was created by an e-mail, it is the moment the message was read from the mailbox.</summary>
    public virtual DateTime? dHdTicketReceived { get; set; }
    /// <summary>Time at which the ticket was deleted.</summary>
    public virtual DateTime? dHdTicketRemoved { get; set; }
    /// <summary>Time to solve ticket by solver.</summary>
    public virtual DateTime? dHdTicketResolved { get; set; }
    /// <summary>"Comments and notes" item on satisfaction survey.</summary>
    public virtual string FeedbackComment { get; set; }
    /// <summary>The "Expertise" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    public virtual int? FeedbackExpertise { get; set; }
    /// <summary>The "Overall satisfaction" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    public virtual int? FeedbackGeneral { get; set; }
    /// <summary>Contains a unique guid ticket identifier.</summary>
    public virtual Guid? FeedbackLinkId { get; set; }
    /// <summary>The "Professionalism" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    public virtual int? FeedbackProfessionality { get; set; }
    /// <summary>The "Resolution speed" item of the satisfaction survey. This is a foreign key in the tColumnValue table. tColumnValue.nOrder contains a numerical representation of the score.</summary>
    public virtual int? FeedbackSolveSpeed { get; set; }
    /// <summary>The event ID that represents the first response (tAct.iActId).</summary>
    [ComputedAttribute]
    public virtual int? FirstReactionActId { get; set; }
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <summary>The event ID that caused the first response. This is usually the same event as FirstReactionActId. In the case that FirstReactionActId is an automatically created event, such as a requester's notification of a change in the ticket status, this column indicates the event that triggered the submission of the notification, such as a change in the ticket status, a new ticket to the solver, etc. (tAct.iActId).</summary>
    [ComputedAttribute]
    public virtual int? FirstReactionTriggeredByActId { get; set; }
    /// <summary>Column is used for full-text search and contains ticket tag, ticket name, requester name, solver name and service name.</summary>
    [ComputedAttribute]
    public virtual string FullTextSearch { get; set; }
    [ExplicitKeyAttribute]
    public virtual int iHdTicketId { get; set; }
    public virtual int? iHdTicketSolverOrder { get; set; }
    public virtual int Impact { get; set; }
    /// <summary>Internal target name.</summary>
    public virtual string InternalTarget { get; set; }
    /// <summary>Internal target date.</summary>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <summary>Date of the last reaction</summary>
    [ComputedAttribute]
    public virtual DateTime? LastActionDate { get; set; }
    /// <summary>Link to service in which the ticket is found.</summary>
    public virtual int liHdTicketHdSectionId { get; set; }
    public virtual int? liHdTicketResolvedPersonId { get; set; }
    /// <summary>Link to room.</summary>
    public virtual int? liHdTicketRoomId { get; set; }
    /// <summary>Link to SLA, used for this ticket.</summary>
    public virtual int liHdTicketSlaId { get; set; }
    /// <summary>ID of the ticket solver (see tPerson.iPersonId). If this is NULL, the ticket has no solver.</summary>
    public virtual int? liHdTicketSolverPersonId { get; set; }
    /// <summary>Link to event that establishes the ticket.</summary>
    public virtual int? liHdTicketStartingActId { get; set; }
    /// <summary>Link to requester.</summary>
    public virtual int liHdTicketUserPersonId { get; set; }
    /// <summary>Notes to the ticket.</summary>
    public virtual string mHdTicketNotice { get; set; }
    /// <summary>Requester contact details.</summary>
    public virtual string mHdTicketUserContact { get; set; }
    /// <summary>The current target date of the ticket.</summary>
    [ComputedAttribute]
    public virtual DateTime? NextActionDeadline { get; set; }
    /// <summary>Original deadline for resolving tickets set according to SLA.</summary>
    public virtual DateTime? OriginalDeadline { get; set; }
    /// <summary>Link to priority.</summary>
    public virtual int? Priority { get; set; }
    /// <summary>Organization for which the ticket is implemented.</summary>
    public virtual int? RelatedAccountId { get; set; }
    /// <summary>The person for whom the ticket is created (tPerson.iPersonId).</summary>
    public virtual int RequestedForPersonId { get; set; }
    /// <summary>Ticket name</summary>
    public virtual string sHdTicket { get; set; }
    /// <summary>device number.</summary>
    public virtual string sHdTicketDeviceCode { get; set; }
    /// <summary>Group.</summary>
    public virtual string sHdTicketGroup { get; set; }
    /// <summary>Ticket number. Contains the prefix and suffix of the service in which the ticket is found as the root of the record ID.</summary>
    public virtual string sHdTicketMessageTag { get; set; }
    /// <summary>Requester name.</summary>
    public virtual string sHdTicketUser { get; set; }
    /// <summary>Requester's company.</summary>
    public virtual string sHdTicketUserCompany { get; set; }
    /// <summary>Requester's department.</summary>
    public virtual string sHdTicketUserDepartment { get; set; }
    /// <summary>Requester email.</summary>
    public virtual string sHdTicketUserEmail { get; set; }
    /// <summary>Requester cell phone</summary>
    public virtual string sHdTicketUserMobile { get; set; }
    /// <summary>Requester office.</summary>
    public virtual string sHdTicketUserOffice { get; set; }
    /// <summary>Requester's phone.</summary>
    public virtual string sHdTicketUserPhone { get; set; }
    /// <summary>Requester's job.</summary>
    public virtual string sHdTicketUserWorkPosition { get; set; }
    public virtual string sHdTicketWaitingForEmail { get; set; }
    /// <summary>Ticket resolution deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present).</summary>
    [ComputedAttribute]
    public virtual DateTime? ShiftedDeadline { get; set; }
    /// <summary>First response deadline shifted by the SLA pause period (does not include the interval from the last event in the ticket log to the present).</summary>
    [ComputedAttribute]
    public virtual DateTime? ShiftedFirstReactionDeadline { get; set; }
    /// <summary>Total SLA pause time within a specific requirement in hours (does not include an interval from the last event in the ticket log until present).</summary>
    [ComputedAttribute]
    public virtual double? SlaPausedHours { get; set; }
    public virtual int? SolverGroupRoleId { get; set; }
    /// <summary>Time elapsed from the beginning of the next interval of the operating time up to the due date of the current target (in the operating hours).</summary>
    [ComputedAttribute]
    public virtual double? SumOfAllOpeningHoursIntervalsToCurrentTarget { get; set; }
    /// <summary>Ticket status ID.</summary>
    public virtual int TicketStateId { get; set; }
    /// <summary>Most important alert of the ticket (TicketAlert.id).</summary>
    [ComputedAttribute]
    public virtual int? TopTicketAlertId { get; set; }
    /// <summary>Number of hours spent on the way in respect of the ticket.</summary>
    [ComputedAttribute]
    public virtual double? TravelHours { get; set; }
    /// <summary>Number of kms reported in relation to the ticket.</summary>
    [ComputedAttribute]
    public virtual double? TravelKm { get; set; }
    public virtual int Urgency { get; set; }
    public virtual string UserEmail2 { get; set; }
    public virtual string UserPhone2 { get; set; }
    /// <summary>Number of hours waited for the requester. The sum does not include an interval from the last event to the present; it is to be added after the vHdTicket view is called.</summary>
    [ComputedAttribute]
    public virtual double? WaitedForUserHours { get; set; }
    /// <summary>If the ticket is waiting for requester, the value is tAct.iActId of the event that initiated waiting. Otherwise NULL.</summary>
    [ComputedAttribute]
    public virtual int? WaitingActId { get; set; }
    /// <summary>Number of hours worked in relation to the ticket.</summary>
    [ComputedAttribute]
    public virtual double? WorkHours { get; set; }

    public tHdTicket() { }
}
