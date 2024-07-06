using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket statuses. Statuses are defined in the process (see dbo.TicketType).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketState.htm"/>
[TableAttribute("dbo.TicketState")]
public class TicketState
{
    /// <summary>State text</summary>
    public virtual string _TicketState { get; set; }
    public virtual bool ApprovalAutoStart { get; set; }
    public virtual double? ApprovalExpirationHours { get; set; }
    public virtual int? ApprovalPersonId { get; set; }
    public virtual int? ApprovalSchemaId { get; set; }
    /// <summary>Automatic closing of ticket after changing to status - value = 1 is only possible in the Solved status.</summary>
    public virtual bool CloseAfterSolution { get; set; }
    public virtual int? CustomField1 { get; set; }
    /// <summary>Custom message template for approvers. If the record has a value of NULL, then the default template is used (available in tString).</summary>
    public virtual string CustomMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    public virtual string CustomNotificationForRequesterTemplate { get; set; }
    public virtual string Description { get; set; }
    /// <summary>In the tickets in this status, display the Assign to solver command first in the Command bar.</summary>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <summary>Display the command "Transfer To Another Service" at the top of the command panel: 0 - off, 1 - on</summary>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual bool IsApprovalState { get; set; }
    public string LocalizedState { get; set; }
    public virtual int? OnApprovalStateId { get; set; }
    public virtual int? OnCanceledStateId { get; set; }
    public virtual int? OnExpiredStateId { get; set; }
    public virtual int? OnRejectedStateId { get; set; }
    public virtual int Order { get; set; }
    /// <summary>SLA is paused at this status</summary>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <summary>Assign ticket to a solver group during transition to this status.</summary>
    public virtual int? SolverGroupRoleId { get; set; }
    public virtual string SolverInstructions { get; set; }
    public virtual int TicketStateBehaviorId { get; set; }
    public virtual int? TicketTypeId { get; set; }
    public virtual bool TransitToAllStates { get; set; }

    public TicketState() { }
}
