using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>A table containing the next ticket number.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketSequence.html"/>
[Table("dbo.TicketSequence")]
public class TicketSequence {
    /// <summary>Next ticket number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketSequence.html#Alvao_API_Common_Model_Database_TicketSequence_NextTicketId"/>
    public virtual int NextTicketId { get; set; }
}
