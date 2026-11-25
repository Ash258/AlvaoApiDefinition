using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects associated to the ticket over the ticket &quot;Objects&quot; item.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html"/>
[Table("dbo.TicketNode")]
public class TicketNode {
    /// <summary>Link creation date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, null.</remarks>
    public virtual DateTime? Created { get; set; }
    /// <summary>User ID of a person who created the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int NodeId { get; set; }
    /// <summary>Link removal date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <summary>User ID of a person who deleted the link (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_RemovedByPersonId"/>
    /// <remarks>Column <c>RemovedByPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_TicketId"/>
    /// <remarks>Column <c>TicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int TicketId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketNode.html#Alvao_API_Common_Model_Database_TicketNode_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
