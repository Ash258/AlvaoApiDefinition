using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language localisation cache for alert severity, see TicketAlertSeverity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html"/>
[Table("dbo.TicketAlertSeverityLoc")]
public class TicketAlertSeverityLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localised name of alert severity.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverity"/>
    public virtual string TicketAlertSeverity { get; set; }
    /// <summary>Alert ID (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverityId"/>
    [ExplicitKey]
    public virtual int TicketAlertSeverityId { get; set; }
}
