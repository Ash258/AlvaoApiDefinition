using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of statuses in all used languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketStateLoc.htm"/>
[TableAttribute("dbo.vTicketStateLoc")]
public class vTicketStateLoc
{
    public virtual bool ApprovalAutoStart { get; set; }
    public virtual double? ApprovalExpirationHours { get; set; }
    public virtual int? ApprovalPersonId { get; set; }
    public virtual int? ApprovalSchemaId { get; set; }
    public virtual bool CloseAfterSolution { get; set; }
    public virtual int? CustomField1 { get; set; }
    public virtual string Description { get; set; }
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    public virtual bool DisplayCommandMoveToService { get; set; }
    public virtual int id { get; set; }
    public virtual bool IsApprovalState { get; set; }
    public virtual string LocalizedDescription { get; set; }
    public virtual string LocalizedInstructions { get; set; }
    /// <summary>Localized message template for approvers. If the status does not have a defined custom message template for approvers, the default template is used in the record.</summary>
    public virtual string LocalizedMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    public virtual string LocalizedNotificationForRequesterTemplate { get; set; }
    public virtual string LocalizedState { get; set; }
    public virtual int? OnApprovalStateId { get; set; }
    public virtual int? OnCanceledStateId { get; set; }
    public virtual int? OnExpiredStateId { get; set; }
    public virtual int? OnRejectedStateId { get; set; }
    public virtual int Order { get; set; }
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    public virtual bool SendNotificationForRequester { get; set; }
    public virtual int? SolverGroupRoleId { get; set; }
    public virtual string SolverInstructions { get; set; }
    public virtual string TicketState { get; set; }
    public virtual int TicketStateBehaviorId { get; set; }
    public virtual int TicketStateLocaleId { get; set; }
    public virtual int? TicketTypeId { get; set; }
    public virtual bool TransitToAllStates { get; set; }

    public vTicketStateLoc() { }
}
