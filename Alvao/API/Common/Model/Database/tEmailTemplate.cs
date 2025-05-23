using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Templates of custom notifications and alerts sent by the ALVAO SAM Assistant module.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tEmailTemplate.htm"/>
[TableAttribute("dbo.tEmailTemplate")]
public class tEmailTemplate {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_bActive.htm"/>
    public virtual bool bActive { get; set; }
    /// <summary>Template Id.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_liHdSectionId.htm"/>
    public virtual int? liHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_mSubject.htm"/>
    public virtual string mSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_mTextBody.htm"/>
    public virtual string mTextBody { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_SamAlertRuleId.htm"/>
    public virtual int? SamAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_sNotificationKind.htm"/>
    public virtual string sNotificationKind { get; set; }
    /// <summary>Kind of alert to sign the handover protocol.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tEmailTemplate_TransferConfirmAlertRuleId.htm"/>
    public virtual int? TransferConfirmAlertRuleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tEmailTemplate__ctor.htm"/>
    public tEmailTemplate() { }
}
