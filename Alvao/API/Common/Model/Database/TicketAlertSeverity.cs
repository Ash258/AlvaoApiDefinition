using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Alert severity.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketAlertSeverity.htm"/>
[TableAttribute("dbo.TicketAlertSeverity")]
public class TicketAlertSeverity
{
    /// <summary>Localised name of alert severity.</summary>
    public virtual string _TicketAlertSeverity { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }

    public TicketAlertSeverity() { }
}
