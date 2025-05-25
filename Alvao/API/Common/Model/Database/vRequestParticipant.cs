using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Overview of ticket participants on requirements.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vRequestParticipant.html"/>
[Table("dbo.vRequestParticipant")]
public class vRequestParticipant {
    /// <summary>Ticket participant ID with the lowest ID (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vRequestParticipant.html#Alvao_API_Common_Model_Database_vRequestParticipant_FirstParticipantPersonId"/>
    public virtual int? FirstParticipantPersonId { get; set; }
    /// <summary>Number ticket participants</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vRequestParticipant.html#Alvao_API_Common_Model_Database_vRequestParticipant_ParticipantCount"/>
    public virtual int? ParticipantCount { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vRequestParticipant.html#Alvao_API_Common_Model_Database_vRequestParticipant_TicketId"/>
    public virtual int TicketId { get; set; }
}
