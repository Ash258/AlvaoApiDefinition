using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html"/>
[Table("dbo.AssetAssignmentSettings")]
public class AssetAssignmentSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ConfirmationPrintReportTemplateId"/>
    public virtual int? ConfirmationPrintReportTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_GeneratePdfByConfirmation"/>
    public virtual bool GeneratePdfByConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetPrintReportTemplateId"/>
    public virtual int? NotificationOfReturnedAssetPrintReportTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetSubject"/>
    public virtual string NotificationOfReturnedAssetSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetText"/>
    public virtual string NotificationOfReturnedAssetText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ReceptionConfirmationSubject"/>
    public virtual string ReceptionConfirmationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ReceptionConfirmationText"/>
    public virtual string ReceptionConfirmationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_RequireReceptionConfirmation"/>
    public virtual bool RequireReceptionConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_SendNotificationOfReturnedAsset"/>
    public virtual bool SendNotificationOfReturnedAsset { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_id"/>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
