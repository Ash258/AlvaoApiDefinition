using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table of Azure Active Directory tenants from which users are imported.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html"/>
[Table("dbo.AzureAdTenant")]
public class AzureAdTenant {
    /// <summary>Folder ID in Azure</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_AzureTenantId"/>
    public virtual string AzureTenantId { get; set; }
    /// <summary>Devices are imported from Intune.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Intune"/>
    public virtual bool Intune { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHash"/>
    public virtual string ScimSecretTokenHash { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHashLastGenerated"/>
    public virtual DateTime? ScimSecretTokenHashLastGenerated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPortraits"/>
    public virtual bool UserPortraits { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPresence"/>
    public virtual bool UserPresence { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_id"/>
    [Key]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_GetSettingByFeature_Alvao_API_Common_MSEntraTenant_Feature_"/>
    public bool GetSettingByFeature(MSEntraTenant.Feature feature) { throw new NotImplementedException(); }
}
