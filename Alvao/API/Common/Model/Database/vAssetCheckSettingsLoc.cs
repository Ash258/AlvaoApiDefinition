using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetCheckSettingsLoc.html"/>
[Table("dbo.vAssetCheckSettingsLoc")]
public class vAssetCheckSettingsLoc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetCheckSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetCheckSettingsLoc_AssetCheckSettingsLocaleId"/>
    public virtual int AssetCheckSettingsLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetCheckSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetCheckSettingsLoc_LocalizedConfirmationNotificationSubject"/>
    public virtual string LocalizedConfirmationNotificationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetCheckSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetCheckSettingsLoc_LocalizedConfirmationNotificationText"/>
    public virtual string LocalizedConfirmationNotificationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetCheckSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetCheckSettingsLoc_id"/>
    public virtual byte id { get; set; }
}
