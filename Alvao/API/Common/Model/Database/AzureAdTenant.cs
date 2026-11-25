using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table of Azure Active Directory tenants from which users are imported.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html"/>
[Table("dbo.AzureAdTenant")]
public class AzureAdTenant {
    /// <summary>Automatic replies are imported from MS Outlook.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_AutomaticReplies"/>
    /// <remarks>Column <c>AutomaticReplies</c>: bit, not null.</remarks>
    public virtual bool AutomaticReplies { get; set; }
    /// <summary>Folder ID in Azure</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_AzureTenantId"/>
    /// <remarks>Column <c>AzureTenantId</c>: nvarchar(40), not null.</remarks>
    public virtual string AzureTenantId { get; set; }
    /// <summary>Calendars are imported from MS Outlook.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Calendar"/>
    /// <remarks>Column <c>Calendar</c>: bit, not null.</remarks>
    public virtual bool Calendar { get; set; }
    /// <summary>User objects are imported.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ImportUserObjects"/>
    /// <remarks>Column <c>ImportUserObjects</c>: bit, not null.</remarks>
    public virtual bool ImportUserObjects { get; set; }
    /// <summary>Devices are imported from Intune.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Intune"/>
    /// <remarks>Column <c>Intune</c>: bit, not null.</remarks>
    public virtual bool Intune { get; set; }
    /// <summary>Enable vector index for Knowledge Base with SharePoint files.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_KnowledgeBaseSharepointIndex"/>
    /// <remarks>Column <c>KnowledgeBaseSharepointIndex</c>: bit, not null.</remarks>
    public virtual bool KnowledgeBaseSharepointIndex { get; set; }
    /// <summary>Licenses are imported from Microsoft 365.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_M365Licenses"/>
    /// <remarks>Column <c>M365Licenses</c>: bit, not null.</remarks>
    public virtual bool M365Licenses { get; set; }
    /// <summary>Tenant name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(max), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Hash of the secret token for SCIM.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHash"/>
    /// <remarks>Column <c>ScimSecretTokenHash</c>: nvarchar(255), null.</remarks>
    public virtual string ScimSecretTokenHash { get; set; }
    /// <summary>Date of the last SCIM token hash generation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_ScimSecretTokenHashLastGenerated"/>
    /// <remarks>Column <c>ScimSecretTokenHashLastGenerated</c>: datetime, null.</remarks>
    public virtual DateTime? ScimSecretTokenHashLastGenerated { get; set; }
    /// <summary>Shifts are imported from MS Teams.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_Shifts"/>
    /// <remarks>Column <c>Shifts</c>: bit, not null.</remarks>
    public virtual bool Shifts { get; set; }
    /// <summary>Use organizational structure.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UseOrganizationStructure"/>
    /// <remarks>Column <c>UseOrganizationStructure</c>: bit, not null.</remarks>
    public virtual bool UseOrganizationStructure { get; set; }
    /// <summary>User portraits are imported from Entra.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPortraits"/>
    /// <remarks>Column <c>UserPortraits</c>: bit, not null.</remarks>
    public virtual bool UserPortraits { get; set; }
    /// <summary>User presence is imported from Entra.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_UserPresence"/>
    /// <remarks>Column <c>UserPresence</c>: bit, not null.</remarks>
    public virtual bool UserPresence { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant__ctor"/>
    public AzureAdTenant() { }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AzureAdTenant.html#Alvao_API_Common_Model_Database_AzureAdTenant_GetSettingByFeature_Alvao_API_Common_MSEntraTenant_Feature_"/>
    public bool GetSettingByFeature(MSEntraTenant.Feature feature) { throw new NotImplementedException(); }
}
