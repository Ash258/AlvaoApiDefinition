using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM configuration of notifications.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html"/>
[Table("dbo.SamAlertConfig")]
public class SamAlertConfig {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_CheckingDetectPeriod"/>
    /// <remarks>Column <c>CheckingDetectPeriod</c>: int, not null.</remarks>
    public virtual int CheckingDetectPeriod { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_MaxDetectAgeDays"/>
    /// <remarks>Column <c>MaxDetectAgeDays</c>: int, null.</remarks>
    public virtual int? MaxDetectAgeDays { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_RepeatLastAlertAfterDays"/>
    /// <remarks>Column <c>RepeatLastAlertAfterDays</c>: int, null.</remarks>
    public virtual int? RepeatLastAlertAfterDays { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlertConfig.html#Alvao_API_Common_Model_Database_SamAlertConfig_SendTimeHour"/>
    /// <remarks>Column <c>SendTimeHour</c>: float, not null.</remarks>
    [ExplicitKey]
    public virtual double SendTimeHour { get; set; }
}
