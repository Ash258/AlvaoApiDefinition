using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html"/>
[Table("dbo.AssetAssignmentSettings")]
public class AssetAssignmentSettings {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ConfirmationPrintReportTemplateId"/>
    /// <remarks>
    /// Column <c>ConfirmationPrintReportTemplateId</c>: int, null. References <see cref="PrintReportTemplate"/>.
    /// </remarks>
    public virtual int? ConfirmationPrintReportTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_GeneratePdfByConfirmation"/>
    /// <remarks>Column <c>GeneratePdfByConfirmation</c>: bit, not null.</remarks>
    public virtual bool GeneratePdfByConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetPrintReportTemplateId"/>
    /// <remarks>
    /// Column <c>NotificationOfReturnedAssetPrintReportTemplateId</c>: int, null. References <see
    /// cref="PrintReportTemplate"/>.
    /// </remarks>
    public virtual int? NotificationOfReturnedAssetPrintReportTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetSubject"/>
    /// <remarks>Column <c>NotificationOfReturnedAssetSubject</c>: nvarchar(255), null.</remarks>
    public virtual string NotificationOfReturnedAssetSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_NotificationOfReturnedAssetText"/>
    /// <remarks>Column <c>NotificationOfReturnedAssetText</c>: nvarchar(max), null.</remarks>
    public virtual string NotificationOfReturnedAssetText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ReceptionConfirmationSubject"/>
    /// <remarks>Column <c>ReceptionConfirmationSubject</c>: nvarchar(255), null.</remarks>
    public virtual string ReceptionConfirmationSubject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_ReceptionConfirmationText"/>
    /// <remarks>Column <c>ReceptionConfirmationText</c>: nvarchar(max), null.</remarks>
    public virtual string ReceptionConfirmationText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_RequireReceptionConfirmation"/>
    /// <remarks>Column <c>RequireReceptionConfirmation</c>: bit, not null.</remarks>
    public virtual bool RequireReceptionConfirmation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_SendNotificationOfReturnedAsset"/>
    /// <remarks>Column <c>SendNotificationOfReturnedAsset</c>: bit, not null.</remarks>
    public virtual bool SendNotificationOfReturnedAsset { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AssetAssignmentSettings.html#Alvao_API_Common_Model_Database_AssetAssignmentSettings_id"/>
    /// <remarks>Column <c>id</c>: tinyint, not null.</remarks>
    [ExplicitKey]
    public virtual byte id { get; set; }
}
