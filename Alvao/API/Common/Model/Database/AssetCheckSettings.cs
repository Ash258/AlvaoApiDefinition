using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html"/>
[Table("dbo.AssetCheckSettings")]
public class AssetCheckSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_AssetConfirmationByResponsibleUsers"/>
    public virtual bool AssetConfirmationByResponsibleUsers { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_ConfirmationNotificationSubject"/>
    public virtual string ConfirmationNotificationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_ConfirmationNotificationText"/>
    public virtual string ConfirmationNotificationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_SendNotificationForConfirmation"/>
    public virtual bool SendNotificationForConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_id"/>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
