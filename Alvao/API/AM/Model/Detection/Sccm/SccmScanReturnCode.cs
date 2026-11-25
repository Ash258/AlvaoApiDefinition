namespace Alvao.API.AM.Model.Detection.Sccm;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.Sccm.SccmScanReturnCode.html"/>
public enum SccmScanReturnCode {
    Cancelled = 9,
    ConnectionFailed = 8,
    ImportHWFailed = 6,
    ImportSWFailed = 7,
    NoHWChanges = 2,
    NoHWScan = 4,
    NoSWChanges = 3,
    NoSWScan = 5,
    OK = 0,
    PCNotFound = 1,
}
