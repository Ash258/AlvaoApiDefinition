namespace Alvao.API.SD;

/// <summary>Facade class grouping requests methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Tickets.html"/>
public static class Tickets {
    /// <summary>Checks whether exists a cyclic relation between requests.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Tickets.html#Alvao_API_SD_Tickets_CheckCyclicRelationsBeforeMergingTicket_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    /// <param name="ticketsIds">List of request IDs ((tHdTicket.iHdTicketId))</param>
    /// <param name="destinationTicketId">Destination request ID ((tHdTicket.iHdTicketId))</param>
    /// <exception cref="ArgumentException">Throws when request with destinationTicketId or one of ticketsIds does not exists or ticketsIds contains destinationTicketId or ticketsIds has value.</exception>
    /// <returns>Cyclic relation exists</returns>
    public static bool CheckCyclicRelationsBeforeMergingTicket(IEnumerable<int> ticketsIds, int destinationTicketId) { throw new NotImplementedException(); }
    /// <summary>Returns custom list of tickets.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Tickets.html#Alvao_API_SD_Tickets_GetCustomTicketList_System_String_System_String_System_String_System_Int32_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="columns">Database columns from tHdTicket and tHdTicketCust. These columns will be included in the result</param>
    /// <param name="filterCondition">SQL filter condition (without WHERE keyword)</param>
    /// <param name="sorting">SQL sorting condition (without ORDER BY keyword)</param>
    /// <param name="localeId">Language number</param>
    /// <param name="maxRecords">Maximum number of records returned</param>
    /// <param name="personId">Calling person ID</param>
    /// <exception cref="InvalidOperationException">Throws when at least one column in columns is forbidden.</exception>
    /// <returns>List of dynamic objects. Each object has properties specified in columns parameter.</returns>
    public static IEnumerable<dynamic> GetCustomTicketList(string columns, string filterCondition, string sorting, int localeId, int maxRecords, int? personId) { throw new NotImplementedException(); }
    /// <summary>Merges requests to another request.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Tickets.html#Alvao_API_SD_Tickets_Merge_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_System_Boolean_"/>
    /// <param name="sourceTicketsId">List of request IDs ((tHdTicket.iHdTicketId)) to merge</param>
    /// <param name="destinationTicketId">Destination request ID ((tHdTicket.iHdTicketId))</param>
    /// <param name="removeRelations">If should remove relations from sourceTicketsId before merging requests.</param>
    /// <exception cref="ArgumentException">Throws when request with destinationTicketId or one of sourceTicketsId does not exists or sourceTicketsId contains destinationTicketId or sourceTicketsId has value.</exception>
    /// <returns>Created act ID (tAct.iActId)</returns>
    public static int Merge(IEnumerable<int> sourceTicketsId, int destinationTicketId, bool removeRelations) { throw new NotImplementedException(); }
}
