using Alvao.API.AM.Model.SwLibrary;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html"/>
public class SwLib {
    /// <summary>Creates request for recognition of unknown products</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_CreateUnknownSwRequest_Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_System_Threading_CancellationToken_"/>
    public static Task CreateUnknownSwRequest(AddUnknownSwRequest request, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>Returns current SW library date from SwLib WebService</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_GetCurrentDate"/>
    public static DateTime? GetCurrentDate() { throw new NotImplementedException(); }
    /// <summary>Returns last downloaded SW library date from database</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_GetDownloadedDate"/>
    public static DateTime? GetDownloadedDate() { throw new NotImplementedException(); }
    /// <summary>Returns whether the specific object has a scan</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_HasScan_System_Int32_"/>
    public static bool HasScan(int objectId) { throw new NotImplementedException(); }
    /// <summary>Reports issue with SW scan for specific object</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_ReportSWScanIssueAsync_Alvao_API_AM_Model_SwLibrary_SwScanIssue_System_Threading_CancellationToken_"/>
    public static Task ReportSWScanIssueAsync(SwScanIssue issue, CancellationToken cancellationToken) { throw new NotImplementedException(); }
}
