using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket items used by the process.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html"/>
[Table("dbo.TicketTypeColumn")]
public class TicketTypeColumn {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_TicketTypeId"/>
    /// <remarks>Column <c>TicketTypeId</c>: int, not null. References <see cref="TicketType"/>.</remarks>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
