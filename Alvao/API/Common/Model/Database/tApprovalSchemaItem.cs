using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Approval scheme step.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html"/>
[Table("dbo.tApprovalSchemaItem")]
public class tApprovalSchemaItem {
    /// <summary>&quot;Requester&quot; approval step.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_AuthorityRequester"/>
    public virtual bool AuthorityRequester { get; set; }
    /// <summary>The step is automatically approved by the requester, if he is a member of the selected approval group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_AutoApproveByRequester"/>
    public virtual bool AutoApproveByRequester { get; set; }
    /// <summary>Selection of the approval step &quot;Group&quot; - &quot;only the requester or their manager&quot;</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_OnlyRequesterOrHisManager"/>
    public virtual bool OnlyRequesterOrHisManager { get; set; }
    /// <summary>The &quot;Requester's direct manager&quot; approval step</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityManagerOfUser"/>
    public virtual bool bApprovalSchemaItemAuthorityManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityRootManagerOfUser"/>
    public virtual bool bApprovalSchemaItemAuthorityRootManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemId"/>
    [Key]
    public virtual int iApprovalSchemaItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemOrder"/>
    public virtual int iApprovalSchemaItemOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemApprovalSchemaId"/>
    public virtual int liApprovalSchemaItemApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemAuthorityRoleId"/>
    public virtual int? liApprovalSchemaItemAuthorityRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_nExpirationHours"/>
    public virtual double? nExpirationHours { get; set; }
    /// <summary>Custom form for &quot;approval/rejection&quot;.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_sApprovalSchemaItemCustomUrl"/>
    public virtual string sApprovalSchemaItemCustomUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_sCustom"/>
    public virtual string sCustom { get; set; }
}
