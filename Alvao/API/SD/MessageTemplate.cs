using System.Globalization;
using Alvao.API.Common.Model;

namespace Alvao.API.SD;

/// <summary>Facade class grouping message templates methods</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.MessageTemplate.html"/>
public static class MessageTemplate {
    /// <summary>Evaluates template of message for approver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.MessageTemplate.html#Alvao_API_SD_MessageTemplate_EvaluateMessageForApprover_System_String_System_Int32_System_Nullable_System_Int32__System_Globalization_CultureInfo_Alvao_API_Common_Model_HtmlTextModel_"/>
    /// <param name="template">Message for approver template</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="actId">Message for approver ID tAct.iActId</param>
    /// <param name="language">Template language</param>
    /// <param name="commentForApprover">Comment for approver</param>
    /// <exception cref="ArgumentNullException">Throws when template is null.</exception>
    /// <exception cref="ArgumentException">Throws when request with ticketId does not exist.</exception>
    /// <returns>Evaluated template</returns>
    public static string EvaluateMessageForApprover(string template, int ticketId, int? actId, CultureInfo language = null, HtmlTextModel commentForApprover = null) { throw new System.NotImplementedException(); }
    /// <summary>Evaluates template of message for requester.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.MessageTemplate.html#Alvao_API_SD_MessageTemplate_EvaluateMessageForRequester_System_String_System_Int32_System_Globalization_CultureInfo_Alvao_API_Common_Model_HtmlTextModel_System_Boolean_System_Boolean_"/>
    /// <param name="template">Message for requester template</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="language">Template language</param>
    /// <param name="requesterNotice">Do not use this param, it is for internal purposes only.</param>
    /// <param name="isAfterApproval">Do not use this param, it is for internal purposes only.</param>
    /// <param name="formatDateTimeToUniversalSortable">Do not use this param, it is for internal purposes only.</param>
    /// <returns>Evaluated template</returns>
    public static string EvaluateMessageForRequester(string template, int ticketId, CultureInfo language = null, HtmlTextModel requesterNotice = null, bool isAfterApproval = false, bool formatDateTimeToUniversalSortable = false) { throw new System.NotImplementedException(); }
    /// <summary>Get last approval result with comment</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.MessageTemplate.html#Alvao_API_SD_MessageTemplate_GetLastApprovalResultWithComment_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>Last approval result with comment or &quot;-&quot; if ticket does not contaisn any</returns>
    public static string GetLastApprovalResultWithComment(int ticketId) { throw new System.NotImplementedException(); }
    /// <summary>Get latest important message</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.MessageTemplate.html#Alvao_API_SD_MessageTemplate_GetLatestImportantMessage_System_Int32_"/>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <returns>Latest important message or &quot;-&quot; if ticket does not contaisn any</returns>
    public static string GetLatestImportantMessage(int ticketId) { throw new System.NotImplementedException(); }
}
