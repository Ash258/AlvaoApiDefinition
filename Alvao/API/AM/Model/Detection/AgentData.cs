namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html"/>
public class AgentData {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_AlvaoAgentDeviceId"/>
    public string AlvaoAgentDeviceId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_BiosSerialNumber"/>
    public string BiosSerialNumber { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_ChassisTypeId"/>
    public int ChassisTypeId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_Hostname"/>
    public string Hostname { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_MacAddresses"/>
    public string[] MacAddresses { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.AgentData.html#Alvao_API_AM_Model_Detection_AgentData_Model"/>
    public string Model { get; set; }

}
