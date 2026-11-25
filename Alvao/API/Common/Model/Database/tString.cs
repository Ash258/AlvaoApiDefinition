using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System code list for texts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tString.html"/>
[Table("dbo.tString")]
public class tString {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tString.Id.html#fields"/>
    public enum Id {
        DetectWaitingForEval = 106,
        DetectCoreHwComponentsChanged = 107,
        DetectPropertyChanged = 110,
        DetectHwNothingChanged = 114,
        DetectHwUpdatedByDetect = 115,
        DetectNotLoadedComputerExceededLicence = 119,
        DetectNotEvaluatedComputerExceededLicence = 120,
        DetectComputerSystemNotFound = 121,
        DetectBiosSnIsInAnotherComputer = 123,
        DetectLoadError = 125,
        DetectSwNothingChange = 126,
        DetectSwUpdatedByDetect = 127,
        DetectEvaluationError = 130,
        ScanScheduledToComputer = 131,
        DataFromAgentReceived = 132,
        DetectNotLoadedComputerDiscardedOrRemoved = 136,
        LogWaitForAgent = 139,
        MSSccmNoHWScan = 140,
        MSSccmNoSWScan = 141,
        MSSccmComputerNotFound = 142,
        MyAsset = 150,
        NonProvisionedUser = 167,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_iStringId"/>
    /// <remarks>Column <c>iStringId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tString.html#Alvao_API_Common_Model_Database_tString_mString"/>
    /// <remarks>Column <c>mString</c>: nvarchar(max), null.</remarks>
    public virtual string mString { get; set; }
}
