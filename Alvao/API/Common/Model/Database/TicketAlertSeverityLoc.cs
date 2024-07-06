using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Language localisation cache for alert severity, see TicketAlertSeverity.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc.htm"/>
[TableAttribute("dbo.TicketAlertSeverityLoc")]
public class TicketAlertSeverityLoc
{
    /// <summary>Language ID.</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localised name of alert severity.</summary>
    public virtual string TicketAlertSeverity { get; set; }
    /// <summary>Alert ID (TicketAlertSeverity.id).</summary>
    [ExplicitKeyAttribute]
    public virtual int TicketAlertSeverityId { get; set; }

    public TicketAlertSeverityLoc() { }
}
