using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html"/>
public class MSEntraTenant {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.Feature.html#fields"/>
    public enum Feature {
        UserPresence = 0,
        UserPortraits = 1,
        FilePicker = 2,
        Intune = 3,
        KnowledgeBaseSharepoint = 4,
        MsToDo = 5,
    }
    /// <summary>Get list of all tenants.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_GetAll"/>
    /// <returns>list of all tenants (AzureAdTenant)</returns>
    public static IEnumerable<AzureAdTenant> GetAll() { throw new NotImplementedException(); }
    /// <summary>Get list of all tenants with enabled feature.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_GetByFeature_Alvao_API_Common_MSEntraTenant_Feature_"/>
    /// <returns>List of all tenants (AzureAdTenant)</returns>
    public static IEnumerable<AzureAdTenant> GetByFeature(MSEntraTenant.Feature feature) { throw new NotImplementedException(); }
    /// <summary>Returns tenant by ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_GetById_System_Int32_"/>
    /// <param name="tenantId">Tenant ID (AzureAdTenant.id)</param>
    public static AzureAdTenant GetById(int tenantId) { throw new NotImplementedException(); }
    /// <summary>Gets tenant for login to MS Entra ID. It returns either the only tenant or &quot;common&quot; if there are more tenants.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_GetForLogin"/>
    public static string GetForLogin() { throw new NotImplementedException(); }
    /// <summary>Returns if a feature is enabled in any tenant. Values are cached for 1 minute.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_IsFeatureEnabled_Alvao_API_Common_MSEntraTenant_Feature_"/>
    public static bool IsFeatureEnabled(MSEntraTenant.Feature feature) { throw new NotImplementedException(); }
    /// <summary>Returns if a feature is enabled for the specific tenant. Values are cached for 1 minute.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.MSEntraTenant.html#Alvao_API_Common_MSEntraTenant_IsFeatureEnabled_Alvao_API_Common_MSEntraTenant_Feature_System_Int32_"/>
    public static bool IsFeatureEnabled(MSEntraTenant.Feature feature, int tenant) { throw new NotImplementedException(); }
}
