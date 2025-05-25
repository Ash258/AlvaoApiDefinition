using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>New request model.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html"/>
public class NewTicketModel {
    /// <summary>If true, it will automatically assign Solver if there is only 1 in target Service and there is no other main solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_AssignSolver"/>
    public bool AssignSolver { get; set; }
    /// <summary>If true, it will check AW settings for the first status of the process and possibly change solver group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_AssignSolverGroupViaAW"/>
    public bool AssignSolverGroupViaAW { get; set; }
    /// <summary>If true, ticket subject is created from template, which is set in service settings. If template is not set, ticket subject is not changed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_CreateSubjectFromTemplate"/>
    public bool CreateSubjectFromTemplate { get; set; }
    /// <summary>Custom columns to set to the new request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_CustomColumns"/>
    public CustomColumnsModel CustomColumns { get; set; }
    /// <summary>Request description.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_Description"/>
    public HtmlTextModel Description { get; set; }
    /// <summary>If true, required columns for first state are ignored. Default is false.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_IgnoreRequiredColumns"/>
    public bool IgnoreRequiredColumns { get; set; }
    /// <summary>If true, rights are ignored when creating new ticket. Default is false.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_IgnoreRights"/>
    public bool IgnoreRights { get; set; }
    /// <summary>Sender of incomming message. Used in processing incomming message rules.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_IncommingMessageSender"/>
    public string IncommingMessageSender { get; set; }
    /// <summary>Initial act settings.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_InitialActModel"/>
    public InitialActSettings InitialActModel { get; set; }
    /// <summary>If true, last used service is inserted for current person into OperatorServiceUsage table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_InsertToMainSolverServiceUsage"/>
    public bool InsertToMainSolverServiceUsage { get; set; }
    /// <summary>List of linked objects to the new request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_LinkedObjects"/>
    public IEnumerable<int> LinkedObjects { get; set; }
    /// <summary>Load requester data (name, email, etc.) if tHdTicket.liHdTicketUserPersonId is set. Default is false.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_LoadRequesterData"/>
    public bool LoadRequesterData { get; set; }
    /// <summary>If true, columns not set on process are not saved. Default is true.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_NullColumnsNotSetOnProcess"/>
    public bool NullColumnsNotSetOnProcess { get; set; }
    /// <summary>If true, rules for incomming messages are processed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_ProcessIncommmingMessageRules"/>
    public bool ProcessIncommmingMessageRules { get; set; }
    /// <summary>If true, notification about ticket creation is sent.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_SendNotification"/>
    public bool SendNotification { get; set; }
    /// <summary>Database model of the new request. Some columns are ignored: ClosedByPersonId, ClosedDate, dHdTicketDeadline, dHdTicketRemoved, dHdTicketResolved, FeedbackComment, FeedbackExpertise, FeedbackGeneral, FeedbackLinkId, FeedbackProfessionality, FeedbackSolveSpeed, FirstReactionDeadline, iHdTicketId, ApprovalId, liHdTicketResolvedPersonId, liHdTicketSolverPersonId, liHdTicketStartingActId, OriginalDeadline, sHdTicketMessageTag, sHdTicketWaitingForEmail, TicketStateId, LastActionDate, WorkHours, TravelHours, TravelKm, WaitingActId, WaitedForUserHours, FirstReactionActId, FirstReactionTriggeredByActId, NextActionDeadline, ShiftedDeadline, SumOfAllOpeningHoursIntervalsToCurrentTarget</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.NewTicketModel.html#Alvao_API_SD_Model_NewTicketModel_Ticket"/>
    public tHdTicket Ticket { get; set; }
}
