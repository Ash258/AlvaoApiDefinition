using System.Globalization;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping ticket type methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketProcess.html"/>
public static class TicketProcess {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketProcess.RelatedTicketRuleRequesterMode.html#fields"/>
    public enum RelatedTicketRuleRequesterMode {
        Requester = 1,
        Solver = 2,
        OtherPerson = 3,
        CustomColumnPerson = 4,
    }

    /// <summary>Evaluates Related Ticket Rules on current state Module ALVAO Advanced Workflows is required.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketProcess.html#Alvao_API_SD_TicketProcess_EvaluateRelatedTicketRules_System_Int32_"/>
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    public static void EvaluateRelatedTicketRules(int ticketId) { throw new NotImplementedException(); }
    /// <summary>Returns collection of TicketProcessColumnModel, which is a representation of the columns set on the process</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.TicketProcess.html#Alvao_API_SD_TicketProcess_GetColumns_System_Int32_System_Globalization_CultureInfo_"/>
    /// <param name="processId">Process ID(TicketType.id)</param>
    /// <param name="language">Language (for localized columns). If param is set to null, current person language is used</param>
    /// <returns>Collection of TicketProcessColumnModel</returns>
    public static IEnumerable<TicketProcessColumnModel> GetColumns(int processId, CultureInfo language = null) { throw new NotImplementedException(); }
}
