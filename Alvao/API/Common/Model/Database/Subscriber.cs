using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing information on the customer and on the ticket on which information is taken.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html"/>
[Table("dbo.Subscriber")]
public class Subscriber {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_SinceDate"/>
    public virtual DateTime? SinceDate { get; set; }
    /// <summary>Id of the user who set the subscription.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_SubscribedByPerson"/>
    public virtual int? SubscribedByPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_TicketId"/>
    public virtual int TicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Subscriber.html#Alvao_API_Common_Model_Database_Subscriber_id"/>
    [Key]
    public virtual int id { get; set; }
}
