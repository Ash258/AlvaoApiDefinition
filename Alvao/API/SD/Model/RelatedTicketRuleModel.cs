using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

public class RelatedTicketRuleModel
{
    public RelatedTicketRule RelatedTicketRule { get; set; }
    public TicketTemplate TicketTemplate { get; set; }

    public RelatedTicketRuleModel() { }
}
