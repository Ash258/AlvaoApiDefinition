using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>The table of Azure Active Directory tenants from which users are imported.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AzureAdTenant.htm"/>
[TableAttribute("dbo.AzureAdTenant")]
public class AzureAdTenant {
    /// <summary>Folder ID in Azure</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AzureAdTenant_AzureTenantId.htm"/>
    public virtual string AzureTenantId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AzureAdTenant_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_AzureAdTenant__ctor.htm"/>
    public AzureAdTenant() { }
}
