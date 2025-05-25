using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM configuration of notifications.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html"/>
[Table("dbo.SamAlertConfig")]
public class SamAlertConfig {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_CheckingDetectPeriod"/>
    public virtual int CheckingDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_MaxDetectAgeDays"/>
    public virtual int? MaxDetectAgeDays { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_RepeatLastAlertAfterDays"/>
    public virtual int? RepeatLastAlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_SendTimeHour"/>
    [ExplicitKey]
    public virtual double SendTimeHour { get; set; }
}
