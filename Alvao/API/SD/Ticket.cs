using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping request methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Ticket.htm"/>
public static class Ticket
{
    [FlagsAttribute]
    public enum CloseFlags
    {
        None = 0,
        IgnoreRights = 1,
        DontCallChangeState = 2,
    }
    [FlagsAttribute]
    public enum ChangeDeadlineFlags
    {
        None = 0,
        DontNotifyUser = 1,
        DontUpdateTicket = 2,
    }
    public enum ChangeSlaReason
    {
        TicketEdit = 0,
        MoveToService = 1,
    }
    [FlagsAttribute]
    public enum ChangeSolverFlags
    {
        None = 0,
        DontCheckFirstSolverChange = 1,
        DontSendNotification = 2,
        IgnoreRequiredColumns = 4,
        DontLogAssignToMainSolver = 8,
        DontLogAssignToOperator = 8,
        LogAssignToSolverGroup = 16,
        LogAsSystemPerson = 32,
    }
    [FlagsAttribute]
    public enum RemoveFlags
    {
        None = 0,
        IgnoreRights = 1,
        DontCallChangeState = 2,
    }
    [FlagsAttribute]
    public enum ResolveFlags
    {
        None = 0,
        DontNotifyUser = 1,
        IgnoreRights = 2,
        DontCallChangeState = 4,
    }

