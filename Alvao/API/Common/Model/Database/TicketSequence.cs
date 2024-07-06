using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// A table containing the next ticket number.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketSequence.htm"/>
[TableAttribute("dbo.TicketSequence")]
public class TicketSequence
{
    /// <summary>Next ticket number</summary>
    public virtual int NextTicketId { get; set; }

    public TicketSequence() { }
}
