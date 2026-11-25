using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For the effect on object health requirements, see TicketType.TicketTypeNodeHealthImpactId.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html"/>
[Table("dbo.TicketTypeNodeHealthImpact")]
public class TicketTypeNodeHealthImpact {
    /// <summary>Record name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html#Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(70), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeNodeHealthImpact.html#Alvao_API_Common_Model_Database_TicketTypeNodeHealthImpact_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
