namespace Alvao.API.AM.Model.Detection.Sccm;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html"/>
public class SccmScanResult {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_Message"/>
    public string Message { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_Result"/>
    public SccmScanResultKind Result { get; set; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_Cancelled_System_String_"/>
    public static SccmScanResult Cancelled(string msg = null) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_Error_System_String_"/>
    public static SccmScanResult Error(string msg = null) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_NewData_System_String_"/>
    public static SccmScanResult NewData(string msg = null) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_NoChanges_System_String_"/>
    public static SccmScanResult NoChanges(string msg = null) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_NoData_System_String_"/>
    public static SccmScanResult NoData(string msg = null) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResult.html#Alvao_API_AM_Model_Detection_Sccm_SccmScanResult_NotFound_System_String_"/>
    public static SccmScanResult NotFound(string msg = null) { throw new NotImplementedException(); }
}
