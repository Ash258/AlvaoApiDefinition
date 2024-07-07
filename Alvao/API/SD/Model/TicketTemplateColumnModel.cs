using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

public class TicketTemplateColumnModel
{
    public tColumn Column { get; set; }
    public TicketTemplateColumnValue ColumnValue { get; set; }

    public TicketTemplateColumnModel() { }
}
