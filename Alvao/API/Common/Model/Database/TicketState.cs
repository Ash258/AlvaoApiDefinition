using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket statuses. Statuses are defined in the process (see dbo.TicketType).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketState.htm"/>
[TableAttribute("dbo.TicketState")]
public class TicketState
{
    /// <summary>State text</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState__TicketState.htm"/>
    public virtual string _TicketState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_ApprovalAutoStart.htm"/>
    public virtual bool ApprovalAutoStart { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_ApprovalExpirationHours.htm"/>
    public virtual double? ApprovalExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_ApprovalPersonId.htm"/>
    public virtual int? ApprovalPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_ApprovalSchemaId.htm"/>
    public virtual int? ApprovalSchemaId { get; set; }
    /// <summary>Automatic closing of ticket after changing to status - value = 1 is only possible in the Solved status.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_CloseAfterSolution.htm"/>
    public virtual bool CloseAfterSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_CustomField1.htm"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Custom message template for approvers. If the record has a value of NULL, then the default template is used (available in tString).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_CustomMessageForApproverTemplate.htm"/>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_CustomNotificationForRequesterTemplate.htm"/>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>In the tickets in this status, display the Assign to solver command first in the Command bar.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_DisplayCommandAssignToSolver.htm"/>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <summary>Display the command "Transfer To Another Service" at the top of the command panel: 0 - off, 1 - on</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_DisplayCommandMoveToService.htm"/>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_IsApprovalState.htm"/>
    public virtual bool IsApprovalState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_LocalizedState.htm"/>
    public string LocalizedState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_OnApprovalStateId.htm"/>
    public virtual int? OnApprovalStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_OnCanceledStateId.htm"/>
    public virtual int? OnCanceledStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_OnExpiredStateId.htm"/>
    public virtual int? OnExpiredStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_OnRejectedStateId.htm"/>
    public virtual int? OnRejectedStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_Order.htm"/>
    public virtual int Order { get; set; }
    /// <summary>SLA is paused at this status</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_PauseSla.htm"/>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_SendNotificationForRequester.htm"/>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <summary>Assign ticket to a solver group during transition to this status.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_SolverGroupRoleId.htm"/>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_SolverInstructions.htm"/>
    public virtual string SolverInstructions { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_TicketStateBehaviorId.htm"/>
    public virtual int TicketStateBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_TicketTypeId.htm"/>
    public virtual int? TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketState_TransitToAllStates.htm"/>
    public virtual bool TransitToAllStates { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketState__ctor.htm"/>
    public TicketState() { }
}
