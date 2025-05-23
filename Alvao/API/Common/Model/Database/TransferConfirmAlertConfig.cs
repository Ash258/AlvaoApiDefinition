using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Setting time of sending an alert and the period of the last alert repetition.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlertConfig.htm"/>
[TableAttribute("dbo.TransferConfirmAlertConfig")]
public class TransferConfirmAlertConfig {
    /// <summary>Repetition period of the last alert.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_RepeatTeamAlertAfterDays.htm"/>
    public virtual int? RepeatTeamAlertAfterDays { get; set; }
    /// <summary>Require user verification during signature.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_RequireUserAuthentication.htm"/>
    public virtual bool RequireUserAuthentication { get; set; }
    /// <summary>Alert send time.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertConfig_SendTimeHour.htm"/>
    [ExplicitKeyAttribute]
    public virtual double SendTimeHour { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TransferConfirmAlertConfig__ctor.htm"/>
    public TransferConfirmAlertConfig() { }
}
