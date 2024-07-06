using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Templates of custom notifications and alerts sent by the ALVAO SAM Assistant module.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tEmailTemplate.htm"/>
[TableAttribute("dbo.tEmailTemplate")]
public class tEmailTemplate
{
    public virtual bool bActive { get; set; }
    /// <summary>Template Id.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int? liHdSectionId { get; set; }
    public virtual string mSubject { get; set; }
    public virtual string mTextBody { get; set; }
    public virtual int? SamAlertRuleId { get; set; }
    public virtual string sNotificationKind { get; set; }
    /// <summary>Kind of alert to sign the handover protocol.</summary>
    public virtual int? TransferConfirmAlertRuleId { get; set; }

    public tEmailTemplate() { }
}
