using Alvao.API.Common.Model;
using System.Globalization;

namespace Alvao.API.SD;

/// <summary>Facade class grouping message templates methods</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_MessageTemplate.htm"/>
public static class MessageTemplate
{

    /// <summary>Evaluates template of message for approver.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_MessageTemplate_EvaluateMessageForApprover.htm"/>
    ///
    /// <param name="template">Message for approver template</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="actId">Message for approver ID tAct.iActId</param>
    /// <param name="language">Template language</param>
    /// <param name="commentForApprover">Comment for approver</param>
    public static string EvaluateMessageForApprover(
        string template,
        int ticketId,
        int? actId,
        CultureInfo language = null,
        HtmlTextModel commentForApprover = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Evaluates template of message for requester.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_MessageTemplate_EvaluateMessageForRequester.htm"/>
    ///
    /// <param name="template">Message for requester template</param>
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    /// <param name="language">Template language</param>
    /// <param name="requesterNotice">Do not use this param, it is for internal purposes only.</param>
    /// <param name="isAfterApproval">Do not use this param, it is for internal purposes only.</param>
    /// <param name="formatDateTimeToUniversalSortable">Do not use this param, it is for internal purposes only.</param>
    public static string EvaluateMessageForRequester(
        string template,
        int ticketId,
        CultureInfo language = null,
        HtmlTextModel requesterNotice = null,
        bool isAfterApproval = false,
        bool formatDateTimeToUniversalSortable = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get last approval result with comment</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_MessageTemplate_GetLastApprovalResultWithComment.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static string GetLastApprovalResultWithComment(
        int ticketId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get latest important message</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_MessageTemplate_GetLatestImportantMessage.htm"/>
    ///
    /// <param name="ticketId">Request ID (tHdTicket.iHdTicketId)</param>
    public static string GetLatestImportantMessage(
        int ticketId
    )
    { throw new System.NotImplementedException(); }
}
