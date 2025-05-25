using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping request methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html"/>
public static class Ticket {
    /// <summary>Special flags for deadline change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.ChangeDeadlineFlags.html#fields"/>
    [Flags]
    public enum ChangeDeadlineFlags {
        DontNotifyUser = 1,
        DontUpdateTicket = 2,
        None = 0,
    }
    /// <summary>SLA change reason.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.ChangeSlaReason.html#fields"/>
    public enum ChangeSlaReason {
        MoveToService = 1,
        TicketEdit = 0,
    }
    /// <summary>Special flags for solver change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.ChangeSolverFlags.html#fields"/>
    [Flags]
    public enum ChangeSolverFlags {
        DontCheckFirstSolverChange = 1,
        DontLogAssignToMainSolver = 8,
        [Obsolete("Use DontLogAssignToMainSolver instead.")]
        DontLogAssignToOperator = 8,
        DontSendNotification = 2,
        IgnoreRequiredColumns = 4,
        LogAsSystemPerson = 32,
        LogAssignToSolverGroup = 16,
        None = 0,
    }
    /// <summary>Special flags for close ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.CloseFlags.html#fields"/>
    [Flags]
    public enum CloseFlags {
        DontCallChangeState = 2,
        IgnoreRights = 1,
        None = 0,
    }
    /// <summary>Special flags for remove ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.RemoveFlags.html#fields"/>
    [Flags]
    public enum RemoveFlags {
        DontCallChangeState = 2,
        IgnoreRights = 1,
        None = 0,
    }
    /// <summary>Special flags for resolve ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.ResolveFlags.html#fields"/>
    [Flags]
    public enum ResolveFlags {
        DontCallChangeState = 4,
        DontNotifyUser = 1,
        IgnoreRights = 2,
        None = 0,
    }
    /// <summary>Changes request deadline, sends notification and creates act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeDeadline_System_Int32_System_Nullable_System_DateTime__Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_Alvao_API_SD_Ticket_ChangeDeadlineFlags_"/>
    /// <param name="ticketId">Request id (tHdTicket.iHdTicketId)</param>
    /// <param name="newDeadline">New deadline (UTC)</param>
    /// <param name="message">Message for requester</param>
    /// <param name="cost">Deadline change costs</param>
    /// <param name="flags">Deadline change flag</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <returns>Created act id (tAct.iActId)</returns>
    public static int ChangeDeadline(int ticketId, DateTime? newDeadline, HtmlTextModel message, CostModel cost, Ticket.ChangeDeadlineFlags flags = ChangeDeadlineFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>Changes request SLA, deadline (according to SLA) and creates act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeSla_System_Int32_System_Int32_Alvao_API_SD_Model_CostModel_Alvao_API_SD_Ticket_ChangeSlaReason_"/>
    /// <param name="ticketId">Request id (tHdTicket.iHdTicketId)</param>
    /// <param name="newSlaId">New SLA id (tSla.iSlaId)</param>
    /// <param name="cost">Change SLA costs</param>
    /// <param name="reason">SLA change reason</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId or SLA with newSlaId does not exist.</exception>
    /// <exception cref="ValidationException">Throws when the ticket requester or the requestedFor user does not have the specified SLA  for the service.</exception>
    /// <exception cref="NotImplementedException">Throws when SLA change reason is not implemented.</exception>
    public static void ChangeSla(int ticketId, int newSlaId, CostModel cost, Ticket.ChangeSlaReason reason) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Changes ticket solver or returns it to main solver.
    /// <example>
    /// <code>
    /// int ticketId = 25; //Request id
    /// int newSolverId = 10; //New solver id
    /// Alvao.API.SD.Ticket.ChangeSolver(ticketId, newSolverId, new Alvao.API.Common.Model.HtmlTextModel("The Request was passed to solver.")); //Change of request solver
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeSolver_System_Int32_System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_System_Nullable_System_Int32__Alvao_API_SD_Ticket_ChangeSolverFlags_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSolverId">Person ID of new solver. Null means that ticket is returned to main solver.</param>
    /// <param name="message">Message for solver</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <exception cref="ArgumentNullException">Throws when message is null.</exception>
    /// <returns>Act ID (tAct.iActId) with log of solver change.</returns>
    [Obsolete("Use ChangeSolverOrGroup instead.")]
    public static int ChangeSolver(int ticketId, int? newSolverId, HtmlTextModel message, CostModel cost = null, int? authorPersonId = null, Ticket.ChangeSolverFlags flags = ChangeSolverFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Changes ticket solver group or returns it to main solver.
    /// <example>
    /// <code>
    /// int ticketId = 25; //Request id
    /// int newSolverGroupId = 10; //New solver group id
    /// Alvao.API.SD.Ticket.ChangeSolver(ticketId, newSolverGroupId, new Alvao.API.Common.Model.HtmlTextModel("The Request was passed to solver group.")); //Change of request solver group
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeSolverGroup_System_Int32_System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_System_Nullable_System_Int32__Alvao_API_SD_Ticket_ChangeSolverFlags_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSolverGroupId">Role ID of new solver group. Null means that ticket is returned to main solver.</param>
    /// <param name="message">Message for solver group</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <exception cref="ArgumentNullException">Throws when message is null.</exception>
    /// <returns>Act ID (tAct.iActId) with log of solver group change.</returns>
    [Obsolete("Use ChangeSolverOrGroup instead.")]
    public static int ChangeSolverGroup(int ticketId, int? newSolverGroupId, HtmlTextModel message, CostModel cost = null, int? authorPersonId = null, Ticket.ChangeSolverFlags flags = ChangeSolverFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Changes ticket solver, solver group or returns it to main solver.
    /// <example>
    /// <code>
    /// int ticketId = 25; // Request id
    /// int newSolverId = 10; // New solver id
    /// int newSolverGroupId = 5; // New solver group id
    /// 
    /// // Change of request solver and solver group
    /// Alvao.API.SD.Ticket.ChangeSolverOrGroup(ticketId, newSolverId, newSolverGroupId,
    ///     new Alvao.API.Common.Model.HtmlTextModel("The Request was passed to solver group."));
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeSolverOrGroup_System_Int32_System_Nullable_System_Int32__System_Nullable_System_Int32__Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_System_Nullable_System_Int32__Alvao_API_SD_Ticket_ChangeSolverFlags_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="solverId">Person ID of new solver. Null means that ticket is returned to main solver. If set to -1 then solver stays unchanged.</param>
    /// <param name="solverGroupId">Role ID of new solver group. Null means that ticket is returned to main solver. If set to -1 then solver group stays unchanged.</param>
    /// <param name="message">Message for solver or solver group</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorId">Person ID of change author. In case of null, current user will be used.</param>
    /// <param name="flags">Flags for special cases.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <returns>0 if no act was logged otherwise act ID (tAct.iActId) with log of solver or solver group change.</returns>
    public static int ChangeSolverOrGroup(int ticketId, int? solverId = -1, int? solverGroupId = -1, HtmlTextModel message = null, CostModel cost = null, int? authorId = null, Ticket.ChangeSolverFlags flags = ChangeSolverFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Changes request state.
    /// <example>
    /// <code>
    /// int ticketId = 50; //Request id
    /// int newStateId = 10; //New state id
    /// int authorId = 40; //Autor of change state
    /// Alvao.API.Common.Model.HtmlTextModel messageModel = new Alvao.API.Common.Model.HtmlTextModel("Message in HTML"); //Create message
    /// Alvao.API.SD.Model.ChangeTicketStateSettingsModel settings = new Alvao.API.SD.Model.ChangeTicketStateSettingsModel() //Create settings model with message
    /// {
    ///     Message = messageModel
    /// };
    /// 
    /// Alvao.API.SD.Ticket.ChangeState(ticketId, newStateId, authorId, settings); //Change request state
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ChangeState_System_Int32_System_Int32_System_Int32_Alvao_API_SD_Model_ChangeTicketStateSettingsModel_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newStateId">State ID of new state (TicketState.id).</param>
    /// <param name="authorId">Person ID of change author.</param>
    /// <param name="settings">Multiple settings of ticket state change</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist or request state with newStateId doest not exist.</exception>
    /// <exception cref="ValidationException">Throws when closing request and not all of its child requests have been closed or when reopening request which is already opened.</exception>
    /// <returns>True if state is changed succesfully, otherwise False.</returns>
    public static bool ChangeState(int ticketId, int newStateId, int authorId, ChangeTicketStateSettingsModel settings) { throw new System.NotImplementedException(); }
    /// <summary>Changes request state to closed and cancels internal due date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_Close_System_Int32_System_Int32_Alvao_API_SD_Ticket_CloseFlags_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="authorPersonId">Person ID (who closes ticket)(tPerson.iPersonId)</param>
    /// <param name="flags">Flags for special behavior.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <exception cref="ValidationException">Throws when authorPersonId does not have rights to close request.</exception>
    public static void Close(int ticketId, int authorPersonId, Ticket.CloseFlags flags = CloseFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Creates new request from model.
    /// <example>
    /// <code>
    /// Alvao.API.SD.Model.NewTicketModel newTicketModel = new Alvao.API.SD.Model.NewTicketModel(); //Create model for request.
    /// newTicketModel.Description = new Alvao.API.Common.Model.HtmlTextModel("Request description in HTML"); //Request description
    /// newTicketModel.Ticket.sHdTicket = "Request name"; //Request name
    /// newTicketModel.Ticket.liHdTicketHdSectionId = 8; //Section Id
    /// newTicketModel.Ticket.liHdTicketUserPersonId = 3; //Requester Id
    /// newTicketModel.LoadRequesterData = true; //To display information about requester
    /// Alvao.API.SD.Ticket.Create(newTicketModel); //Create request from model
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_Create_Alvao_API_SD_Model_NewTicketModel_"/>
    /// <param name="newTicketModel">New ticket model</param>
    /// <exception cref="ArgumentException">Throws when newTicketModel is null or has custom column which is not supported.</exception>
    /// <exception cref="SlaAccessException">Throws when request requester does not have SLA in the section.</exception>
    /// <returns>Created request (tHdTicket)</returns>
    public static tHdTicket Create(NewTicketModel newTicketModel) { throw new System.NotImplementedException(); }
    /// <summary>Returns information about ticket by specified column.  Allowed columns: SolverName, SolverEmail, TicketPriority, SectionName, RoomName, SLAname, FirstActText, StateName.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_ForeignKeyInfo_System_Int32_System_String_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <param name="columnName">Specified column name.</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist or columnName is not defined or is forbidden.</exception>
    /// <returns>Text value of specified column.</returns>
    public static string ForeignKeyInfo(int ticketId, string columnName) { throw new System.NotImplementedException(); }
    /// <summary>Returns request database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_GetById_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>Request model (tHdTicket)</returns>
    public static tHdTicket GetById(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns request database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_GetByMessageTagInText_System_String_"/>
    /// <param name="messageTag">Request messageTag (tHdTicket.sHdTicketMessageTag)</param>
    /// <returns>Request model (tHdTicket)</returns>
    public static tHdTicket GetByMessageTagInText(string messageTag) { throw new System.NotImplementedException(); }
    /// <summary>Returns state change notification template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_GetChangeStateTemplate_System_Int32_System_Int32_System_Int32_System_Boolean_Alvao_API_Common_Model_HtmlTextModel_System_Boolean_System_Nullable_System_Int32__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="stateId">State ID (tHdTicket.TicketStateId)</param>
    /// <param name="localeId">Locale ID of notication receiver</param>
    /// <param name="html">Allow HTML tags</param>
    /// <param name="requesterNotice">Comment for requester</param>
    /// <param name="isAfterApproval">State change is approval result</param>
    /// <param name="commentActId">ID (tAct.iActId) of act with comment text</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId or request state with stateId does not exist.</exception>
    /// <returns>Filled template for ticket state notification.</returns>
    public static string GetChangeStateTemplate(int ticketId, int stateId, int localeId, bool html, HtmlTextModel requesterNotice = null, bool isAfterApproval = false, int? commentActId = null) { throw new System.NotImplementedException(); }
    /// <summary>Returns feedback URL for request</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_GetFeedbackUrl_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <returns>Feedback URL</returns>
    public static string GetFeedbackUrl(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Returns request name template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_GetTicketNameTemplate_System_Int32_"/>
    /// <param name="sectionId">Section ID (tHdTicket.liHdTicketHdSectionId)</param>
    /// <returns>Template for request name</returns>
    public static string GetTicketNameTemplate(int sectionId) { throw new System.NotImplementedException(); }
    /// <summary>Returns whether the request does have all child requests closed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_HasClosedAllChildTickets_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    /// <returns>True, if request has all child requests closed.</returns>
    public static bool HasClosedAllChildTickets(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Moves request to another service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_MoveToSection_System_Int32_System_Int32_Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="newSectionId">New service ID (tHdSection.iHdSectionId)</param>
    /// <param name="message">Message for solver</param>
    /// <param name="cost">Costs</param>
    /// <param name="authorPersonId">Person ID (who moves ticket)(tPerson.iPersonId)</param>
    /// <param name="newSolverId">Person ID of new solver (tPerson.iPersonId). Null means that ticket is returned to main solver. -1 means that solver will not change.</param>
    /// <param name="newSolverGroupId">Role ID of new solver group (tRole.iRoleId). Null means that ticket is returned to main solver. -1 means that solver group will not change.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist or request is already in the service with ID newSectionId.</exception>
    /// <exception cref="ArgumentNullException">Throws when message is null.</exception>
    /// <exception cref="SlaAccessException">Throws when request requester does not have SLA in new section.</exception>
    /// <returns>Created act ID (tAct.iActId).</returns>
    public static int MoveToSection(int ticketId, int newSectionId, HtmlTextModel message, CostModel cost = null, int? authorPersonId = null, int? newSolverId = -1, int? newSolverGroupId = -1) { throw new System.NotImplementedException(); }
    /// <summary>Insert new row into TicketChange table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_NewTicketChange_System_Int32_System_Int32_System_String_System_String_System_Object_System_Object_System_Nullable_System_Int32__"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="personId">Person ID (tPerson.iPersonId).</param>
    /// <param name="tableName">Table name.</param>
    /// <param name="columnName">Column name.</param>
    /// <param name="oldValue">Old value.</param>
    /// <param name="newValue">New value.</param>
    /// <param name="columnId">Column ID (tColumn.iColumnId).</param>
    /// <exception cref="ArgumentException">Throws when ticketId or personId does not exist. Throws when ticketId or personId or columnId is 0. Or when columnId is not defined or 0 and tableName is defined, but columnName is empty and vice versa.</exception>
    /// <returns>Newly added ID of tColumn row (iColumnId).</returns>
    public static int NewTicketChange(int ticketId, int personId, string tableName, string columnName, object oldValue, object newValue, int? columnId = null) { throw new System.NotImplementedException(); }
    /// <summary>Remove request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_Remove_System_Int32_System_Int32_Alvao_API_SD_Ticket_RemoveFlags_"/>
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="personId">Person ID (who removes request)(tPerson.iPersonId).</param>
    /// <param name="flags">Flags for special behavior.</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    public static void Remove(int ticketId, int personId, Ticket.RemoveFlags flags = RemoveFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>
    /// Changes request state to resolved.
    /// <example>
    /// <code>
    /// int ticketId = 50; //Request id
    /// int authorId = 40; //Person who resolved the request
    /// Alvao.API.Common.Model.HtmlTextModel message = new Alvao.API.Common.Model.HtmlTextModel("Message in HTML"); //Create message
    /// Alvao.API.SD.Ticket.Resolve(ticketId, authorId, message); //Resolve request
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_Resolve_System_Int32_System_Int32_Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_CostModel_System_Nullable_System_DateTime__Alvao_API_SD_Ticket_ResolveFlags_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="authorPersonId">Person ID (who resolves ticket)(tPerson.iPersonId)</param>
    /// <param name="message">Message for requester</param>
    /// <param name="cost">Resolve costs</param>
    /// <param name="backResolved">Resolve retrospectively to a date (UTC)</param>
    /// <param name="flags">Flags for special behavior.</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId or person with authorPersonId does not exist.</exception>
    /// <exception cref="ValidationException">Throws when not all of its child requests have been closed or request state has changed during process.</exception>
    /// <exception cref="BackResolveException">Throws when backResolved is in future or before date of request creation.</exception>
    /// <returns>Created act ID (tAct.iActId)</returns>
    public static int Resolve(int ticketId, int authorPersonId, HtmlTextModel message, CostModel cost = null, DateTime? backResolved = null, Ticket.ResolveFlags flags = ResolveFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>Restore removed request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_RestoreRemoved_System_Int32_System_Int32_Alvao_API_SD_Ticket_RemoveFlags_"/>
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId).</param>
    /// <param name="personId">Person ID (who restores removed request)(tPerson.iPersonId).</param>
    /// <param name="flags">Flags for special behavior.</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist.</exception>
    public static void RestoreRemoved(int ticketId, int personId, Ticket.RemoveFlags flags = RemoveFlags.None) { throw new System.NotImplementedException(); }
    /// <summary>Allowed columns: mHdTicketNotice, sHdTicketGroup, sHdTicketDeviceCode, sHdTicketUserPhone, mHdTicketUserContact, sHdTicketUserMobile, sHdTicketUserOffice, sHdTicketUserDepartment, sHdTicketUserWorkPosition, sHdTicketUserCompany.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_UpdateColumnValue_System_Int32_System_String_System_String_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId).</param>
    /// <param name="columnName">Specified column name.</param>
    /// <param name="newValue">New column value.</param>
    /// <exception cref="ArgumentException">Throws when ticketId does not exist or columnName is not defined or is forbidden.</exception>
    public static void UpdateColumnValue(int ticketId, string columnName, string newValue) { throw new System.NotImplementedException(); }
    /// <summary>Updates full text search data.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Ticket.html#Alvao_API_SD_Ticket_UpdateFts_System_Int32_"/>
    /// <param name="ticketId">Request ID(tHdTicket.iHdTicketId). If 0, updates all requests.</param>
    public static void UpdateFts(int ticketId) { throw new System.NotImplementedException(); }
}
