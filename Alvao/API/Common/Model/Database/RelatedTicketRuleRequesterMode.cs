using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Method of setting the requester while creating linked tickets, see RelatedTicketRule.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode.htm"/>
[TableAttribute("dbo.RelatedTicketRuleRequesterMode")]
public class RelatedTicketRuleRequesterMode
{
    /// <summary>Record description</summary>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    [ExplicitKeyAttribute]
    public virtual byte id { get; set; }

    public RelatedTicketRuleRequesterMode() { }
}
