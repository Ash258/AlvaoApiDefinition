namespace Alvao.API.AM.Model.Detection.Sccm;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanResultKind.html"/>
public enum SccmScanResultKind {
    Cancelled = 5,
    ComputerNotFound = 3,
    Error = 4,
    NewDataAcquired = 0,
    NoChanges = 1,
    NoDataAvailable = 2,
}
