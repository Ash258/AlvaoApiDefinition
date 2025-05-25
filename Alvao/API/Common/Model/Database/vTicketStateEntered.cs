using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Arrivals to individual ticket statuses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateEntered.html"/>
[Table("dbo.vTicketStateEntered")]
public class vTicketStateEntered {
    /// <summary>Time of transition to status</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateEntered.html#Alvao_API_Common_Model_Database_vTicketStateEntered_StateEntered"/>
    public virtual DateTime? StateEntered { get; set; }
    /// <summary>The ticket identification number.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateEntered.html#Alvao_API_Common_Model_Database_vTicketStateEntered_TicketId"/>
    public virtual int TicketId { get; set; }
    /// <summary>Status name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateEntered.html#Alvao_API_Common_Model_Database_vTicketStateEntered_TicketState"/>
    public virtual string TicketState { get; set; }
    /// <summary>Identification number of the ticket status.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStateEntered.html#Alvao_API_Common_Model_Database_vTicketStateEntered_TicketStateId"/>
    public virtual int TicketStateId { get; set; }
}
