using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Setting time of sending an alert and the period of the last alert repetition.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlertConfig.html"/>
[Table("dbo.TransferConfirmAlertConfig")]
public class TransferConfirmAlertConfig {
    /// <summary>Repetition period of the last alert.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlertConfig.html#Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_RepeatTeamAlertAfterDays"/>
    public virtual int? RepeatTeamAlertAfterDays { get; set; }
    /// <summary>Require user verification during signature.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlertConfig.html#Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_RequireUserAuthentication"/>
    public virtual bool RequireUserAuthentication { get; set; }
    /// <summary>Alert send time.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlertConfig.html#Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_SendTimeHour"/>
    [ExplicitKey]
    public virtual double SendTimeHour { get; set; }
}
