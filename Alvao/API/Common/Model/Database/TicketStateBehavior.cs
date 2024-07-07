using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// System ticket statuses, see dbo.TicketState.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateBehavior.htm"/>
[TableAttribute("dbo.TicketStateBehavior")]
public class TicketStateBehavior
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateBehavior_BehaviorId.htm"/>
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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateBehavior__TicketStateBehavior.htm"/>
    public virtual string _TicketStateBehavior { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateBehavior_id.htm"/>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketStateBehavior__ctor.htm"/>
    public TicketStateBehavior() { }
}
