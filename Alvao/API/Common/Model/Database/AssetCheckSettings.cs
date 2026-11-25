using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html"/>
[Table("dbo.AssetCheckSettings")]
public class AssetCheckSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_AssetConfirmationByResponsibleUsers"/>
    /// <remarks>Column <c>AssetConfirmationByResponsibleUsers</c>: bit, not null.</remarks>
    public virtual bool AssetConfirmationByResponsibleUsers { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_ConfirmationNotificationSubject"/>
    /// <remarks>Column <c>ConfirmationNotificationSubject</c>: nvarchar(255), null.</remarks>
    public virtual string ConfirmationNotificationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_ConfirmationNotificationText"/>
    /// <remarks>Column <c>ConfirmationNotificationText</c>: nvarchar(max), null.</remarks>
    public virtual string ConfirmationNotificationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_SendNotificationForConfirmation"/>
    /// <remarks>Column <c>SendNotificationForConfirmation</c>: bit, not null.</remarks>
    public virtual bool SendNotificationForConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetCheckSettings.html#Alvao_API_Common_Model_Database_AssetCheckSettings_id"/>
    /// <remarks>Column <c>id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
