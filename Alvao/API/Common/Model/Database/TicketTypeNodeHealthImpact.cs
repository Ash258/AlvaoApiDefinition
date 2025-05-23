using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For the effect on object health requirements, see TicketType.TicketTypeNodeHealthImpactId.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact.htm"/>
[TableAttribute("dbo.TicketTypeNodeHealthImpact")]
public class TicketTypeNodeHealthImpact
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Record name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact__ctor.htm"/>
    public TicketTypeNodeHealthImpact() { }
}
