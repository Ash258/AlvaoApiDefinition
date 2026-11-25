using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.DownloadedApplication.html"/>
public class DownloadedApplication {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.DownloadedApplication.html#Alvao_API_Common_Model_CustomApps_DownloadedApplication_App"/>
    public App App { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.DownloadedApplication.html#Alvao_API_Common_Model_CustomApps_DownloadedApplication_Scripts"/>
    public List<Script> Scripts { get; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.DownloadedApplication.html#Alvao_API_Common_Model_CustomApps_DownloadedApplication__ctor_Alvao_API_Common_Model_Database_App_System_Collections_Generic_List_Alvao_API_Common_Model_Database_Script__"/>
    public DownloadedApplication(App app, List<Script> scripts) { }
}
