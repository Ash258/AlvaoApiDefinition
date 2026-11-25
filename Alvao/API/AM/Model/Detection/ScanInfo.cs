namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html"/>
public class ScanInfo {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.LoadStatus.html#fields"/>
    public enum LoadStatus {
        Ok = 0,
        DataCorrupted = 1,
        OldScan = 2,
        CreatedInDefaultFolder = 3,
        NotCreatedBecauseNotAllowed = 4,
        LicenseExceeded = 5,
        DiscardedOrRecycled = 6,
        CabNotSupportedOnThisPlatform = 7,
        ErrorExtractingJson = 8,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_AgentData"/>
    public AgentData AgentData { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_ComputerName"/>
    public string ComputerName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_ComputerNodeId"/>
    public int? ComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_CreatedDate"/>
    public DateTime CreatedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_DnsDomain"/>
    public string DnsDomain { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_FileName"/>
    public string FileName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_FqdnHostname"/>
    public string FqdnHostname { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_IsFullSwScan"/>
    public bool IsFullSwScan { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_JsonModel"/>
    public ScanJsonModel JsonModel { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_Load"/>
    public bool Load { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_Messages"/>
    public List<DetectionMessage> Messages { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_ScanDataType"/>
    public Detection.ScanDataType ScanDataType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_ScanId"/>
    public int ScanId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_ScanType"/>
    public Detection.Kind ScanType { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_Status"/>
    public ScanInfo.LoadStatus Status { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_SwExclude"/>
    public string SwExclude { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_SwInclude"/>
    public string SwInclude { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.ScanInfo.html#Alvao_API_AM_Model_Detection_ScanInfo_Win32ComputerSystemExists"/>
    public bool Win32ComputerSystemExists { get; set; }
}
