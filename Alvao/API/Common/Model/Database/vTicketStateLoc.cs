using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of statuses in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketStateLoc.htm"/>
[TableAttribute("dbo.vTicketStateLoc")]
public class vTicketStateLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalAutoStart.htm"/>
    public virtual bool ApprovalAutoStart { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalExpirationHours.htm"/>
    public virtual double? ApprovalExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalPersonId.htm"/>
    public virtual int? ApprovalPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalSchemaId.htm"/>
    public virtual int? ApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_CloseAfterSolution.htm"/>
    public virtual bool CloseAfterSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_CustomField1.htm"/>
    public virtual int? CustomField1 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_Description.htm"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_DisplayCommandAssignToSolver.htm"/>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_DisplayCommandMoveToService.htm"/>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_IsApprovalState.htm"/>
    public virtual bool IsApprovalState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedDescription.htm"/>
    public virtual string LocalizedDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedInstructions.htm"/>
    public virtual string LocalizedInstructions { get; set; }
    /// <summary>Localized message template for approvers. If the status does not have a defined custom message template for approvers, the default template is used in the record.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedMessageForApproverTemplate.htm"/>
    public virtual string LocalizedMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedNotificationForRequesterTemplate.htm"/>
    public virtual string LocalizedNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedState.htm"/>
    public virtual string LocalizedState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_OnApprovalStateId.htm"/>
    public virtual int? OnApprovalStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_OnCanceledStateId.htm"/>
    public virtual int? OnCanceledStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_OnExpiredStateId.htm"/>
    public virtual int? OnExpiredStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_OnRejectedStateId.htm"/>
    public virtual int? OnRejectedStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_Order.htm"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_PauseSla.htm"/>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_SendNotificationForRequester.htm"/>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_SolverGroupRoleId.htm"/>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_SolverInstructions.htm"/>
    public virtual string SolverInstructions { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_TicketState.htm"/>
    public virtual string TicketState { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_TicketStateBehaviorId.htm"/>
    public virtual int TicketStateBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_TicketStateLocaleId.htm"/>
    public virtual int TicketStateLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_TicketTypeId.htm"/>
    public virtual int? TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketStateLoc_TransitToAllStates.htm"/>
    public virtual bool TransitToAllStates { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vTicketStateLoc__ctor.htm"/>
    public vTicketStateLoc() { }
}
