using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket statuses. Statuses are defined in the process (see dbo.TicketType).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html"/>
[Table("dbo.TicketState")]
public class TicketState {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalAutoStart"/>
    /// <remarks>Column <c>ApprovalAutoStart</c>: bit, not null.</remarks>
    public virtual bool ApprovalAutoStart { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalExpirationHours"/>
    /// <remarks>Column <c>ApprovalExpirationHours</c>: float, null.</remarks>
    public virtual double? ApprovalExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalPersonId"/>
    /// <remarks>Column <c>ApprovalPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? ApprovalPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalSchemaId"/>
    /// <remarks>Column <c>ApprovalSchemaId</c>: int, null. References <see cref="tApprovalSchema"/>.</remarks>
    public virtual int? ApprovalSchemaId { get; set; }
    /// <summary>
    /// Automatic closing of ticket after changing to status - value = 1 is only possible in the Solved status.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CloseAfterSolution"/>
    /// <remarks>Column <c>CloseAfterSolution</c>: bit, not null.</remarks>
    public virtual bool CloseAfterSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomField1"/>
    /// <remarks>Column <c>CustomField1</c>: int, null.</remarks>
    public virtual int? CustomField1 { get; set; }
    /// <summary>
    /// Custom message template for approvers. If the record has a value of NULL, then the default template is used
    /// (available in tString).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomMessageForApproverTemplate"/>
    /// <remarks>Column <c>CustomMessageForApproverTemplate</c>: nvarchar(max), null.</remarks>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>
    /// Custom template of notifications to requester about change of the ticket status. If the record has a value of
    /// NULL, then the default template is used (saved in tString).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomNotificationForRequesterTemplate"/>
    /// <remarks>Column <c>CustomNotificationForRequesterTemplate</c>: nvarchar(max), null.</remarks>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Description"/>
    /// <remarks>Column <c>Description</c>: nvarchar(max), null.</remarks>
    public virtual string Description { get; set; }
    /// <summary>In the tickets in this status, display the Assign to solver command first in the Command bar.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandAssignToSolver"/>
    /// <remarks>Column <c>DisplayCommandAssignToSolver</c>: bit, not null.</remarks>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <summary>Display the command &quot;Move objects&quot; at the top of the command panel: 0 - off, 1 - on</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandMoveObjects"/>
    /// <remarks>Column <c>DisplayCommandMoveObjects</c>: bit, not null.</remarks>
    public virtual bool DisplayCommandMoveObjects { get; set; }
    /// <summary>
    /// Display the command &quot;Transfer To Another Service&quot; at the top of the command panel: 0 - off, 1 - on
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandMoveToService"/>
    /// <remarks>Column <c>DisplayCommandMoveToService</c>: bit, not null.</remarks>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <summary>Display the command &quot;New object&quot; at the top of the command panel: 0 - off, 1 - on</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandNewObject"/>
    /// <remarks>Column <c>DisplayCommandNewObject</c>: bit, not null.</remarks>
    public virtual bool DisplayCommandNewObject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_IsApprovalState"/>
    /// <remarks>Column <c>IsApprovalState</c>: bit, not null.</remarks>
    public virtual bool IsApprovalState { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_LocalizedMessageForApproverTemplate"/>
    public string LocalizedMessageForApproverTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_LocalizedNotificationForRequesterTemplate"/>
    public string LocalizedNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_LocalizedState"/>
    public string LocalizedState { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnApprovalStateId"/>
    /// <remarks>Column <c>OnApprovalStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? OnApprovalStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnCanceledStateId"/>
    /// <remarks>Column <c>OnCanceledStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? OnCanceledStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnExpiredStateId"/>
    /// <remarks>Column <c>OnExpiredStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? OnExpiredStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnRejectedStateId"/>
    /// <remarks>Column <c>OnRejectedStateId</c>: int, null. References <see cref="TicketState"/>.</remarks>
    public virtual int? OnRejectedStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>SLA is paused at this status</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_PauseSla"/>
    /// <remarks>Column <c>PauseSla</c>: bit, not null.</remarks>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SendNotificationForRequester"/>
    /// <remarks>Column <c>SendNotificationForRequester</c>: bit, not null.</remarks>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <summary>Assign ticket to a solver group during transition to this status.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SolverGroupRoleId"/>
    /// <remarks>Column <c>SolverGroupRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SolverInstructions"/>
    /// <remarks>Column <c>SolverInstructions</c>: nvarchar(max), null.</remarks>
    public virtual string SolverInstructions { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TicketStateBehaviorId"/>
    /// <remarks>
    /// Column <c>TicketStateBehaviorId</c>: int, not null. References <see cref="TicketStateBehavior"/>.
    /// </remarks>
    public virtual int TicketStateBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TicketTypeId"/>
    /// <remarks>Column <c>TicketTypeId</c>: int, null. References <see cref="TicketType"/>.</remarks>
    public virtual int? TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TransitToAllStates"/>
    /// <remarks>Column <c>TransitToAllStates</c>: bit, not null.</remarks>
    public virtual bool TransitToAllStates { get; set; }
    /// <summary>State text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState__TicketState"/>
    public virtual string _TicketState { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
