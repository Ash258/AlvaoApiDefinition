using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Copied items of the source ticket while creating linked tickets.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RelatedTicketRuleColumn.htm"/>
[TableAttribute("dbo.RelatedTicketRuleColumn")]
public class RelatedTicketRuleColumn
{
    /// <summary>Ticket item ID (see tColumn.iColumnId)</summary>
    public virtual int ColumnId { get; set; }
    /// <summary>Rule ID (see RelatedTicketRule.id)</summary>
    [ExplicitKeyAttribute]
    public virtual int RelatedTicketRuleId { get; set; }

    public RelatedTicketRuleColumn() { }
}
