using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates of custom notifications and alerts sent by the ALVAO SAM Assistant module.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html"/>
[Table("dbo.tEmailTemplate")]
public class tEmailTemplate {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_SamAlertRuleId"/>
    /// <remarks>Column <c>SamAlertRuleId</c>: int, null. References <see cref="SamAlertRule"/>.</remarks>
    public virtual int? SamAlertRuleId { get; set; }
    /// <summary>Kind of alert to sign the handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_TransferConfirmAlertRuleId"/>
    /// <remarks>
    /// Column <c>TransferConfirmAlertRuleId</c>: int, null. References <see cref="TransferConfirmAlertRule"/>.
    /// </remarks>
    public virtual int? TransferConfirmAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_bActive"/>
    /// <remarks>Column <c>bActive</c>: bit, not null.</remarks>
    public virtual bool bActive { get; set; }
    /// <summary>Template Id.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_liHdSectionId"/>
    /// <remarks>Column <c>liHdSectionId</c>: int, null. References <see cref="tHdSection"/>.</remarks>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_mSubject"/>
    /// <remarks>Column <c>mSubject</c>: nvarchar(max), null.</remarks>
    public virtual string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_mTextBody"/>
    /// <remarks>Column <c>mTextBody</c>: nvarchar(max), null.</remarks>
    public virtual string mTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_sNotificationKind"/>
    /// <remarks>Column <c>sNotificationKind</c>: nvarchar(64), null.</remarks>
    public virtual string sNotificationKind { get; set; }
}
