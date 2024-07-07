using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// System ticket statuses, see dbo.TicketState.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateBehavior.htm"/>
[TableAttribute("dbo.TicketStateBehavior")]
public class TicketStateBehavior
{
    public enum BehaviorId
    {
        NewTicket = 1,
        PassToSolver = 2,
        Resolve = 3,
        Reopen = 4,
        Remove = 6,
        RestoreRemoved = 7,
        ExpiredApproval = 9,
        ManualChange = 10,
        Close = 11,
    }

    public virtual string _TicketStateBehavior { get; set; }
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public TicketStateBehavior() { }
}
