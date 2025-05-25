namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerDetection.html"/>
public class ComputerDetection {
    /// <summary>Class for information from PlanNewDetections.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerDetection.html#Alvao_API_AM_Model_Detection_ComputerDetection_DetectionId"/>
    public int DetectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerDetection.html#Alvao_API_AM_Model_Detection_ComputerDetection_DetectionKindId"/>
    public int DetectionKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.ComputerDetection.html#Alvao_API_AM_Model_Detection_ComputerDetection_NodeId"/>
    public int NodeId { get; set; }
}
