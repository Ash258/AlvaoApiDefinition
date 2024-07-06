using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Approval scheme step.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tApprovalSchemaItem.htm"/>
[TableAttribute("dbo.tApprovalSchemaItem")]
public class tApprovalSchemaItem
{
    /// <summary>"Requester" approval step.</summary>
    public virtual bool AuthorityRequester { get; set; }
    /// <summary>The step is automatically approved by the requester, if he is a member of the selected approval group.</summary>
    public virtual bool AutoApproveByRequester { get; set; }
    /// <summary>The "Requester's direct manager" approval step</summary>
    public virtual bool bApprovalSchemaItemAuthorityManagerOfUser { get; set; }
    public virtual bool bApprovalSchemaItemAuthorityRootManagerOfUser { get; set; }
    [KeyAttribute]
    public virtual int iApprovalSchemaItemId { get; set; }
    public virtual int iApprovalSchemaItemOrder { get; set; }
    public virtual int liApprovalSchemaItemApprovalSchemaId { get; set; }
    public virtual int? liApprovalSchemaItemAuthorityRoleId { get; set; }
    public virtual double? nExpirationHours { get; set; }
    /// <summary>Selection of the approval step "Group" - "only the requester or their manager"</summary>
    public virtual bool OnlyRequesterOrHisManager { get; set; }
    /// <summary>Custom form for "approval/rejection".</summary>
    public virtual string sApprovalSchemaItemCustomUrl { get; set; }
    public virtual string sCustom { get; set; }

    public tApprovalSchemaItem() { }
}
