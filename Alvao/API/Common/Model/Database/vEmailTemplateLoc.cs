using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom notifications in all languages ​​used.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vEmailTemplateLoc.htm"/>
[TableAttribute("dbo.vEmailTemplateLoc")]
public class vEmailTemplateLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_bActive.htm"/>
    public virtual bool bActive { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_EmailTemplateLocaleId.htm"/>
    public virtual int EmailTemplateLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_liHdSectionId.htm"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_LocalizedSubject.htm"/>
    public virtual string LocalizedSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_LocalizedTextBody.htm"/>
    public virtual string LocalizedTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_mSubject.htm"/>
    public virtual string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_mTextBody.htm"/>
    public virtual string mTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_SamAlertRuleId.htm"/>
    public virtual int? SamAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_sNotificationKind.htm"/>
    public virtual string sNotificationKind { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vEmailTemplateLoc_TransferConfirmAlertRuleId.htm"/>
    public virtual int? TransferConfirmAlertRuleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vEmailTemplateLoc__ctor.htm"/>
    public vEmailTemplateLoc() { }
}
