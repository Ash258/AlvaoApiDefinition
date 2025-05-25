using Alvao.API.AM.Model.SwLibrary;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SwLib.html"/>
public class SwLib {
    /// <summary>Creates request for recognition of unknown products</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_CreateUnknownSwRequest_Alvao_API_AM_Model_SwLibrary_AddUnknownSwRequest_System_Threading_CancellationToken_"/>
    public static Task CreateUnknownSwRequest(AddUnknownSwRequest request, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <summary>Returns current SW library date from SwLib WebService</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_GetCurrentDate"/>
    public static DateTime? GetCurrentDate() { throw new NotImplementedException(); }
    /// <summary>Returns last downloaded SW library date from database</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.SwLib.html#Alvao_API_AM_SwLib_GetDownloadedDate"/>
    public static DateTime? GetDownloadedDate() { throw new NotImplementedException(); }
}
