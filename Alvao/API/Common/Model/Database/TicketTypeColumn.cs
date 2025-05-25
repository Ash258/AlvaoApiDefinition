using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket items used by the process.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html"/>
[Table("dbo.TicketTypeColumn")]
public class TicketTypeColumn {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_TicketTypeId"/>
    public virtual int TicketTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeColumn.html#Alvao_API_Common_Model_Database_TicketTypeColumn_id"/>
    [Key]
    public virtual int id { get; set; }
}
