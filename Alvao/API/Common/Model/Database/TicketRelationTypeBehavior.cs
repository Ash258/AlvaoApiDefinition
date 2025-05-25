using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System types of links between tickets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationTypeBehavior.html"/>
[Table("dbo.TicketRelationTypeBehavior")]
public class TicketRelationTypeBehavior {
    /// <summary>Link name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationTypeBehavior.html#Alvao_API_Common_Model_Database_TicketRelationTypeBehavior__TicketRelationTypeBehavior"/>
    public virtual string _TicketRelationTypeBehavior { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationTypeBehavior.html#Alvao_API_Common_Model_Database_TicketRelationTypeBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
