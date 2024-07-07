using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping ticket states methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TicketState.htm"/>
public static class TicketState
{
    /// <summary>Returns collection of related ticket rules for state. Module ALVAO Advanced Workflows is required.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetRelatedTicketRules.htm"/>
    ///
    /// <param name="stateId">State ID(TicketState.id).</param>
    public static IEnumerable<RelatedTicketRuleModel> GetRelatedTicketRules(
        int stateId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns true if given state is approval state, approval starts manually and allowed transitions are to all or permitted states. In this state it is possible to add approvers during approval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_IsAdHocApproval.htm"/>
    ///
    /// <param name="ticketStateId">Request state ID (TicketState.id)</param>
    public static bool IsAdHocApproval(
        int ticketStateId
    )
    { throw new System.NotImplementedException(); }
}
