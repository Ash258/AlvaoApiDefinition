using System.Runtime.Serialization;

namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html"/>
[DataContract]
public class AgentData {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_AlvaoAgentDeviceId"/>
    [DataMember(Name = "alvaoAgentDeviceId")]
    public string AlvaoAgentDeviceId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_BiosSerialNumber"/>
    [DataMember(Name = "biosSerialNumber")]
    public string BiosSerialNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_ChassisTypeId"/>
    [DataMember(Name = "chassisTypeId")]
    public int ChassisTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_DnsDomain"/>
    [DataMember(Name = "domain")]
    public string DnsDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_FqdnHostname"/>
    public string FqdnHostname { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_Hostname"/>
    [DataMember(Name = "hostname")]
    public string Hostname { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_MacAddresses"/>
    [DataMember(Name = "macAddresses")]
    public string[] MacAddresses { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_Model"/>
    [DataMember(Name = "model")]
    public string Model { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_ScanId"/>
    [DataMember(Name = "scanId")]
    public int ScanId { get; set; }
}
