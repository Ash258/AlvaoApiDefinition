using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A record from the history of the last viewed tickets of the requester.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html"/>
[Table("dbo.PersonTicketDisplay")]
public class PersonTicketDisplay {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html#Alvao_API_Common_Model_Database_PersonTicketDisplay_EventsNotDisplayed"/>
    public virtual bool EventsNotDisplayed { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html#Alvao_API_Common_Model_Database_PersonTicketDisplay_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Date and time of the last view of the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html#Alvao_API_Common_Model_Database_PersonTicketDisplay_LastDisplayed"/>
    public virtual DateTime? LastDisplayed { get; set; }
    /// <summary>ID of the person who viewed the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html#Alvao_API_Common_Model_Database_PersonTicketDisplay_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Viewed ticket number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonTicketDisplay.html#Alvao_API_Common_Model_Database_PersonTicketDisplay_TicketId"/>
    public virtual int TicketId { get; set; }
}
