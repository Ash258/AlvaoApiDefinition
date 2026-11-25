using System.Runtime.Serialization;
using Alvao.API.AM.Model.Detection.Software;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html"/>
[DataContract]
public class ScanJsonModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_ComputerInfo"/>
    [DataMember(Name = "computerInfo")]
    public AgentData ComputerInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_FormatVersion"/>
    [DataMember(Name = "formatVersion")]
    public int FormatVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_Hardware"/>
    [DataMember(Name = "hardware")]
    public Dictionary<string, object> Hardware { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_HwWmiClassesData"/>
    public List<Dictionary<string, object>> HwWmiClassesData { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_HwWmiRelationsData"/>
    public List<Dictionary<string, string>> HwWmiRelationsData { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_OsVersionInfo"/>
    public OsVersionInfo OsVersionInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_ScanInfo"/>
    [DataMember(Name = "scanInfo")]
    public JsonScanInfo ScanInfo { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_Software"/>
    [DataMember(Name = "software")]
    public Dictionary<string, object> Software { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_SwFilesData"/>
    public List<Dictionary<string, object>> SwFilesData { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanJsonModel.html#Alvao_API_AM_Model_Detection_ScanJsonModel_SwRegistryData"/>
    public List<Dictionary<string, object>> SwRegistryData { get; set; }
}
