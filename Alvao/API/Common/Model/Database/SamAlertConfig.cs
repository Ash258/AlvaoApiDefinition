using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM configuration of notifications.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamAlertConfig.htm"/>
[TableAttribute("dbo.SamAlertConfig")]
public class SamAlertConfig {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertConfig_CheckingDetectPeriod.htm"/>
    public virtual int CheckingDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertConfig_MaxDetectAgeDays.htm"/>
    public virtual int? MaxDetectAgeDays { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertConfig_RepeatLastAlertAfterDays.htm"/>
    public virtual int? RepeatLastAlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlertConfig_SendTimeHour.htm"/>
    [ExplicitKeyAttribute]
    public virtual double SendTimeHour { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SamAlertConfig__ctor.htm"/>
    public SamAlertConfig() { }
}
