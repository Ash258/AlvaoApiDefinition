namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Model.Detection.LoadDetectionStatus.html"/>
public enum LoadDetectionStatus {
    ErrorComputerSystemNotFound = 3,
    ErrorExtractingCab = 2,
    NotCreatedBecauseNotAllowed = 7,
    Ok = 1,
    OldDetection = 4,
    OverLicence = 5,
    RecycledOrDiscardedComputer = 6,
    Unknown = 0,
}
