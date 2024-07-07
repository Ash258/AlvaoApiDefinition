namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping requests methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Tickets.htm"/>
public static class Tickets
{

    /// <summary>Returns custom list of tickets.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Tickets_GetCustomTicketList.htm"/>
    /// <param name="columns">Database columns from tHdTicket and tHdTicketCust. These columns will be included in the result</param>
    /// <param name="filterCondition">SQL filter condition (without WHERE keyword)</param>
    /// <param name="sorting">SQL sorting condition (without ORDER BY keyword)</param>
    /// <param name="localeId">Language number</param>
    /// <param name="maxRecords">Maximum number of records returned</param>
    /// <param name="personId">Calling person ID</param>
    public static IEnumerable<Object> GetCustomTicketList(
        string columns,
        string filterCondition,
        string sorting,
        int localeId,
        int maxRecords,
        int? personId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether exists a cyclic relation between requests.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Tickets_CheckCyclicRelationsBeforeMergingTicket.htm"/>
    /// <param name="ticketsIds">List of request IDs ((tHdTicket.iHdTicketId))</param>
    /// <param name="destinationTicketId">Destination request ID ((tHdTicket.iHdTicketId))</param>
    public static bool CheckCyclicRelationsBeforeMergingTicket(
        IEnumerable<int> ticketsIds,
        int destinationTicketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Merges requests to another request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Tickets_Merge.htm"/>
    /// <param name="sourceTicketsId">List of request IDs ((tHdTicket.iHdTicketId)) to merge</param>
    /// <param name="destinationTicketId">Destination request ID ((tHdTicket.iHdTicketId))</param>
    /// <param name="removeRelations">If should remove relations from sourceTicketsId before merging requests.</param>
    public static int Merge(
        IEnumerable<int> sourceTicketsId,
        int destinationTicketId,
        bool removeRelations
    )
    { throw new System.NotImplementedException(); }
}
