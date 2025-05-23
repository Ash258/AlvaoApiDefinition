namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html"/>
public class DetectionInfo {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo_ComputerNodeId"/>
    public int? ComputerNodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo_DetectId"/>
    public int DetectId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo_DetectionKind"/>
    public Detection.Kind? DetectionKind { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo_Status"/>
    public LoadDetectionStatus Status { get; set; }


    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo__ctor"/>
    public DetectionInfo() { }
    /// <param name="status"></param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.DetectionInfo.html#Alvao_API_AM_Model_Detection_DetectionInfo__ctor_Alvao_API_AM_Model_Detection_LoadDetectionStatus_"/>
    public DetectionInfo(LoadDetectionStatus status) { }
}
