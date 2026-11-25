namespace Alvao.API.AM.Model.AssetSettings;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetSettings.MessageModel.html"/>
public class MessageModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetSettings.MessageModel.html#Alvao_API_AM_Model_AssetSettings_MessageModel_MyAsset"/>
    public required string MyAsset { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetSettings.MessageModel.html#Alvao_API_AM_Model_AssetSettings_MessageModel_Subject"/>
    public required string Subject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetSettings.MessageModel.html#Alvao_API_AM_Model_AssetSettings_MessageModel_Text"/>
    public required string Text { get; set; }
}
