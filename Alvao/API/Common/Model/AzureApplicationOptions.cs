namespace Alvao.API.Common.Model;

/// <summary>
/// Azure Application Credentials model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AzureApplicationOptions.htm"/>
public class AzureApplicationOptions
{
    /// <summary>Azure Application (client) ID</summary>
    public string ApplicationId { get; set; }
    /// <summary>Azure Directory (tenant) ID</summary>
    public string TenantId { get; set; }

    public AzureApplicationOptions() { }
}
