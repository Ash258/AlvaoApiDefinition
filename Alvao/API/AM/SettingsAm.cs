using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping asset management settings methods.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SettingsAm.html"/>
public static class SettingsAm {
    /// <summary>Gets localized asset assignment Notification of returned asset default text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SettingsAm.html#Alvao_API_AM_SettingsAm_AssetAssignmentNotificationOfReturnedAssetDefaultText"/>
    public static string AssetAssignmentNotificationOfReturnedAssetDefaultText() { throw new NotImplementedException(); }
    /// <summary>Gets localized asset assignment Require reception confirmation default text.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SettingsAm.html#Alvao_API_AM_SettingsAm_AssetAssignmentReceptionConfirmationDefaultText"/>
    public static string AssetAssignmentReceptionConfirmationDefaultText() { throw new NotImplementedException(); }
    /// <summary>Gets electronic handover forms config.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SettingsAm.html#Alvao_API_AM_SettingsAm_GetTransferConfirmAlertConfig"/>
    public static TransferConfirmAlertConfig GetTransferConfirmAlertConfig() { throw new NotImplementedException(); }
    /// <summary>Gets all electronic handover forms alert rules.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SettingsAm.html#Alvao_API_AM_SettingsAm_GetTransferConfirmAlertRules"/>
    public static IEnumerable<TransferConfirmAlertRule> GetTransferConfirmAlertRules() { throw new NotImplementedException(); }
}
