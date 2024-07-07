namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping request relations methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Relation.htm"/>
public static class Relation
{

    /// <summary>Creates link between two requests.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_Create.htm"/>
    ///
    /// <param name="beginTicketId">Request where the link starts (tHdTicket.iHdTicketId)</param>
    /// <param name="endTicketId">Request where the link ends (tHdTicket.iHdTicketId)</param>
    /// <param name="ticketRelationTypeId">Link type, possible values are in table (TicketRelationType)</param>
    /// <param name="personId">Person ID (tPerson.iPersonId) who created the link. The person must exist in the database.</param>
    public static int Create(
        int beginTicketId,
        int endTicketId,
        int ticketRelationTypeId,
        int personId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates link between object and request</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_CreateWithObject.htm"/>
    ///
    /// <param name="ticketId">Request ID to link (tHdTicket.iHdTicketId)</param>
    /// <param name="objectId">Object ID to link (tblNode.iNodeId)</param>
    /// <param name="createdPersonId">Person ID (who created link) (tPerson.iPersonId)</param>
    /// <param name="callCustomAction">If true, ticket changed event is triggered.</param>
    public static void CreateWithObject(
        int ticketId,
        int objectId,
        int createdPersonId,
        bool callCustomAction
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns all linked objects to specific request.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_GetLinkedNodes.htm"/>
    ///
    /// <param name="ticketId">Request ID to link (tHdTicket.iHdTicketId)</param>
    public static IEnumerable<int> GetLinkedNodes(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes links of specific requests with specific object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_RemoveMultipleWithObject.htm"/>
    ///
    /// <param name="ticketIds">Request IDs to remove the link (tHdTicket.iHdTicketId)</param>
    /// <param name="objectId">Object ID to remove the link (tblNode.iNodeId)</param>
    /// <param name="removedPersonId">Person ID (who removed link) (tPerson.iPersonId)</param>
    /// <param name="callCustomAction">If true, ticket changed event is triggered.</param>
    public static void RemoveMultipleWithObject(
        IEnumerable<int> ticketIds,
        int objectId,
        int removedPersonId,
        bool callCustomAction
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes specific links to object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_RemoveWithObjectsByIds.htm"/>
    ///
    /// <param name="ticketId">Request ID to link (tHdTicket.iHdTicketId)</param>
    /// <param name="ticketNodeIds">Relation IDs to remove (TicketNode.id)</param>
    /// <param name="removedPersonId">Person ID (who removed link) (tPerson.iPersonId)</param>
    /// <param name="callCustomAction">If true, ticket changed event is triggered.</param>
    public static void RemoveWithObjectsByIds(
        int ticketId,
        IEnumerable<int> ticketNodeIds,
        int removedPersonId,
        bool callCustomAction
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Synchronize links of specific request with specific objects. New objects in the list are linked and links to not presented objects are removed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Relation_SynchronizeWithObjectsByObjectIds.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="objectIds">Object IDs (tblNode.iNodeId)</param>
    /// <param name="changedPersonId">Person ID (who changed link) (tPerson.iPersonId)</param>
    /// <param name="callCustomAction">If true, ticket changed event is triggered.</param>
    public static void SynchronizeWithObjectsByObjectIds(
        int ticketId,
        IEnumerable<int> objectIds,
        int changedPersonId,
        bool callCustomAction
    )
    { throw new System.NotImplementedException(); }
}
