namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.UsedApplications.html"/>
public class UsedApplications {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.UsedApplications.html#Alvao_API_Common_Model_CustomApps_UsedApplications_AlvaoVersion"/>
    public Version AlvaoVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.UsedApplications.html#Alvao_API_Common_Model_CustomApps_UsedApplications_Installed"/>
    public List<RemoteApplication> Installed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.UsedApplications.html#Alvao_API_Common_Model_CustomApps_UsedApplications_TenantId"/>
    public string TenantId { get; set; }
}
