using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping ticket states methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html"/>
public static class TicketState {
    /// <summary>Returns TicketState database model by its behavior.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetByBehaviorId_Alvao_API_Common_Model_Database_TicketStateBehavior_BehaviorId_System_Int32_"/>
    /// <param name="behaviorId">State behavior ID(TicketState.TicketStateBehaviorId)</param>
    /// <param name="sectionId">Section ID(tHdTicket.liHdTicketHdSectionId)</param>
    /// <returns>Request state (TicketState)</returns>
    public static Alvao.API.Common.Model.Database.TicketState GetByBehaviorId(TicketStateBehavior.BehaviorId behaviorId, int sectionId) { throw new NotImplementedException(); }
    /// <summary>Returns TicketState database model by its ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetById_System_Int32_"/>
    /// <param name="stateId">State ID(TicketState.id)</param>
    /// <returns>Request state (TicketState)</returns>
    public static Alvao.API.Common.Model.Database.TicketState GetById(int stateId) { throw new NotImplementedException(); }
    /// <summary>Returns TicketState database model by its name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetByName_System_String_System_Int32_"/>
    /// <param name="stateName">State name(TicketState.TicketState)</param>
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicket)</param>
    /// <exception cref="ArgumentException">Throws when ticket with given ticketId does not exist.</exception>
    /// <returns>Request state (TicketState)</returns>
    public static Alvao.API.Common.Model.Database.TicketState GetByName(string stateName, int ticketId) { throw new NotImplementedException(); }
    /// <summary>Returns current TicketState database model of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetCurrentStateByTicketId_System_Int32_"/>
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicketId)</param>
    /// <returns>Request state (TicketState)</returns>
    public static Alvao.API.Common.Model.Database.TicketState GetCurrentStateByTicketId(int ticketId) { throw new NotImplementedException(); }
    /// <summary>Returns collection of empty required ticket fields for state.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetEmptyRequiredFieldsForState_System_Int32_System_Int32_"/>
    /// <param name="ticketId">Ticket ID(tHdTicket.iHdTicket)</param>
    /// <param name="stateId">State ID(TicketState.id).</param>
    /// <returns>Collection of strings</returns>
    public static IEnumerable<StateRequiredColumnModel> GetEmptyRequiredFieldsForState(int ticketId, int stateId) { throw new NotImplementedException(); }
    /// <summary>Returns collection of states deffined on process.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetFromProcess_System_Int32_"/>
    /// <param name="processId">Process ID(TicketType.id).</param>
    /// <returns>Collection of TicketState.</returns>
    public static IEnumerable<Alvao.API.Common.Model.Database.TicketState> GetFromProcess(int processId) { throw new NotImplementedException(); }
    /// <summary>Returns collection of related ticket rules for state. Module ALVAO Advanced Workflows is required.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetRelatedTicketRules_System_Int32_"/>
    /// <param name="stateId">State ID(TicketState.id).</param>
    /// <returns>Collection of RelatedTicketRuleModel. Contains both RelatedTicketRule and TicketTemplate database models.</returns>
    public static IEnumerable<RelatedTicketRuleModel> GetRelatedTicketRules(int stateId) { throw new NotImplementedException(); }
    /// <summary>Returns collection of states deffined on process. GetStatesFromProcess is deprecated, please use GetFromProcess instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_GetStatesFromProcess_System_Int32_"/>
    /// <param name="processId">Process ID(TicketType.id).</param>
    /// <returns>Collection of TicketState.</returns>
    [Obsolete("GetStatesFromProcess is deprecated, please use GetFromProcess instead.")]
    public static IEnumerable<Alvao.API.Common.Model.Database.TicketState> GetStatesFromProcess(int processId) { throw new NotImplementedException(); }
    /// <summary>Returns true if given state is approval state, approval starts manually and allowed transitions are to all or permitted states. In this state it is possible to add approvers during approval.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketState.html#Alvao_API_SD_TicketState_IsAdHocApproval_System_Int32_"/>
    /// <param name="ticketStateId">Request state ID (TicketState.id)</param>
    public static bool IsAdHocApproval(int ticketStateId) { throw new NotImplementedException(); }
}
