using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing information on the customer and on the ticket on which information is taken.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html"/>
[Table("dbo.Subscriber")]
public class Subscriber {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_SinceDate"/>
    /// <remarks>Column <c>SinceDate</c>: datetime, null.</remarks>
    public virtual DateTime? SinceDate { get; set; }
    /// <summary>Id of the user who set the subscription.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_SubscribedByPerson"/>
    /// <remarks>Column <c>SubscribedByPerson</c>: int, null.</remarks>
    public virtual int? SubscribedByPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_TicketId"/>
    /// <remarks>Column <c>TicketId</c>: int, not null. References <see cref="tHdTicket"/>.</remarks>
    public virtual int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
