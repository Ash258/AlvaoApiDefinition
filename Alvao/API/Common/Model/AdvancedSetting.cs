namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AdvancedSetting.html"/>
public class AdvancedSetting {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AdvancedSetting.html#Alvao_API_Common_Model_AdvancedSetting_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AdvancedSetting.html#Alvao_API_Common_Model_AdvancedSetting_Value"/>
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.AdvancedSetting.html#Alvao_API_Common_Model_AdvancedSetting_GetValue"/>
    public string GetValue() { throw new NotImplementedException(); }
}
