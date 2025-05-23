namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html"/>
public class ComputerInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_AlvaoAgentDeviceId"/>
    public string AlvaoAgentDeviceId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_BiosSerialNumber"/>
    public string BiosSerialNumber { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_Domain"/>
    public string Domain { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_Fqdn"/>
    public string Fqdn { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_Hostname"/>
    public string Hostname { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_IsNewComputer"/>
    public bool IsNewComputer { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_IsRecycledOrDiscarded"/>
    public bool IsRecycledOrDiscarded { get; set; }

    /// <summary>Class for information from spCreateSimpleComputer procedure. Do not rename fields!</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_PcNodeId"/>
    public int PcNodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerInfo.html#Alvao_API_AM_Model_Detection_ComputerInfo_SetNodeId"/>
    public int SetNodeId { get; set; }

}
