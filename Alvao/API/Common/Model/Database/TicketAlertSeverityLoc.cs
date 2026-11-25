using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language localisation cache for alert severity, see TicketAlertSeverity.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html"/>
[Table("dbo.TicketAlertSeverityLoc")]
public class TicketAlertSeverityLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int LocaleId { get; set; }
    /// <summary>Localised name of alert severity.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverity"/>
    /// <remarks>Column <c>TicketAlertSeverity</c>: nvarchar(255), null.</remarks>
    public virtual string TicketAlertSeverity { get; set; }
    /// <summary>Alert ID (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverityLoc.html#Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverityId"/>
    /// <remarks>
    /// Column <c>TicketAlertSeverityId</c>: int, not null. References <see cref="TicketAlertSeverity"/>.
    /// </remarks>
    [ExplicitKey]
    public virtual int TicketAlertSeverityId { get; set; }
}
