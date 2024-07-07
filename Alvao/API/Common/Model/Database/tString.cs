using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// System code list for texts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tString.htm"/>
[TableAttribute("dbo.tString")]
public class tString
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tString_Id.htm"/>
    public enum Id
    {
        DetectWaitingForEval = 106,
        DetectCoreHwComponentsChanged = 107,
        DetectHwUpdateIsOff = 108,
        DetectDifferencesIgnored = 109,
        DetectPropertyChanged = 110,
        DetectCantUpdateObject = 111,
        DetectObjectRemoveIgnored = 112,
        DetectObjectRemoveCant = 113,
        DetectHwNothingChanged = 114,
        DetectHwUpdatedByDetect = 115,
        DetectSomeNotUpdated = 116,
        DetectAllDifferencesIgnored = 117,
        DetectSomeUpdatedSomeIgnored = 118,
        DetectNotLoadedComputerExceededLicence = 119,
        DetectNotEvaluatedComputerExceededLicence = 120,
        DetectComputerSystemNotFound = 121,
        DetectComputerHostnameChanged = 122,
        DetectComponentsInAnotherComputer = 123,
        DetectComputerDomainChanged = 124,
        DetectLoadError = 125,
        DetectSwNothingChange = 126,
        DetectSwUpdatedByDetect = 127,
        DetectSwUpdateIsOff = 128,
        DetectDuplicitComputer = 129,
        DetectEvaluationError = 130,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tString_iStringId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iStringId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tString_mString.htm"/>
    public virtual string mString { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tString__ctor.htm"/>
    public tString() { }
}
