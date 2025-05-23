using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language localisation cache for alert severity, see TicketAlertSeverity.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc.htm"/>
[TableAttribute("dbo.TicketAlertSeverityLoc")]
public class TicketAlertSeverityLoc {
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localised name of alert severity.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverity.htm"/>
    public virtual string TicketAlertSeverity { get; set; }
    /// <summary>Alert ID (TicketAlertSeverity.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc_TicketAlertSeverityId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int TicketAlertSeverityId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketAlertSeverityLoc__ctor.htm"/>
    public TicketAlertSeverityLoc() { }
}
