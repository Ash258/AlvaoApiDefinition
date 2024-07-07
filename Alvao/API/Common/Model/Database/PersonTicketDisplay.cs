using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// A record from the history of the last viewed tickets of the requester.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonTicketDisplay.htm"/>
[TableAttribute("dbo.PersonTicketDisplay")]
public class PersonTicketDisplay
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonTicketDisplay_EventsNotDisplayed.htm"/>
    public virtual bool EventsNotDisplayed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonTicketDisplay_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Date and time of the last view of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonTicketDisplay_LastDisplayed.htm"/>
    public virtual DateTime? LastDisplayed { get; set; }
    /// <summary>ID of the person who viewed the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonTicketDisplay_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Viewed ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonTicketDisplay_TicketId.htm"/>
    public virtual int TicketId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_PersonTicketDisplay__ctor.htm"/>
    public PersonTicketDisplay() { }
}
