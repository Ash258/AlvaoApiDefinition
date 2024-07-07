namespace Alvao.API.Common.Model;

/// <summary>Azure Application Credentials model</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_AzureApplicationOptions.htm"/>
public class AzureApplicationOptions
{
    /// <summary>Azure Application (client) ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AzureApplicationOptions_ApplicationId.htm"/>
    public string ApplicationId { get; set; }
    /// <summary>Azure Directory (tenant) ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_AzureApplicationOptions_TenantId.htm"/>
    public string TenantId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_AzureApplicationOptions__ctor.htm"/>
    public AzureApplicationOptions() { }
}
