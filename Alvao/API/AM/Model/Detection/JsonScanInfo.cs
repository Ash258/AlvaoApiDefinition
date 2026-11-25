using System.Runtime.Serialization;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html"/>
[DataContract]
public class JsonScanInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html#Alvao_API_AM_Model_Detection_JsonScanInfo_Date"/>
    [DataMember(Name = "date")]
    public DateTime Date { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html#Alvao_API_AM_Model_Detection_JsonScanInfo_IsFullSwScan"/>
    [DataMember(Name = "isFullSwScan")]
    public bool IsFullSwScan { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html#Alvao_API_AM_Model_Detection_JsonScanInfo_SwExclude"/>
    [DataMember(Name = "swExclude")]
    public string SwExclude { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html#Alvao_API_AM_Model_Detection_JsonScanInfo_SwInclude"/>
    [DataMember(Name = "swInclude")]
    public string SwInclude { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.JsonScanInfo.html#Alvao_API_AM_Model_Detection_JsonScanInfo_Type"/>
    [DataMember(Name = "type")]
    public string Type { get; set; }
}
