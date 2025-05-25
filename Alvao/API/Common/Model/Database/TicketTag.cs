using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>User tag of the ticket</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTag.html"/>
[Table("dbo.TicketTag")]
public class TicketTag {
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTag.html#Alvao_API_Common_Model_Database_TicketTag_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTag.html#Alvao_API_Common_Model_Database_TicketTag_TicketId"/>
    public virtual int TicketId { get; set; }
    /// <summary>Tag type (TicketTagType.id)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTag.html#Alvao_API_Common_Model_Database_TicketTag_TicketTagTypeId"/>
    public virtual int TicketTagTypeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTag.html#Alvao_API_Common_Model_Database_TicketTag_id"/>
    [Key]
    public virtual int id { get; set; }
}
