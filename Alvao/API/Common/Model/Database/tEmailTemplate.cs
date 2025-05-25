using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates of custom notifications and alerts sent by the ALVAO SAM Assistant module.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html"/>
[Table("dbo.tEmailTemplate")]
public class tEmailTemplate {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_SamAlertRuleId"/>
    public virtual int? SamAlertRuleId { get; set; }
    /// <summary>Kind of alert to sign the handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_TransferConfirmAlertRuleId"/>
    public virtual int? TransferConfirmAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_bActive"/>
    public virtual bool bActive { get; set; }
    /// <summary>Template Id.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_id"/>
    [Key]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_liHdSectionId"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_mSubject"/>
    public virtual string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_mTextBody"/>
    public virtual string mTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tEmailTemplate.html#Alvao_API_Common_Model_Database_tEmailTemplate_sNotificationKind"/>
    public virtual string sNotificationKind { get; set; }
}
