using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket items used by the process.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTypeColumn.htm"/>
[TableAttribute("dbo.TicketTypeColumn")]
public class TicketTypeColumn
{
    public virtual int ColumnId { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int TicketTypeId { get; set; }

    public TicketTypeColumn() { }
}
