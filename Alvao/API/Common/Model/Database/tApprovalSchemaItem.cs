using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Approval scheme step.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html"/>
[Table("dbo.tApprovalSchemaItem")]
public class tApprovalSchemaItem {
    /// <summary>&quot;Requester&quot; approval step.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_AuthorityRequester"/>
    /// <remarks>Column <c>AuthorityRequester</c>: bit, not null.</remarks>
    public virtual bool AuthorityRequester { get; set; }
    /// <summary>
    /// The step is automatically approved by the requester, if he is a member of the selected approval group.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_AutoApproveByRequester"/>
    /// <remarks>Column <c>AutoApproveByRequester</c>: bit, not null.</remarks>
    public virtual bool AutoApproveByRequester { get; set; }
    /// <summary>
    /// Selection of the approval step &quot;Group&quot; - &quot;only the requester or their manager&quot;
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_OnlyRequesterOrHisManager"/>
    /// <remarks>Column <c>OnlyRequesterOrHisManager</c>: bit, not null.</remarks>
    public virtual bool OnlyRequesterOrHisManager { get; set; }
    /// <summary>The &quot;Requester's direct manager&quot; approval step</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityManagerOfUser"/>
    /// <remarks>Column <c>bApprovalSchemaItemAuthorityManagerOfUser</c>: bit, not null.</remarks>
    public virtual bool bApprovalSchemaItemAuthorityManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_bApprovalSchemaItemAuthorityRootManagerOfUser"/>
    /// <remarks>Column <c>bApprovalSchemaItemAuthorityRootManagerOfUser</c>: bit, not null.</remarks>
    public virtual bool bApprovalSchemaItemAuthorityRootManagerOfUser { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemId"/>
    /// <remarks>Column <c>iApprovalSchemaItemId</c>: int, not null.</remarks>
    [Key]
    public virtual int iApprovalSchemaItemId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_iApprovalSchemaItemOrder"/>
    /// <remarks>Column <c>iApprovalSchemaItemOrder</c>: int, not null.</remarks>
    public virtual int iApprovalSchemaItemOrder { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemApprovalSchemaId"/>
    /// <remarks>
    /// Column <c>liApprovalSchemaItemApprovalSchemaId</c>: int, not null. References <see cref="tApprovalSchema"/>.
    /// </remarks>
    public virtual int liApprovalSchemaItemApprovalSchemaId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_liApprovalSchemaItemAuthorityRoleId"/>
    /// <remarks>Column <c>liApprovalSchemaItemAuthorityRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? liApprovalSchemaItemAuthorityRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_nExpirationHours"/>
    /// <remarks>Column <c>nExpirationHours</c>: float, null.</remarks>
    public virtual double? nExpirationHours { get; set; }
    /// <summary>Custom form for &quot;approval/rejection&quot;.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_sApprovalSchemaItemCustomUrl"/>
    /// <remarks>Column <c>sApprovalSchemaItemCustomUrl</c>: nvarchar(max), null.</remarks>
    public virtual string sApprovalSchemaItemCustomUrl { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tApprovalSchemaItem.html#Alvao_API_Common_Model_Database_tApprovalSchemaItem_sCustom"/>
    /// <remarks>Column <c>sCustom</c>: nvarchar(255), null.</remarks>
    public virtual string sCustom { get; set; }
}
