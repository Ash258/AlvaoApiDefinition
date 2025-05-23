using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Copied items of the source ticket while creating linked tickets.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RelatedTicketRuleColumn.htm"/>
[TableAttribute("dbo.RelatedTicketRuleColumn")]
public class RelatedTicketRuleColumn {
    /// <summary>Ticket item ID (see tColumn.iColumnId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRuleColumn_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Rule ID (see RelatedTicketRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRuleColumn_RelatedTicketRuleId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int RelatedTicketRuleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RelatedTicketRuleColumn__ctor.htm"/>
    public RelatedTicketRuleColumn() { }
}
