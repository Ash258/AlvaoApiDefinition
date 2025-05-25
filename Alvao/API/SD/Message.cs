using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Database;
using Alvao.API.SD.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping email methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html"/>
public static class Message {
    /// <summary>Get recipients list with correct settings for receiving email notification</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_GetMailNotificationRecipientList_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="recipientIds">List of ids of all users</param>
    public static IEnumerable<tPerson> GetMailNotificationRecipientList(IEnumerable<int> recipientIds) { throw new System.NotImplementedException(); }
    /// <summary>Crops message subject to correct length and add ticket tag.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_GetSubject_System_String_System_String_System_String_System_Int32_"/>
    /// <param name="subject">Original subject</param>
    /// <param name="ticketTag">Ticket tag</param>
    /// <param name="prefix">FW:/RE:</param>
    /// <param name="maxSubjectLength">0 â keep default</param>
    /// <returns>Returns correct subject format.</returns>
    public static string GetSubject(string subject, string ticketTag, string prefix = "", int maxSubjectLength = 0) { throw new System.NotImplementedException(); }
    /// <summary>Checks if the text value contains any strings used for automatic replies in the Auto-Submitted header of email.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_IsAutoReplyHeader_System_String_"/>
    /// <param name="value">Text of Auto-Submitted header</param>
    /// <returns>Returns true if the email is an automatic reply, otherwise false.</returns>
    public static bool IsAutoReplyHeader(string value) { throw new System.NotImplementedException(); }
    /// <summary>Checks if the message subject contains any pattern used for automatic reply.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_IsAutoReplySubject_System_String_"/>
    /// <param name="subject">Message subject</param>
    /// <returns>Returns true if the subject text contains any pattern, otherwise false.</returns>
    public static bool IsAutoReplySubject(string subject) { throw new System.NotImplementedException(); }
    /// <summary>Parses multiple mail adresses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_ParseMulti_System_String_System_Boolean_"/>
    /// <param name="addresses">Mail adresses</param>
    /// <param name="removeServiceMail">Remove service mail address</param>
    /// <returns>List of mail models, number of valid mails and number of removed service mails</returns>
    public static (List<EmailModel>, int, int) ParseMulti(string addresses, bool removeServiceMail = true) { throw new System.NotImplementedException(); }
    /// <summary>Parses multiple mail adresses and validate them.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_ParseMultiAndValidate_System_String_"/>
    /// <param name="addresses">Mail adresses</param>
    /// <returns>List of mail models, true if adresses are valid and number of removed service mails</returns>
    public static (List<EmailModel>, bool, int) ParseMultiAndValidate(string addresses) { throw new System.NotImplementedException(); }
    /// <summary>Removes RE: and FW: tag from subject.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_RemoveLeadingRefw_System_String_"/>
    /// <param name="subject">Subject</param>
    /// <returns>Subject without RE or FW tag</returns>
    public static string RemoveLeadingRefw(string subject) { throw new System.NotImplementedException(); }
    /// <summary>Removes section mails from recipients.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_RemoveSectionEmails_System_Collections_Generic_List_Alvao_API_SD_Model_EmailModel__"/>
    /// <param name="mailRecipients">Mail recipients</param>
    /// <exception cref="ArgumentNullException">Throws when mailRecipients is null.</exception>
    /// <returns>Recipients without section mails</returns>
    public static (List<EmailModel>, int) RemoveSectionEmails(List<EmailModel> mailRecipients) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// //Send message with attachment from request and save to diary of request
    /// public class Attachment : Alvao.API.Common.Model.IAttachment
    /// {
    ///     private Alvao.API.Common.Model.Database.tDocument document;
    ///     public Attachment(Alvao.API.Common.Model.Database.tDocument document)
    ///     {
    ///         this.document = document;
    ///     }
    ///     public string Name =&gt; document.sDocument;
    ///     public Guid UniqueName { get; } = Guid.NewGuid();
    ///     public int? DocumentId
    ///     {
    ///         get =&gt; document.iDocumentId == 0 ? null : (int?)document.iDocumentId;
    ///         set =&gt; document.iDocumentId = value ?? 0;
    ///     }
    ///     public string ContentType =&gt; document.sDocumentContentType;
    ///     public string Url =&gt; document.Url;
    ///     public bool EmbeddedImage =&gt; document.EmbededImage;
    ///     public Stream GetStream()
    ///     {
    ///         return new MemoryStream(document.oDocument);
    ///     }
    /// }
    /// 
    /// Alvao.API.Common.Model.Database.tDocument document = new Alvao.API.Common.Model.Database.tDocument(); //Create document
    /// document.sDocument = "file.png"; //Document name
    /// document.sDocumentContentType = "application/octet-stream"; //Document type
    /// Stream s = System.IO.File.Open("file.png", FileMode.Open, FileAccess.Read, FileShare.Read); //Open document
    /// document.oDocument = new byte[s.Length];
    /// s.ReadAllBuffered(document.oDocument); //Document stream
    /// Attachment attachment = new Attachment(document); //Create attachment from document
    /// List&lt;Alvao.API.Common.Model.IAttachment&gt; Attachments = new List&lt;Alvao.API.Common.Model.IAttachment&gt;(); //Create list of attachments
    /// Attachments.Add(attachment); //Insert attachment into list
    /// Alvao.API.Common.Model.HtmlTextModel emailMessage = new Alvao.API.Common.Model.HtmlTextModel("Message in HTML", Attachments); //Create message with attachment
    /// Alvao.API.SD.Model.SendMessageSettingsModel emailModel = new Alvao.API.SD.Model.SendMessageSettingsModel(); //Create email model
    /// int ticketId = 50; //Request id
    /// int fromPersonId = 25; //Email sender id
    /// int toPersonId = 8; //Email recipient
    /// Alvao.API.Common.Model.Database.tPerson personTo = Alvao.API.Common.Person.GetById(toPersonId); //Get recipient by id
    /// emailModel.RecipientsTo = personTo.sPersonEmail; //Set recipient email
    /// Alvao.API.SD.Message.Send(ticketId, "Subject of email", fromPersonId, emailMessage, emailModel); //Send message
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_Send_System_Int32_System_String_System_Int32_Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_SendMessageSettingsModel_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Message subject</param>
    /// <param name="fromPersonId">Person ID of message author (tPerson.iPersonId)</param>
    /// <param name="message">Message body</param>
    /// <param name="settings">Multiple settings of message</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <returns>Created act (tAct)</returns>
    public static tAct Send(int ticketId, string subject, int fromPersonId, HtmlTextModel message, SendMessageSettingsModel settings) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// //Send message with attachment from request and save to diary of request
    /// public class Attachment : Alvao.API.Common.Model.IAttachment
    /// {
    ///     private Alvao.API.Common.Model.Database.tDocument document;
    ///     public Attachment(Alvao.API.Common.Model.Database.tDocument document)
    ///     {
    ///         this.document = document;
    ///     }
    ///     public string Name =&gt; document.sDocument;
    ///     public Guid UniqueName { get; } = Guid.NewGuid();
    ///     public int? DocumentId
    ///     {
    ///         get =&gt; document.iDocumentId == 0 ? null : (int?)document.iDocumentId;
    ///         set =&gt; document.iDocumentId = value ?? 0;
    ///     }
    ///     public string ContentType =&gt; document.sDocumentContentType;
    ///     public string Url =&gt; document.Url;
    ///     public bool EmbeddedImage =&gt; document.EmbededImage;
    ///     public Stream GetStream()
    ///     {
    ///         return new MemoryStream(document.oDocument);
    ///     }
    /// }
    /// 
    /// Alvao.API.Common.Model.Database.tDocument document = new Alvao.API.Common.Model.Database.tDocument(); //Create document
    /// document.sDocument = "file.png"; //Document name
    /// document.sDocumentContentType = "application/octet-stream"; //Document type
    /// Stream s = System.IO.File.Open("file.png", FileMode.Open, FileAccess.Read, FileShare.Read); //Open document
    /// document.oDocument = new byte[s.Length];
    /// s.ReadAllBuffered(document.oDocument); //Document stream
    /// Attachment attachment = new Attachment(document); //Create attachment from document
    /// List&lt;Alvao.API.Common.Model.IAttachment&gt; Attachments = new List&lt;Alvao.API.Common.Model.IAttachment&gt;(); //Create list of attachments
    /// Attachments.Add(attachment); //Insert attachment into list
    /// Alvao.API.Common.Model.HtmlTextModel emailMessage = new Alvao.API.Common.Model.HtmlTextModel("Message in HTML", Attachments); //Create message with attachment
    /// Alvao.API.SD.Model.SendMessageSettingsModel emailModel = new Alvao.API.SD.Model.SendMessageSettingsModel(); //Create email model
    /// int ticketId = 50; //Request id
    /// int fromPersonId = 25; //Email sender id
    /// int toPersonId = 8; //Email recipient
    /// Alvao.API.Common.Model.Database.tPerson personTo = Alvao.API.Common.Person.GetById(toPersonId); //Get recipient by id
    /// emailModel.RecipientsTo = personTo.sPersonEmail; //Set recipient email
    /// Alvao.API.SD.Message.SendMessage(ticketId, "Subject of email", fromPersonId, emailMessage, emailModel); //Send message
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_SendMessage_System_Int32_System_String_System_Int32_Alvao_API_Common_Model_HtmlTextModel_Alvao_API_SD_Model_SendMessageSettingsModel_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="subject">Message subject</param>
    /// <param name="fromPersonId">Person ID of message author (tPerson.iPersonId)</param>
    /// <param name="message">Message body</param>
    /// <param name="settings">Multiple settings of message</param>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <returns>Created act (tAct)</returns>
    [Obsolete("SendMessage is deprecated, please use Send instead.")]
    public static tAct SendMessage(int ticketId, string subject, int fromPersonId, HtmlTextModel message, SendMessageSettingsModel settings) { throw new System.NotImplementedException(); }
    /// <summary>Valides mail adresses in string.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Message.html#Alvao_API_SD_Message_Validate_System_String_System_Boolean_"/>
    /// <param name="addresses">Mail adresses</param>
    /// <param name="multi">There are multiple adresses in adresses</param>
    /// <returns>Returns true if all adresses are valid, otherwise false</returns>
    public static bool Validate(string addresses, bool multi) { throw new System.NotImplementedException(); }
}
