using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Overview of ticket participants on requirements.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vRequestParticipant.htm"/>
[TableAttribute("dbo.vRequestParticipant")]
public class vRequestParticipant
{
    /// <summary>Ticket participant ID with the lowest ID (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vRequestParticipant_FirstParticipantPersonId.htm"/>
    public virtual int? FirstParticipantPersonId { get; set; }
    /// <summary>Number ticket participants</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vRequestParticipant_ParticipantCount.htm"/>
    public virtual int? ParticipantCount { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vRequestParticipant_TicketId.htm"/>
    public virtual int TicketId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vRequestParticipant__ctor.htm"/>
    public vRequestParticipant() { }
}
