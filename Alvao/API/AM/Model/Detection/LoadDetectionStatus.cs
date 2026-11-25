namespace Alvao.API.AM.Model.Detection;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AM.Model.Detection.LoadDetectionStatus.html"/>
public enum LoadDetectionStatus {
    CabNotSupportedOnThisPlatform = 7,
    ErrorComputerSystemNotFound = 2,
    ErrorExtractingJson = 8,
    NotCreatedBecauseNotAllowed = 6,
    Ok = 1,
    OldDetection = 3,
    OverLicence = 4,
    RecycledOrDiscardedComputer = 5,
    Unknown = 0,
}
