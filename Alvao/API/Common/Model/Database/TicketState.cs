using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket statuses. Statuses are defined in the process (see dbo.TicketType).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html"/>
[Table("dbo.TicketState")]
public class TicketState {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalAutoStart"/>
    public virtual bool ApprovalAutoStart { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalExpirationHours"/>
    public virtual double? ApprovalExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalPersonId"/>
    public virtual int? ApprovalPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_ApprovalSchemaId"/>
    public virtual int? ApprovalSchemaId { get; set; }
    /// <summary>Automatic closing of ticket after changing to status - value = 1 is only possible in the Solved status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CloseAfterSolution"/>
    public virtual bool CloseAfterSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Custom message template for approvers. If the record has a value of NULL, then the default template is used (available in tString).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomMessageForApproverTemplate"/>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_CustomNotificationForRequesterTemplate"/>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Description"/>
    public virtual string Description { get; set; }
    /// <summary>In the tickets in this status, display the Assign to solver command first in the Command bar.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandAssignToSolver"/>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <summary>Display the command &quot;Transfer To Another Service&quot; at the top of the command panel: 0 - off, 1 - on</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_DisplayCommandMoveToService"/>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_IsApprovalState"/>
    public virtual bool IsApprovalState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_LocalizedState"/>
    public string LocalizedState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnApprovalStateId"/>
    public virtual int? OnApprovalStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnCanceledStateId"/>
    public virtual int? OnCanceledStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnExpiredStateId"/>
    public virtual int? OnExpiredStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_OnRejectedStateId"/>
    public virtual int? OnRejectedStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Order"/>
    public virtual int Order { get; set; }
    /// <summary>SLA is paused at this status</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_PauseSla"/>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SendNotificationForRequester"/>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <summary>Assign ticket to a solver group during transition to this status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SolverGroupRoleId"/>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_SolverInstructions"/>
    public virtual string SolverInstructions { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TicketStateBehaviorId"/>
    public virtual int TicketStateBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TicketTypeId"/>
    public virtual int? TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_TransitToAllStates"/>
    public virtual bool TransitToAllStates { get; set; }
    /// <summary>State text</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState__TicketState"/>
    public virtual string _TicketState { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketState.html#Alvao_API_Common_Model_Database_TicketState_id"/>
    [Key]
    public virtual int id { get; set; }
}
