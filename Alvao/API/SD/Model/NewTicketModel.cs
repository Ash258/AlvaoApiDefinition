using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>
/// New request model.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_NewTicketModel.htm"/>
public class NewTicketModel
{
    /// <summary>If true, it will automatically assign Solver if there is only 1 in target Service and there is no other main solver.</summary>
    public bool AssignSolver { get; set; }
    /// <summary>If true, it will check AW settings for the first status of the process and possibly change solver group.</summary>
    public bool AssignSolverGroupViaAW { get; set; }
    /// <summary>If true, ticket subject is created from template, which is set in service settings. If template is not set, ticket subject is not changed.</summary>
    public bool CreateSubjectFromTemplate { get; set; }
    /// <summary>Custom columns to set to the new request.</summary>
    public CustomColumnsModel CustomColumns { get; set; }
    /// <summary>Request description.</summary>
    public HtmlTextModel Description { get; set; }
    /// <summary>If true, required columns for first state are ignored. Default is false.</summary>
    public bool IgnoreRequiredColumns { get; set; }
    /// <summary>If true, rights are ignored when creating new ticket. Default is false.</summary>
    public bool IgnoreRights { get; set; }
    /// <summary>Sender of incomming message. Used in processing incomming message rules.</summary>
    public string IncommingMessageSender { get; set; }
    /// <summary>Initial act settings.</summary>
    public InitialActSettings InitialActModel { get; set; }
    /// <summary>If true, last used service is inserted for current person into OperatorServiceUsage table.</summary>
    public bool InsertToMainSolverServiceUsage { get; set; }
    /// <summary>List of linked objects to the new request.</summary>
    public IEnumerable<int> LinkedObjects { get; set; }
    /// <summary>Load requester data (name, email, etc.) if tHdTicket.liHdTicketUserPersonId is set. Default is false.</summary>
    public bool LoadRequesterData { get; set; }
    /// <summary>If true, columns not set on process are not saved. Default is true.</summary>
    public bool NullColumnsNotSetOnProcess { get; set; }
    /// <summary>If true, rules for incomming messages are processed.</summary>
    public bool ProcessIncommmingMessageRules { get; set; }
    /// <summary>If true, notification about ticket creation is sent.</summary>
    public bool SendNotification { get; set; }
    /// <summary>Database model of the new request. Some columns are ignored: ClosedByPersonId, ClosedDate, dHdTicketDeadline, dHdTicketRemoved, dHdTicketResolved, FeedbackComment, FeedbackExpertise, FeedbackGeneral, FeedbackLinkId, FeedbackProfessionality, FeedbackSolveSpeed, FirstReactionDeadline, iHdTicketId, ApprovalId, liHdTicketResolvedPersonId, liHdTicketSolverPersonId, liHdTicketStartingActId, OriginalDeadline, sHdTicketMessageTag, sHdTicketWaitingForEmail, TicketStateId, LastActionDate, WorkHours, TravelHours, TravelKm, WaitingActId, WaitedForUserHours, FirstReactionActId, FirstReactionTriggeredByActId, NextActionDeadline, ShiftedDeadline, SumOfAllOpeningHoursIntervalsToCurrentTarget</summary>
    public tHdTicket Ticket { get; set; }

    public NewTicketModel() { }
}
