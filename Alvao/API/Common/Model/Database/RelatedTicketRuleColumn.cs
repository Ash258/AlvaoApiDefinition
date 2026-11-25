using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Copied items of the source ticket while creating linked tickets.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleColumn.html"/>
[Table("dbo.RelatedTicketRuleColumn")]
public class RelatedTicketRuleColumn {
    /// <summary>Ticket item ID (see tColumn.iColumnId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleColumn.html#Alvao_API_Common_Model_Database_RelatedTicketRuleColumn_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    [ExplicitKey]
    public virtual int ColumnId { get; set; }
    /// <summary>Rule ID (see RelatedTicketRule.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.RelatedTicketRuleColumn.html#Alvao_API_Common_Model_Database_RelatedTicketRuleColumn_RelatedTicketRuleId"/>
    /// <remarks>Column <c>RelatedTicketRuleId</c>: int, not null. References <see cref="RelatedTicketRule"/>.</remarks>
    [ExplicitKey]
    public virtual int RelatedTicketRuleId { get; set; }
}
