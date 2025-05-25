namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AadSetting.html"/>
public class AadSetting {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AadSetting.html#Alvao_API_Common_Model_AadSetting_ApplicationId"/>
    public string ApplicationId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AadSetting.html#Alvao_API_Common_Model_AadSetting_Secret"/>
    public string Secret { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.AadSetting.html#Alvao_API_Common_Model_AadSetting_TenantId"/>
    public string TenantId { get; set; }
}
