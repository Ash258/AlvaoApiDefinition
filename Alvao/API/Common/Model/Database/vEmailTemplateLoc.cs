using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of custom notifications in all languages ​​used.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vEmailTemplateLoc.htm"/>
[TableAttribute("dbo.vEmailTemplateLoc")]
public class vEmailTemplateLoc
{
    public virtual bool bActive { get; set; }
    public virtual int EmailTemplateLocaleId { get; set; }
    public virtual int id { get; set; }
    public virtual int? liHdSectionId { get; set; }
    public virtual string LocalizedSubject { get; set; }
    public virtual string LocalizedTextBody { get; set; }
    public virtual string mSubject { get; set; }
    public virtual string mTextBody { get; set; }
    public virtual int? SamAlertRuleId { get; set; }
    public virtual string sNotificationKind { get; set; }
    public virtual int? TransferConfirmAlertRuleId { get; set; }

    public vEmailTemplateLoc() { }
}
