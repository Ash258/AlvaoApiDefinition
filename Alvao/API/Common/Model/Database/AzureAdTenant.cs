using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table of Azure Active Directory tenants from which users are imported.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html"/>
[Table("dbo.AzureAdTenant")]
public class AzureAdTenant {
    /// <summary>Automatic replies are imported from MS Outlook.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_AutomaticReplies"/>
    public virtual bool AutomaticReplies { get; set; }
    /// <summary>Folder ID in Azure</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_AzureTenantId"/>
    public virtual string AzureTenantId { get; set; }
    /// <summary>Calendars are imported from MS Outlook.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Calendar"/>
    public virtual bool Calendar { get; set; }
    /// <summary>User objects are imported.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ImportUserObjects"/>
    public virtual bool ImportUserObjects { get; set; }
    /// <summary>Devices are imported from Intune.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Intune"/>
    public virtual bool Intune { get; set; }
    /// <summary>Enable vector index for Knowledge Base with SharePoint files.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_KnowledgeBaseSharepointIndex"/>
    public virtual bool KnowledgeBaseSharepointIndex { get; set; }
    /// <summary>Licenses are imported from Microsoft 365.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_M365Licenses"/>
    public virtual bool M365Licenses { get; set; }
    /// <summary>Tenant name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Hash of the secret token for SCIM.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHash"/>
    public virtual string ScimSecretTokenHash { get; set; }
    /// <summary>Date of the last SCIM token hash generation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHashLastGenerated"/>
    public virtual DateTime? ScimSecretTokenHashLastGenerated { get; set; }
    /// <summary>Shifts are imported from MS Teams.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Shifts"/>
    public virtual bool Shifts { get; set; }
    /// <summary>Use organizational structure.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UseOrganizationStructure"/>
    public virtual bool UseOrganizationStructure { get; set; }
    /// <summary>User portraits are imported from Entra.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPortraits"/>
    public virtual bool UserPortraits { get; set; }
    /// <summary>User presence is imported from Entra.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPresence"/>
    public virtual bool UserPresence { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_id"/>
    [Key]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant__ctor"/>
    public AzureAdTenant() { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_GetSettingByFeature_Alvao_API_Common_MSEntraTenant_Feature_"/>
    public bool GetSettingByFeature(MSEntraTenant.Feature feature) { throw new NotImplementedException(); }
}
