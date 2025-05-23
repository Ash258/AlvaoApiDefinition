using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Alert severity.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertSeverity.htm"/>
[TableAttribute("dbo.TicketAlertSeverity")]
public class TicketAlertSeverity {
    /// <summary>Localised name of alert severity.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertSeverity__TicketAlertSeverity.htm"/>
    public virtual string _TicketAlertSeverity { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketAlertSeverity_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketAlertSeverity__ctor.htm"/>
    public TicketAlertSeverity() { }
}