    /// <summary>Changes request state to closed and cancels internal due date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_Close.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="authorPersonId">Person ID (who closes ticket)(tPerson.iPersonId)</param>
    /// <param name="flags">Flags for special behavior.</param>
    public static void Close(
        int ticketId,
        int authorPersonId,
        Ticket.CloseFlags flags = Ticket.CloseFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates new request from model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_Create.htm"/>
    ///
    /// <param name="newTicketModel">New ticket model</param>
    public static tHdTicket Create(
        NewTicketModel newTicketModel
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns information about ticket by specified column. Allowed columns: SolverName, SolverEmail, TicketPriority, SectionName, RoomName, SLAname, FirstActText, StateName.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ForeignKeyInfo.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <param name="columnName">Specified column name.</param>
    public static string ForeignKeyInfo(
        int ticketId,
        string columnName
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns request database model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_GetById.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static tHdTicket GetById(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns request database model.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_GetByMessageTagInText.htm"/>
    ///
    /// <param name="messageTag">Request messageTag (tHdTicket.sHdTicketMessageTag)</param>
    public static tHdTicket GetByMessageTagInText(
        string messageTag
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns feedback URL for request</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_GetFeedbackUrl.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    public static string GetFeedbackUrl(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns state change notification template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_GetChangeStateTemplate.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="stateId">State ID (tHdTicket.TicketStateId)</param>
    /// <param name="localeId">Locale ID of notication receiver</param>
    /// <param name="html">Allow HTML tags</param>
    /// <param name="requesterNotice">Comment for requester</param>
    /// <param name="isAfterApproval">State change is approval result</param>
    /// <param name="commentActId">ID (tAct.iActId) of act with comment text</param>
    public static string GetChangeStateTemplate(
        int ticketId,
        int stateId,
        int localeId,
        bool html,
        HtmlTextModel requesterNotice = null,
        bool isAfterApproval = false,
        int? commentActId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns request name template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_GetTicketNameTemplate.htm"/>
    ///
    /// <param name="sectionId">Section ID (tHdTicket.liHdTicketHdSectionId)</param>
    public static string GetTicketNameTemplate(
        int sectionId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns whether the request does have all child requests closed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_HasClosedAllChildTickets.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    public static bool HasClosedAllChildTickets(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes request deadline, sends notification and creates act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeDeadline.htm"/>
    ///
    /// <param name="ticketId">Request id (tHdTicket.iHdTicketId)</param>
    /// <param name="newDeadline">New deadline (UTC)</param>
    /// <param name="message">Message for requester</param>
    /// <param name="cost">Deadline change costs</param>
    /// <param name="flags">Deadline change flag</param>
    public static int ChangeDeadline(
        int ticketId,
        DateTime? newDeadline,
        HtmlTextModel message,
        CostModel cost,
        Ticket.ChangeDeadlineFlags flags = Ticket.ChangeDeadlineFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes request SLA, deadline (according to SLA) and creates act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeSla.htm"/>
    ///
    /// <param name="ticketId">Request id (tHdTicket.iHdTicketId)</param>
    /// <param name="newSlaId">New SLA id (tSla.iSlaId)</param>
    /// <param name="cost">Change SLA costs</param>
    /// <param name="reason">SLA change reason</param>
    public static void ChangeSla(
        int ticketId,
        int newSlaId,
        CostModel cost,
        Ticket.ChangeSlaReason reason
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes ticket solver or returns it to main solver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeSolver.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSolverId">Person ID of new solver. Null means that ticket is returned to main solver.</param>
    /// <param name="message">Message for solver</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    [ObsoleteAttribute("Use ChangeSolverOrGroup instead.")]
    public static int ChangeSolver(
        int ticketId,
        int? newSolverId,
        HtmlTextModel message,
        CostModel cost = null,
        int? authorPersonId = null,
        Ticket.ChangeSolverFlags flags = Ticket.ChangeSolverFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes ticket solver group or returns it to main solver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeSolverGroup.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSolverGroupId">Role ID of new solver group. Null means that ticket is returned to main solver.</param>
    /// <param name="message">Message for solver group</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    [ObsoleteAttribute("Use ChangeSolverOrGroup instead.")]
    public static int ChangeSolverGroup(
        int ticketId,
        int? newSolverGroupId,
        HtmlTextModel message,
        CostModel cost = null,
        int? authorPersonId = null,
        Ticket.ChangeSolverFlags flags = Ticket.ChangeSolverFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes ticket solver, solver group or returns it to main solver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeSolverOrGroup.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="solverId">Person ID of new solver. Null means that ticket is returned to main solver. If set to -1 then solver stays unchanged.</param>
    /// <param name="solverGroupId">Role ID of new solver group. Null means that ticket is returned to main solver. If set to -1 then solver group stays unchanged.</param>
    /// <param name="message">Message for solver or solver group</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    public static int ChangeSolverOrGroup(
        int ticketId,
        int? solverId = -1,
        int? solverGroupId = -1,
        HtmlTextModel message = null,
        CostModel cost = null,
        int? authorId = null,
        Ticket.ChangeSolverFlags flags = Ticket.ChangeSolverFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes request state.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_ChangeState.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newStateId">State ID of new state (TicketState.id).</param>
    /// <param name="authorId">Person ID of change author.</param>
    /// <param name="settings">Multiple settings of ticket state change</param>
    public static bool ChangeState(
        int ticketId,
        int newStateId,
        int authorId,
        ChangeTicketStateSettingsModel settings
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Moves request to another service.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_MoveToSection.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSectionId">New service ID (tHdSection.iHdSectionId)</param>
    /// <param name="message">Message for solver</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID (who moves ticket)(tPerson.iPersonId)</param>
    /// <param name="newSolverId">Person ID of new solver (tPerson.iPersonId). Null means that ticket is returned to main solver. -1 means that solver will not change.</param>
    /// <param name="newSolverGroupId">Role ID of new solver group (tRole.iRoleId). Null means that ticket is returned to main solver. -1 means that solver group will not change.</param>
    public static int MoveToSection(
        int ticketId,
        int newSectionId,
        HtmlTextModel message,
        CostModel cost = null,
        int? authorPersonId = null,
        int? newSolverId = -1,
        int? newSolverGroupId = -1
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Insert new row into TicketChange table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_NewTicketChange.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="personId">Person ID (tPerson.iPersonId).</param>
    /// <param name="tableName">Table name.</param>
    /// <param name="columnName">Column name.</param>
    /// <param name="oldValue">Old value.</param>
    /// <param name="newValue">New value.</param>
    /// <param name="columnId">Column ID (tColumn.iColumnId).</param>
    public static int NewTicketChange(
        int ticketId,
        int personId,
        string tableName,
        string columnName,
        Object oldValue,
        Object newValue,
        int? columnId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Remove request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_Remove.htm"/>
    ///
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="personId">Person ID (who removes request)(tPerson.iPersonId).</param>
    /// <param name="flags">Flags for special behavior.</param>
    public static void Remove(
        int ticketId,
        int personId,
        Ticket.RemoveFlags flags = Ticket.RemoveFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Changes request state to resolved.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_Resolve.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="authorPersonId">Person ID (who resolves ticket)(tPerson.iPersonId)</param>
    /// <param name="message">Message for requester</param>
    /// <param name="cost">Resolve costs</param>
    /// <param name="backResolved">Resolve retrospectively to a date (UTC)</param>
    /// <param name="flags">Flags for special behavior.</param>
    public static int Resolve(
        int ticketId,
        int authorPersonId,
        HtmlTextModel message,
        CostModel cost = null,
        DateTime? backResolved = null,
        Ticket.ResolveFlags flags = Ticket.ResolveFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Restore removed request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_RestoreRemoved.htm"/>
    ///
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="personId">Person ID (who restores removed request)(tPerson.iPersonId).</param>
    /// <param name="flags">Flags for special behavior.</param>
    public static void RestoreRemoved(
        int ticketId,
        int personId,
        Ticket.RemoveFlags flags = Ticket.RemoveFlags.None
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Allowed columns: mHdTicketNotice, sHdTicketGroup, sHdTicketDeviceCode, sHdTicketUserPhone, mHdTicketUserContact, sHdTicketUserMobile, sHdTicketUserOffice, sHdTicketUserDepartment, sHdTicketUserWorkPosition, sHdTicketUserCompany.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_UpdateColumnValue.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <param name="columnName">Specified column name.</param>
    /// <param name="newValue">New column value.</param>
    public static void UpdateColumnValue(
        int ticketId,
        string columnName,
        string newValue
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Updates full text search data.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Ticket_UpdateFts.htm"/>
    ///
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId). If 0, updates all requests.</param>
    public static void UpdateFts(
        int ticketId
    )
    { throw new System.NotImplementedException(); }
}
