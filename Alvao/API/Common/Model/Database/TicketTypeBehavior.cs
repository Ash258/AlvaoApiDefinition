using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System processes.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeBehavior.html"/>
[Table("dbo.TicketTypeBehavior")]
public class TicketTypeBehavior {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeBehavior.html#Alvao_API_Common_Model_Database_TicketTypeBehavior__TicketTypeBehavior"/>
    public virtual string _TicketTypeBehavior { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTypeBehavior.html#Alvao_API_Common_Model_Database_TicketTypeBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
