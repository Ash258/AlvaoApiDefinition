using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// User tag of the ticket
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTag.htm"/>
[TableAttribute("dbo.TicketTag")]
public class TicketTag
{
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket (tHdTicket.iHdTicketId)</summary>
    public virtual int TicketId { get; set; }
    /// <summary>Tag type (TicketTagType.id)</summary>
    public virtual int TicketTagTypeId { get; set; }

    public TicketTag() { }
}
