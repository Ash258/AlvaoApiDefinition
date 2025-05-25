using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom notifications in all languages ââused.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html"/>
[Table("dbo.vEmailTemplateLoc")]
public class vEmailTemplateLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_EmailTemplateLocaleId"/>
    public virtual int EmailTemplateLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_LocalizedSubject"/>
    public virtual string LocalizedSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_LocalizedTextBody"/>
    public virtual string LocalizedTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_SamAlertRuleId"/>
    public virtual int? SamAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_TransferConfirmAlertRuleId"/>
    public virtual int? TransferConfirmAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_bActive"/>
    public virtual bool bActive { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_id"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_liHdSectionId"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_mSubject"/>
    public virtual string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_mTextBody"/>
    public virtual string mTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vEmailTemplateLoc.html#Alvao_API_Common_Model_Database_vEmailTemplateLoc_sNotificationKind"/>
    public virtual string sNotificationKind { get; set; }
}
