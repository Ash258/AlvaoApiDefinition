using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Settings of rules for sending alerts of not yet signed handover protocols.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlertRule.htm"/>
[TableAttribute("dbo.TransferConfirmAlertRule")]
public class TransferConfirmAlertRule
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlertRule_RuleType.htm"/>
    public enum RuleType
    {
        InitialMessage = 1,
        AlertRecipient = 2,
        AlertTransferringPerson = 3,
        AlertTeam = 4,
        AlertManager = 5,
        Unknown = 6,
    }
    /// <summary>A flag indicating whether or not the alert is active.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertRule_Active.htm"/>
    public virtual bool Active { get; set; }
    /// <summary>Send an alert after a specified number of days.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertRule_AlertAfterDays.htm"/>
    public virtual int? AlertAfterDays { get; set; }
    /// <summary>The group to which the last alert is sent.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertRule_AlertRoleId.htm"/>
    public virtual int? AlertRoleId { get; set; }
    /// <summary>Rule ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlertRule_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TransferConfirmAlertRule__ctor.htm"/>
    public TransferConfirmAlertRule() { }
}
