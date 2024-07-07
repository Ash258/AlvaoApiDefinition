using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping request diary act methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Act.htm"/>
public static class Act
{
    public enum TicketLogMode
    {
        None = 0,
        Communication = 1,
        Important = 2,
        Detailed = 3,
        Attachments = 4,
        Requester = 5,
    }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Act_CanRead.htm"/>
    ///
    /// <param name="actId"> </param>
    /// <param name="personId"> </param>
    public static bool CanRead(
        int actId,
        int personId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates new act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Act_Create.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Subject</param>
    /// <param name="message">Text</param>
    /// <param name="fromPerson">Person (from) (tPerson)</param>
    /// <param name="toPerson">Person (to) (tPerson)</param>
    /// <param name="actKind">Act kind(tActKind.iActKindId)</param>
    /// <param name="settings">Multiple settings of act properties</param>
    public static tAct Create(
        int ticketId,
        string subject,
        HtmlTextModel message,
        tPerson fromPerson,
        tPerson toPerson,
        tActKind.ActKind actKind,
        ActCreateSettings settings
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates new act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Act_Create_1.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Subject</param>
    /// <param name="message">Text</param>
    /// <param name="fromPersonId">Person ID (from) (tPerson.iPersonId)</param>
    /// <param name="toPersonId">Person ID (to) (tPerson.iPersonId)</param>
    /// <param name="actKind">Act kind(tActKind.iActKindId)</param>
    /// <param name="settings">Multiple settings of act properties</param>
    public static tAct Create(
        int ticketId,
        string subject,
        HtmlTextModel message,
        int fromPersonId,
        int? toPersonId,
        tActKind.ActKind actKind,
        ActCreateSettings settings
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Creates new act, which informs users that a bound request was created</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Act_CreateAboutNewBoundTicket.htm"/>
    ///
    /// <param name="ticketId">Request ID, where this act is created (tHdTicket.iHdTicketId)</param>
    /// <param name="ticketMark">New bound request mark (tHdTicket.sHdTicketMessageTag)</param>
    public static void CreateAboutNewBoundTicket(
        int ticketId,
        string ticketMark
    )
    { throw new System.NotImplementedException(); }
}
