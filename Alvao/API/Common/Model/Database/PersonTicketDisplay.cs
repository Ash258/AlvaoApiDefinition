using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// A record from the history of the last viewed tickets of the requester.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonTicketDisplay.htm"/>
[TableAttribute("dbo.PersonTicketDisplay")]
public class PersonTicketDisplay
{
    public virtual bool EventsNotDisplayed { get; set; }
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Date and time of the last view of the ticket.</summary>
    public virtual DateTime? LastDisplayed { get; set; }
    /// <summary>ID of the person who viewed the ticket.</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Viewed ticket number.</summary>
    public virtual int TicketId { get; set; }

    public PersonTicketDisplay() { }
}
