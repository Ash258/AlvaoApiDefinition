using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// A table containing information on the customer and on the ticket on which information is taken.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Subscriber.htm"/>
[TableAttribute("dbo.Subscriber")]
public class Subscriber
{
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int PersonId { get; set; }
    public virtual DateTime? SinceDate { get; set; }
    /// <summary>Id of the user who set the subscription.</summary>
    public virtual int? SubscribedByPerson { get; set; }
    public virtual int TicketId { get; set; }

    public Subscriber() { }
}
