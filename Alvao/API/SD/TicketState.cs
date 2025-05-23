using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping ticket states methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TicketState.htm"/>
public static class TicketState {

    /// <summary>Returns TicketState database model by its behavior.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetByBehaviorId.htm"/>
    ///
    /// <param name="behaviorId">State behavior ID(TicketState.TicketStateBehaviorId)</param>
    /// <param name="sectionId">Section ID(tHdTicket.liHdTicketHdSectionId)</param>
    public static Alvao.API.Common.Model.Database.TicketState GetByBehaviorId(
        TicketStateBehavior.BehaviorId behaviorId,
        int sectionId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns TicketState database model by its ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetById.htm"/>
    ///
    /// <param name="stateId">State ID(TicketState.id)</param>
    public static Alvao.API.Common.Model.Database.TicketState GetById(
        int stateId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns TicketState database model by its name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetByName.htm"/>
    ///
    /// <param name="stateName">State name(TicketState.TicketState)</param>
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicket)</param>
    public static Alvao.API.Common.Model.Database.TicketState GetByName(
        string stateName,
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns current TicketState database model of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetCurrentStateByTicketId.htm"/>
    ///
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicketId)</param>
    public static Alvao.API.Common.Model.Database.TicketState GetCurrentStateByTicketId(
        int ticketId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns collection of empty required ticket fields for state.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetEmptyRequiredFieldsForState.htm"/>
    ///
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicket)</param>
    /// <param name="stateId">State ID(TicketState.id).</param>
    public static IEnumerable<StateRequiredColumnModel> GetEmptyRequiredFieldsForState(
        int ticketId,
        int stateId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns collection of states deffined on process.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetFromProcess.htm"/>
    ///
    /// <param name="processId">Process ID(TicketType.id).</param>
    public static IEnumerable<Alvao.API.Common.Model.Database.TicketState> GetFromProcess(
        int processId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns collection of related ticket rules for state. Module ALVAO Advanced Workflows is required.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_GetRelatedTicketRules.htm"/>
    ///
    /// <param name="stateId">State ID(TicketState.id).</param>
    public static IEnumerable<RelatedTicketRuleModel> GetRelatedTicketRules(
        int stateId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns true if given state is approval state, approval starts manually and allowed transitions are to all or permitted states. In this state it is possible to add approvers during approval.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketState_IsAdHocApproval.htm"/>
    ///
    /// <param name="ticketStateId">Request state ID (TicketState.id)</param>
    public static bool IsAdHocApproval(
        int ticketStateId
    ) { throw new System.NotImplementedException(); }
}
