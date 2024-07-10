using System;
using System.Collections.Generic;
using System.IO;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Microsoft.Data.SqlClient;
using Alvao.Apps.API;
using Alvao.API.Common;
using Alvao.API.SD;
using Dapper;

public static class DMSCN_Helpers
{
    public static string MailMessageCzech;
    public static string MailMessageEnglish;

    // Chekcs if the user has SLA in the service.
    public static bool UserHasSla(int requesterId, int sectionId, SqlConnection con, SqlTransaction trans)
    {
        var slaCount = con.QueryFirstOrDefault<int?>(@"SELECT COUNT(*) FROM vSlaAccess WHERE liSlaAccessPersonId = @requesterId AND liSlaAccessHdSectionId = @sectionId",
        new { requesterId, sectionId }, trans);

        return slaCount.GetValueOrDefault(0) > 0;
    }

    // Get e-mail service.
    public static string GetSectionEmail(int sectionId)
    {
        var section = Section.GetById(sectionId);
        return section?.sHdSectionEmail ?? string.Empty;
    }

    // Creation of message body.
    public static MailMessage GetMailBody(int sectionId, Rebex.Mail.MailMessage message, int fromPersonId, string mailMessageCzech, string mailMessageEnglish)
    {
        MailMessageCzech = mailMessageCzech; // Defined at the beginning of Helpers class. Used in Localization class.
        MailMessageEnglish = mailMessageEnglish; // Defined at the beginning of Helpers class. Used in Localization class.

        var replyMessage = new MailMessage();

        replyMessage.From = new System.Net.Mail.MailAddress(DMSCN_Helpers.GetSectionEmail(sectionId));
        replyMessage.To.Add(message.From.ToString());

        if (!message.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
            replyMessage.Subject = "Re: ";

        replyMessage.Subject += message.Subject;

        string htmlBody = GetClearHtmlHead();
        htmlBody += Localization.GetLocalization(fromPersonId, "MailMessage");

        string newMessage = "<hr noshade style=\"border: 0;color: #B5C4DF;background-color: #B5C4DF;height:1px;\">";
        newMessage += "<span class=\"quoted_header_font\">";
        newMessage += "<b>" + HttpUtility.HtmlEncode(Localization.GetLocalization(fromPersonId, "From")) + ": </b>" + HttpUtility.HtmlEncode(message.From) + "<br />";
        newMessage += "<b>" + HttpUtility.HtmlEncode(Localization.GetLocalization(fromPersonId, "DateSent")) + ": </b>" + HttpUtility.HtmlEncode(message.Date) + "<br />";
        newMessage += "<b>" + HttpUtility.HtmlEncode(Localization.GetLocalization(fromPersonId, "To")) + ": </b>" + HttpUtility.HtmlEncode(message.To) + "<br />";
        newMessage += "<b>" + HttpUtility.HtmlEncode(Localization.GetLocalization(fromPersonId, "SubjectMail")) + ": </b>" + HttpUtility.HtmlEncode(message.Subject) + "<br />";

        newMessage += "</span><br /><span class=\"quoted_text_font\">";
        newMessage += HttpUtility.HtmlEncode(message.BodyText).Replace("\n", "<br />");
        newMessage += "</span>";
        htmlBody += newMessage;

        htmlBody += "<br /><br /></td></tr></table></body></html>";
        htmlBody = htmlBody.Replace("\r\n", "<br />");
        replyMessage.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(htmlBody, System.Text.Encoding.UTF8, "text/html"));

        return replyMessage;
    }

    public static string GetClearHtmlHead()
    {
        string head = "";
        string CSS = "";

        head += "<!DOCTYPE html><html><head><style>";

        CSS = DbProperty.HTMLHeader;
        CSS = CSS.Replace("};.", "}.");
        CSS = CSS.Replace("\r\n", "");
        CSS += ".msgbodyform p{margin: 0px; padding: 0px;}";
        // Outlook styles.
        // Leave on one line, otherwise \n will be replaced later for <br />.
        CSS += @"p.MsoNormal, li.MsoNormal, div.MsoNormal {margin:0cm; margin-bottom:.0001pt; font-size:11.0pt; font-family:'Calibri',sans-serif; mso-fareast-language:EN-US;}";
        CSS += @"p.MsoListParagraph, li.MsoListParagraph, div.MsoListParagraph{mso-style-priority:34; margin-top:0cm; margin-right:0cm; margin-bottom:0cm; margin-left:36.0pt; margin-bottom:.0001pt; font-size:11.0pt; font-family:'Calibri',sans-serif; mso-fareast-language:EN-US;}";
        head += CSS;
        head += "</style></head><body><table class=\"notification_border\"><tr width=\"600px\" style=\"width:600px\"><td width=\"600px\" style=\"width:600px\" class=\"base_font\">";

        return head;
    }
}
