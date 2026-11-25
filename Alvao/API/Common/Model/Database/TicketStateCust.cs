using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket state custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.TicketStateCust"/>
[Table("dbo.TicketStateCust")]
public class TicketStateCust {
    /// <summary>Link to ticket state to which the values belong.</summary>
    /// <remarks>Column <c>TicketStateId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int TicketStateId { get; set; }
}
