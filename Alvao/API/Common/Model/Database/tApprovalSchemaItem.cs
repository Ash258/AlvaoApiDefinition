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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_AuthorityRequester.htm"/>
    public virtual bool AuthorityRequester { get; set; }
    /// <summary>The step is automatically approved by the requester, if he is a member of the selected approval group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_AutoApproveByRequester.htm"/>
    public virtual bool AutoApproveByRequester { get; set; }
    /// <summary>The "Requester's direct manager" approval step</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityManagerOfUser.htm"/>
    public virtual bool bApprovalSchemaItemAuthorityManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityRootManagerOfUser.htm"/>
    public virtual bool bApprovalSchemaItemAuthorityRootManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemId.htm"/>
    [KeyAttribute]
    public virtual int iApprovalSchemaItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemOrder.htm"/>
    public virtual int iApprovalSchemaItemOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemApprovalSchemaId.htm"/>
    public virtual int liApprovalSchemaItemApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemAuthorityRoleId.htm"/>
    public virtual int? liApprovalSchemaItemAuthorityRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_nExpirationHours.htm"/>
    public virtual double? nExpirationHours { get; set; }
    /// <summary>Selection of the approval step "Group" - "only the requester or their manager"</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_OnlyRequesterOrHisManager.htm"/>
    public virtual bool OnlyRequesterOrHisManager { get; set; }
    /// <summary>Custom form for "approval/rejection".</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_sApprovalSchemaItemCustomUrl.htm"/>
    public virtual string sApprovalSchemaItemCustomUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tApprovalSchemaItem_sCustom.htm"/>
    public virtual string sCustom { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tApprovalSchemaItem__ctor.htm"/>
    public tApprovalSchemaItem() { }
}
