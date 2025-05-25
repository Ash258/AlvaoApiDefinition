using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System code list for texts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html"/>
[Table("dbo.tString")]
public class tString {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.Id.html#fields"/>
    public enum Id {
        DataFromAgentReceived = 132,
        DetectAllDifferencesIgnored = 117,
        DetectBiosSnIsInAnotherComputer = 123,
        DetectComputerDomainChanged = 124,
        DetectComputerHostnameChanged = 122,
        DetectComputerSystemNotFound = 121,
        DetectCoreHwComponentsChanged = 107,
        DetectEvaluationError = 130,
        DetectHwNothingChanged = 114,
        DetectHwUpdatedByDetect = 115,
        DetectLoadError = 125,
        DetectNotEvaluatedComputerExceededLicence = 120,
        DetectNotLoadedComputerDiscardedOrRemoved = 136,
        DetectNotLoadedComputerExceededLicence = 119,
        DetectPropertyChanged = 110,
        DetectSomeNotUpdated = 116,
        DetectSomeUpdatedSomeIgnored = 118,
        DetectSwNothingChange = 126,
        DetectSwUpdatedByDetect = 127,
        DetectWaitingForEval = 106,
        ScanScheduledToComputer = 131,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_iStringId"/>
    [ExplicitKey]
    public virtual int iStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_mString"/>
    public virtual string mString { get; set; }
}
