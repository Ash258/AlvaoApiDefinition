using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Settings of rules for sending alerts of not yet signed handover protocols.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlertRule.htm"/>
[TableAttribute("dbo.TransferConfirmAlertRule")]
public class TransferConfirmAlertRule
{
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
    public virtual bool Active { get; set; }
    /// <summary>Send an alert after a specified number of days.</summary>
    public virtual int? AlertAfterDays { get; set; }
    /// <summary>The group to which the last alert is sent.</summary>
    public virtual int? AlertRoleId { get; set; }
    /// <summary>Rule ID.</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public TransferConfirmAlertRule() { }
}
