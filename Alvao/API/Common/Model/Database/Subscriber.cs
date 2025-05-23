using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing information on the customer and on the ticket on which information is taken.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Subscriber.htm"/>
[TableAttribute("dbo.Subscriber")]
public class Subscriber {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Subscriber_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Subscriber_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Subscriber_SinceDate.htm"/>
    public virtual DateTime? SinceDate { get; set; }
    /// <summary>Id of the user who set the subscription.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Subscriber_SubscribedByPerson.htm"/>
    public virtual int? SubscribedByPerson { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Subscriber_TicketId.htm"/>
    public virtual int TicketId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Subscriber__ctor.htm"/>
    public Subscriber() { }
}
