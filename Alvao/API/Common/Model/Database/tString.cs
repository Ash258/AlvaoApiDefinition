using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System code list for texts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html"/>
[Table("dbo.tString")]
public class tString {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.Id.html#fields"/>
    public enum Id {
        DetectWaitingForEval = 106,
        DetectCoreHwComponentsChanged = 107,
        DetectPropertyChanged = 110,
        DetectHwNothingChanged = 114,
        DetectHwUpdatedByDetect = 115,
        DetectNotLoadedComputerExceededLicence = 119,
        DetectNotEvaluatedComputerExceededLicence = 120,
        DetectComputerSystemNotFound = 121,
        DetectComputerHostnameChanged = 122,
        DetectBiosSnIsInAnotherComputer = 123,
        DetectComputerDomainChanged = 124,
        DetectLoadError = 125,
        DetectSwNothingChange = 126,
        DetectSwUpdatedByDetect = 127,
        DetectEvaluationError = 130,
        ScanScheduledToComputer = 131,
        DataFromAgentReceived = 132,
        DetectNotLoadedComputerDiscardedOrRemoved = 136,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_iStringId"/>
    [ExplicitKey]
    public virtual int iStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_mString"/>
    public virtual string mString { get; set; }
}
