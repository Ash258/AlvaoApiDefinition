using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Alert severity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverity.html"/>
[Table("dbo.TicketAlertSeverity")]
public class TicketAlertSeverity {
    /// <summary>Localised name of alert severity.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverity.html#Alvao_API_Common_Model_Database_TicketAlertSeverity__TicketAlertSeverity"/>
    public virtual string _TicketAlertSeverity { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertSeverity.html#Alvao_API_Common_Model_Database_TicketAlertSeverity_id"/>
    [Key]
    public virtual int id { get; set; }
}
