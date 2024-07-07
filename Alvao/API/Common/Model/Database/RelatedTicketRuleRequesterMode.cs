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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual byte id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_RelatedTicketRuleRequesterMode__ctor.htm"/>
    public RelatedTicketRuleRequesterMode() { }
}
