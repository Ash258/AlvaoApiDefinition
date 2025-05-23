namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AadSetting.htm"/>
public class AadSetting {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AadSetting_ApplicationId.htm"/>
    public string ApplicationId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AadSetting_Secret.htm"/>
    public string Secret { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AadSetting_TenantId.htm"/>
    public string TenantId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AadSetting__ctor.htm"/>
    public AadSetting() { }
}
