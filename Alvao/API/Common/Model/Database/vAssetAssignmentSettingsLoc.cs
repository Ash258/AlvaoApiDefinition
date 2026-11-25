using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html"/>
[Table("dbo.vAssetAssignmentSettingsLoc")]
public class vAssetAssignmentSettingsLoc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_AssetAsssignmentSettingsLocaleId"/>
    public virtual int AssetAsssignmentSettingsLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_LocalizedNotificationOfReturnedAssetSubject"/>
    public virtual string LocalizedNotificationOfReturnedAssetSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_LocalizedNotificationOfReturnedAssetText"/>
    public virtual string LocalizedNotificationOfReturnedAssetText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_LocalizedReceptionConfirmationSubject"/>
    public virtual string LocalizedReceptionConfirmationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_LocalizedReceptionConfirmationText"/>
    public virtual string LocalizedReceptionConfirmationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vAssetAssignmentSettingsLoc.html#Alvao_API_Common_Model_Database_vAssetAssignmentSettingsLoc_id"/>
    public virtual byte id { get; set; }
}
