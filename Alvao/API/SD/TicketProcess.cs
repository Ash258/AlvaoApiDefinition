using Alvao.API.SD.Model;
using System.Globalization;

namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping ticket type methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TicketProcess.htm"/>
public static class TicketProcess
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_TicketProcess_RelatedTicketRuleRequesterMode.htm"/>
    public enum RelatedTicketRuleRequesterMode
    {
        Requester = 1,
        Solver = 2,
        OtherPerson = 3,
        CustomColumnPerson = 4,
    }

    /// <summary>Evaluates Related Ticket Rules on current state Module ALVAO Advanced Workflows is required.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketProcess_EvaluateRelatedTicketRules.htm"/>
    ///
    /// <param name="ticketId">Ticket ID (tHdTicket.iHdTicketId)</param>
    public static void EvaluateRelatedTicketRules(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns collection of TicketProcessColumnModel, which is a representation of the columns set on the process</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_TicketProcess_GetColumns.htm"/>
    ///
    /// <param name="processId">Process ID(TicketType.id)</param>
    /// <param name="language">Language (for localized columns). If param is set to null, current person language is used</param>
    public static IEnumerable<TicketProcessColumnModel> GetColumns(
        int processId,
        CultureInfo language = null
    )
    { throw new System.NotImplementedException(); }
}
