namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetAssignmentSettingModel.html"/>
public class AssetAssignmentSettingModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetAssignmentSettingModel.html#Alvao_API_AM_Model_AssetAssignmentSettingModel_CommentForRecipient"/>
    public const string CommentForRecipient = "[$CommentForRecipient$]";
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetAssignmentSettingModel.html#Alvao_API_AM_Model_AssetAssignmentSettingModel_MyAssetPageUrl"/>
    public const string MyAssetPageUrl = "[$MyAssetPageUrl$]";

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetAssignmentSettingModel.html#Alvao_API_AM_Model_AssetAssignmentSettingModel_AutoSend"/>
    public bool AutoSend { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.AssetAssignmentSettingModel.html#Alvao_API_AM_Model_AssetAssignmentSettingModel_UserConfirm"/>
    public bool UserConfirm { get; set; }
}
