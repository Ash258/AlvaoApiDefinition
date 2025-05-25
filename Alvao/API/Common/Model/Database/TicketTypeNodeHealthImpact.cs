using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For the effect on object health requirements, see TicketType.TicketTypeNodeHealthImpactId.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html"/>
[Table("dbo.TicketTypeNodeHealthImpact")]
public class TicketTypeNodeHealthImpact {
    /// <summary>Record name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html#Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html#Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
