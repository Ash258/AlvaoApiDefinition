using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM configuration of notifications.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamAlertConfig.htm"/>
[TableAttribute("dbo.SamAlertConfig")]
public class SamAlertConfig
{
    public virtual int CheckingDetectPeriod { get; set; }
    public virtual int? MaxDetectAgeDays { get; set; }
    public virtual int? RepeatLastAlertAfterDays { get; set; }
    [ExplicitKeyAttribute]
    public virtual double SendTimeHour { get; set; }

    public SamAlertConfig() { }
}
