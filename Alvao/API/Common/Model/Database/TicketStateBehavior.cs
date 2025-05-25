using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>System ticket statuses, see dbo.TicketState.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateBehavior.html"/>
[Table("dbo.TicketStateBehavior")]
public class TicketStateBehavior {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateBehavior.BehaviorId.html#fields"/>
    public enum BehaviorId {
        Close = 11,
        ExpiredApproval = 9,
        ManualChange = 10,
        NewTicket = 1,
        PassToSolver = 2,
        Remove = 6,
        Reopen = 4,
        Resolve = 3,
        RestoreRemoved = 7,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateBehavior.html#Alvao_API_Common_Model_Database_TicketStateBehavior__TicketStateBehavior"/>
    public virtual string _TicketStateBehavior { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateBehavior.html#Alvao_API_Common_Model_Database_TicketStateBehavior_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
