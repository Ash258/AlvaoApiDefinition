using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of child tickets that person should see.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vChildTicketPersonRead.htm"/>
[TableAttribute("dbo.vChildTicketPersonRead")]
public class vChildTicketPersonRead
{
    /// <summary>Ticket ID of child ticket (tHdTicket.iHdTicketId).</summary>
    public virtual int ChildTicketId { get; set; }
    /// <summary>Ticket ID of parent ticket (tHdTicket.iHdTicketId).</summary>
    public virtual int ParentTicketId { get; set; }
    /// <summary>User ID (tPerson.iPersonId).</summary>
    public virtual int? PersonId { get; set; }

    public vChildTicketPersonRead() { }
}
