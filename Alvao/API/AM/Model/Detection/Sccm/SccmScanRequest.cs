namespace Alvao.API.AM.Model.Detection.Sccm;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html"/>
public class SccmScanRequest {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_ComputerId"/>
    public int ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_ComputerName"/>
    public string ComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_ScanId"/>
    public int ScanId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_ScanKind"/>
    public Detection.Kind ScanKind { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_ScanMethod"/>
    public Detection.Method ScanMethod { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanRequest.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanRequest_WaitingForAutonomousAgent"/>
    public bool WaitingForAutonomousAgent { get; set; }
}
