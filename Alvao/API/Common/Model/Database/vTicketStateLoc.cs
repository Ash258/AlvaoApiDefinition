using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of statuses in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html"/>
[Table("dbo.vTicketStateLoc")]
public class vTicketStateLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalAutoStart"/>
    public virtual bool ApprovalAutoStart { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalExpirationHours"/>
    public virtual double? ApprovalExpirationHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalPersonId"/>
    public virtual int? ApprovalPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_ApprovalSchemaId"/>
    public virtual int? ApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_CloseAfterSolution"/>
    public virtual bool CloseAfterSolution { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_DisplayCommandAssignToSolver"/>
    public virtual bool DisplayCommandAssignToSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_DisplayCommandMoveToService"/>
    public virtual bool DisplayCommandMoveToService { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_DisplayCommandNewObject"/>
    public virtual bool DisplayCommandNewObject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_IsApprovalState"/>
    public virtual bool IsApprovalState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedDescription"/>
    public virtual string LocalizedDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedInstructions"/>
    public virtual string LocalizedInstructions { get; set; }
    /// <summary>Localized message template for approvers. If the status does not have a defined custom message template for approvers, the default template is used in the record.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedMessageForApproverTemplate"/>
    public virtual string LocalizedMessageForApproverTemplate { get; set; }
    /// <summary>Custom template of notifications to requester about change of the ticket status. If the record has a value of NULL, then the default template is used (saved in tString).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedNotificationForRequesterTemplate"/>
    public virtual string LocalizedNotificationForRequesterTemplate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_LocalizedState"/>
    public virtual string LocalizedState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_OnApprovalStateId"/>
    public virtual int? OnApprovalStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_OnCanceledStateId"/>
    public virtual int? OnCanceledStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_OnExpiredStateId"/>
    public virtual int? OnExpiredStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_OnRejectedStateId"/>
    public virtual int? OnRejectedStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_Order"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_PauseSla"/>
    public virtual bool PauseSla { get; set; }
    /// <summary>Date of status deletion. If the value is NULL here, the status was not deleted.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Send a notification to the requester when transitioning to status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_SendNotificationForRequester"/>
    public virtual bool SendNotificationForRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_SolverGroupRoleId"/>
    public virtual int? SolverGroupRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_SolverInstructions"/>
    public virtual string SolverInstructions { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_TicketState"/>
    public virtual string TicketState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_TicketStateBehaviorId"/>
    public virtual int TicketStateBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_TicketStateLocaleId"/>
    public virtual int TicketStateLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_TicketTypeId"/>
    public virtual int? TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_TransitToAllStates"/>
    public virtual bool TransitToAllStates { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateLoc.html#Alvao_API_Common_Model_Database_vTicketStateLoc_id"/>
    public virtual int id { get; set; }
}
