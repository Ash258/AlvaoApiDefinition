using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Links Between Tickets.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketRelation.htm"/>
[TableAttribute("dbo.vTicketRelation")]
public class vTicketRelation
{
    public virtual int BeginHdTicketId { get; set; }
    public virtual int EndHdTicketId { get; set; }
    public virtual int id { get; set; }
    public virtual int TicketRelationTypeId { get; set; }

    public vTicketRelation() { }
}
