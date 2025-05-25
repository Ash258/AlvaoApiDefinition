using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping request diary act methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Act.html"/>
public static class Act {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Act.html#Alvao_API_SD_Act_CanRead_System_Int32_System_Int32_"/>
    public static bool CanRead(int actId, int personId) { throw new System.NotImplementedException(); }
    /// <summary>Creates new act in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Act.html#Alvao_API_SD_Act_Create_System_Int32_System_String_Alvao_API_Common_Model_HtmlTextModel_Alvao_API_Common_Model_Database_tPerson_Alvao_API_Common_Model_Database_tPerson_Alvao_API_Common_Model_Database_tActKind_ActKind_Alvao_API_SD_Model_ActCreateSettings_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Subject</param>
    /// <param name="message">Text</param>
    /// <param name="fromPerson">Person (from) (tPerson)</param>
    /// <param name="toPerson">Person (to) (tPerson)</param>
    /// <param name="actKind">Act kind(tActKind.iActKindId)</param>
    /// <param name="settings">Multiple settings of act properties</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when ticketId, subject, message or fromPerson is null or empty.
    /// </exception>
    /// <exception cref="ValidationException">
    /// Throws when person fromPerson cannot create act in request with ticketId or mail receivers emails are not valid.
    /// </exception>
    /// <returns>Created act(tAct)</returns>
    public static tAct Create(int ticketId, string subject, HtmlTextModel message, tPerson fromPerson, tPerson toPerson, tActKind.ActKind actKind, ActCreateSettings settings) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// //Create note in request
    /// int ticketId = 50; //Request id
    /// int authorId = 25; //Author of the note
    /// Alvao.API.Common.Model.HtmlTextModel message = new Alvao.API.Common.Model.HtmlTextModel("Note in HTML"); //Create note model
    /// Alvao.API.SD.Model.ActCreateSettings settings = new Alvao.API.SD.Model.ActCreateSettings
    /// {
    ///     ShowToRequester = true //Note is displayed to requester
    /// };
    /// Alvao.API.SD.Act.Create(ticketId, "Subject of note", message, authorId, null, Alvao.API.Common.Model.Database.tActKind.ActKind.Note, settings); //Create note
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Act.html#Alvao_API_SD_Act_Create_System_Int32_System_String_Alvao_API_Common_Model_HtmlTextModel_System_Int32_System_Nullable_System_Int32__Alvao_API_Common_Model_Database_tActKind_ActKind_Alvao_API_SD_Model_ActCreateSettings_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Subject</param>
    /// <param name="message">Text</param>
    /// <param name="fromPersonId">Person ID (from) (tPerson.iPersonId)</param>
    /// <param name="toPersonId">Person ID (to) (tPerson.iPersonId)</param>
    /// <param name="actKind">Act kind(tActKind.iActKindId)</param>
    /// <param name="settings">Multiple settings of act properties</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when ticketId, subject, message or fromPersonId is null or empty.
    /// </exception>
    /// <exception cref="ValidationException">
    /// Throws when person with fromPersonId cannot create act in request with ticketId or mail receivers emails are not valid.
    /// </exception>
    /// <returns>Created act(tAct)</returns>
    public static tAct Create(int ticketId, string subject, HtmlTextModel message, int fromPersonId, int? toPersonId, tActKind.ActKind actKind, ActCreateSettings settings) { throw new System.NotImplementedException(); }
    /// <summary>Creates new act, which informs users that a bound request was created</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Act.html#Alvao_API_SD_Act_CreateAboutNewBoundTicket_System_Int32_System_String_"/>
    /// <param name="ticketId">Request ID, where this act is created (tHdTicket.iHdTicketId)</param>
    /// <param name="ticketMark">New bound request mark (tHdTicket.sHdTicketMessageTag)</param>
    public static void CreateAboutNewBoundTicket(int ticketId, string ticketMark) { throw new System.NotImplementedException(); }
}
