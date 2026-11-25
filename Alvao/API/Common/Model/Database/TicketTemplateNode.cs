using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects linked to the ticket templates.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateNode.html"/>
[Table("dbo.TicketTemplateNode")]
public class TicketTemplateNode {
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateNode.html#Alvao_API_Common_Model_Database_TicketTemplateNode_NodeId"/>
    /// <remarks>Column <c>NodeId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int NodeId { get; set; }
    /// <summary>ID of the ticket template (TicketTemplate.Id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateNode.html#Alvao_API_Common_Model_Database_TicketTemplateNode_TicketTemplateId"/>
    /// <remarks>Column <c>TicketTemplateId</c>: int, not null. References <see cref="TicketTemplate"/>.</remarks>
    public virtual int TicketTemplateId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateNode.html#Alvao_API_Common_Model_Database_TicketTemplateNode_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
