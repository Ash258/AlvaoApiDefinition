namespace Alvao.Apps.API;

/// <summary>!!!CAUTION: This class is not documented. Its shape is taken from the Alvao 26 application templates.<br/><br/>Parameters of entity command and entity tab methods.</summary>
public class EntityArgs {
    /// <summary>The entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId).</summary>
    public int EntityId { get; set; }
    /// <summary>The ID of the user (tPerson.iPersonId).</summary>
    public int PersonId { get; set; }
}
