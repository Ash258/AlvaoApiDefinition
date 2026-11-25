using Newtonsoft.Json;

namespace Alvao.API.AM.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html"/>
public class DeviceScope {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_DeviceCategory"/>
    public IEnumerable<string> DeviceCategory { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_DeviceType"/>
    public string DeviceType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_Import"/>
    public bool? Import { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_ManagedDeviceType"/>
    [JsonIgnore]
    public ManagedDeviceType? ManagedDeviceType { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_Ownership"/>
    public IEnumerable<string> Ownership { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.DeviceScope.html#Alvao_API_AM_Model_DeviceScope_ScanSoftware"/>
    public bool? ScanSoftware { get; set; }
}
