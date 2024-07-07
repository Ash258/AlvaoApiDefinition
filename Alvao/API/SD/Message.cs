using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>
/// Facade class grouping email methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Message.htm"/>
public static class Message
{

    /// <summary>Get recipients list with correct settings for receiving email notification</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_GetMailNotificationRecipientList.htm"/>
    ///
    /// <param name="recipientIds">List of ids of all users</param>
    public static IEnumerable<tPerson> GetMailNotificationRecipientList(
        IEnumerable<int> recipientIds
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Crops message subject to correct length and add ticket tag.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_GetSubject.htm"/>
    ///
    /// <param name="subject">Original subject</param>
    /// <param name="ticketTag">Ticket tag</param>
    /// <param name="prefix">FW:/RE:</param>
    public static string GetSubject(
        string subject,
        string ticketTag,
        string prefix = ""
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks if the text value contains any strings used for automatic replies in the Auto-Submitted header of email.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_IsAutoReplyHeader.htm"/>
    ///
    /// <param name="value">Text of Auto-Submitted header</param>
    public static bool IsAutoReplyHeader(
        string value
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks if the message subject contains any pattern used for automatic reply.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_IsAutoReplySubject.htm"/>
    ///
    /// <param name="subject">Message subject</param>
    public static bool IsAutoReplySubject(
        string subject
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Parses multiple mail adresses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_ParseMulti.htm"/>
    ///
    /// <param name="addresses">Mail adresses</param>
    /// <param name="removeServiceMail">Remove service mail address</param>
    public static (List<EmailModel>, int, int) ParseMulti(
        string addresses,
        bool removeServiceMail = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Parses multiple mail adresses and validate them.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_ParseMultiAndValidate.htm"/>
    ///
    /// <param name="addresses">Mail adresses</param>
    public static (List<EmailModel>, bool, int) ParseMultiAndValidate(
        string addresses
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes RE: and FW: tag from subject.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_RemoveLeadingRefw.htm"/>
    ///
    /// <param name="subject">Subject</param>
    public static string RemoveLeadingRefw(
        string subject
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes section mails from recipients.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_RemoveSectionEmails.htm"/>
    ///
    /// <param name="mailRecipients">Mail recipients</param>
    public static (List<EmailModel>, int) RemoveSectionEmails(
        List<EmailModel> mailRecipients
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Sends message within the request and creates new record in request diary.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_Send.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Message subject</param>
    /// <param name="fromPersonId">Person ID of message author (tPerson.iPersonId)</param>
    /// <param name="message">Message body</param>
    /// <param name="settings">Multiple settings of message</param>
    public static tAct Send(
        int ticketId,
        string subject,
        int fromPersonId,
        HtmlTextModel message,
        SendMessageSettingsModel settings
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Valides mail adresses in string.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Message_Validate.htm"/>
    ///
    /// <param name="addresses">Mail adresses</param>
    /// <param name="multi">There are multiple adresses in adresses</param>
    public static bool Validate(
        string addresses,
        bool multi
    )
    { throw new System.NotImplementedException(); }
}
