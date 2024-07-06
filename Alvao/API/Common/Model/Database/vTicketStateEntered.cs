using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Arrivals to individual ticket statuses.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketStateEntered.htm"/>
[TableAttribute("dbo.vTicketStateEntered")]
public class vTicketStateEntered
{
    /// <summary>Time of transition to status</summary>
    public virtual DateTime? StateEntered { get; set; }
    /// <summary>The ticket identification number.</summary>
    public virtual int TicketId { get; set; }
    /// <summary>Status name.</summary>
    public virtual string TicketState { get; set; }
    /// <summary>Identification number of the ticket status.</summary>
    public virtual int TicketStateId { get; set; }

    public vTicketStateEntered() { }
}
