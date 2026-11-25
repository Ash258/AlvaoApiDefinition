namespace Alvao.API.Common.Model.CustomApps;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html"/>
public class RemoteApplication {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Delete"/>
    public bool Delete { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Enabled"/>
    public bool Enabled { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_FileName"/>
    public string FileName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Install"/>
    public bool Install { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Name"/>
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Operation"/>
    public string Operation { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_UniqueId"/>
    public Guid UniqueId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Update"/>
    public bool Update { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.CustomApps.RemoteApplication.html#Alvao_API_Common_Model_CustomApps_RemoteApplication_Version"/>
    public int Version { get; set; }
}
