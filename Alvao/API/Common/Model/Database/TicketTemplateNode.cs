using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects linked to the ticket templates.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTemplateNode.htm"/>
[TableAttribute("dbo.TicketTemplateNode")]
public class TicketTemplateNode
{
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Object ID (tblNode.intNodeId)</summary>
    public virtual int NodeId { get; set; }
    /// <summary>ID of the ticket template (TicketTemplate.Id)</summary>
    public virtual int TicketTemplateId { get; set; }

    public TicketTemplateNode() { }
}
