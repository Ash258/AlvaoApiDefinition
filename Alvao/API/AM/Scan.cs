using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping Scan methods</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scan.html"/>
public static class Scan {
    /// <summary>Creates new records int database tables for ALVAO Agent manual HW/SW scan</summary>
    /// <param name="computerIds">Ids of computer nodes (tblNode.intNodeId)</param>
    /// <param name="profileId">Id of Scan profile to be used</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does nor have permission to create manual scans
    /// </exception>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scan.html#Alvao_API_AM_Scan_AddManualScanRequestsAsync_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_System_Threading_CancellationToken_"/>
    public static Task AddManualScanRequestsAsync(IEnumerable<int> computerIds, int profileId, CancellationToken cancellationToken) { throw new System.NotImplementedException(); }

    /// <summary>Sets scan profile of all provided objects</summary>
    /// <param name="computerIds">Computer nodes to be altered</param>
    /// <param name="profileId">Id of ScanProfile (DetectProfile.id)</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does nor have permission to create manual scans
    /// </exception>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scan.html#Alvao_API_AM_Scan_SetScanProfile_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    public static void SetScanProfile(IEnumerable<int> computerIds, int profileId) { throw new System.NotImplementedException(); }

}
