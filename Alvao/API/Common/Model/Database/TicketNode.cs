using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects associated to the ticket over the ticket "Objects" item.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketNode.htm"/>
[TableAttribute("dbo.TicketNode")]
public class TicketNode
{
    /// <summary>Link creation date and time (UTC)</summary>
    public virtual DateTime? Created { get; set; }
    /// <summary>User ID of a person who created the link (tPerson.iPersonId).</summary>
    public virtual int? CreatedByPersonId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    public virtual int NodeId { get; set; }
    /// <summary>Link removal date and time (UTC)</summary>
    public virtual DateTime? Removed { get; set; }
    /// <summary>User ID of a person who deleted the link (tPerson.iPersonId).</summary>
    public virtual int? RemovedByPersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    public virtual int TicketId { get; set; }

    public TicketNode() { }
}
