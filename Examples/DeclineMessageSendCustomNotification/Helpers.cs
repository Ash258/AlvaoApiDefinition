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

public static class Helpers
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
	
		replyMessage.From = new System.Net.Mail.MailAddress(Helpers.GetSectionEmail(sectionId));                  
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
		CSS += @"p.MsoNormal, li.MsoNormal, div.MsoNormal {margin:0cm; margin-bottom:.0001pt; font-size:11.0pt; font-family:'Aptos','Calibri',sans-serif; mso-fareast-language:EN-US;}"; 
		CSS += @"p.MsoListParagraph, li.MsoListParagraph, div.MsoListParagraph{mso-style-priority:34; margin-top:0cm; margin-right:0cm; margin-bottom:0cm; margin-left:36.0pt; margin-bottom:.0001pt; font-size:11.0pt; font-family:'Aptos','Calibri',sans-serif; mso-fareast-language:EN-US;}";
		head += CSS;
		head += "</style></head><body><table class=\"notification_border\"><tr width=\"600px\" style=\"width:600px\"><td width=\"600px\" style=\"width:600px\" class=\"base_font\">";

		return head;
	}
}

public class Localization 
{	
    public static List<LocalizationItem> Localizations {
		get {
			return new List<LocalizationItem>() {
				new LocalizationItem(1029, "From", "Od"),
				new LocalizationItem(1031, "From", "Von"),
				new LocalizationItem(1033, "From", "From"),
				new LocalizationItem(1038, "From", "Kezdete"),
				new LocalizationItem(1045, "From", "Z"),
				new LocalizationItem(1051, "From", "Od"),

				new LocalizationItem(1029, "DateSent", "Datum"),
				new LocalizationItem(1031, "DateSent", "Date"),
				new LocalizationItem(1033, "DateSent", "Datum"),
				new LocalizationItem(1038, "DateSent", "Dátum"),
				new LocalizationItem(1045, "DateSent", "Data"),
				new LocalizationItem(1051, "DateSent", "Dátum"),

				new LocalizationItem(1029, "To", "Komu"),
				new LocalizationItem(1031, "To", "Dem"),
				new LocalizationItem(1033, "To", "To"),
				new LocalizationItem(1038, "To", "Kit"),
				new LocalizationItem(1045, "To", "Kogo"),
				new LocalizationItem(1051, "To", "Komu"),
				
				new LocalizationItem(1029, "SubjectMail", "Předmět"),
				new LocalizationItem(1031, "SubjectMail", "Fach"),
				new LocalizationItem(1033, "SubjectMail", "Subject"),
				new LocalizationItem(1038, "SubjectMail", "Tantárgy"),
				new LocalizationItem(1045, "SubjectMail", "Przedmiot"),
				new LocalizationItem(1051, "SubjectMail", "Predmet"),
				
				new LocalizationItem(1029, "MailMessage", Helpers.MailMessageCzech),
				new LocalizationItem(1031, "MailMessage", Helpers.MailMessageEnglish),
				new LocalizationItem(1033, "MailMessage", Helpers.MailMessageEnglish),
				new LocalizationItem(1038, "MailMessage", Helpers.MailMessageEnglish),
				new LocalizationItem(1045, "MailMessage", Helpers.MailMessageEnglish),
				new LocalizationItem(1051, "MailMessage", Helpers.MailMessageCzech),

			};
		}
	}

    public static string GetLocalization(int personId, string name)
	{
        var localeId = GetPersonLocaleId(personId);
        var translation = FindInList(localeId, name);

        if (string.IsNullOrEmpty(translation))
		{
            localeId = GetDefaultLocaleId();
            translation = FindInList(localeId, name);
			if (string.IsNullOrEmpty(translation))
            {
                localeId = Locale.GetDatabaseLocaleId();
                translation = FindInList(localeId, name); 
            }
        }

        return translation;
    }

    private static string FindInList(int localeId, string name) 
	{
        return Localizations.FirstOrDefault(x=>x.LocaleId == localeId && x.Name == name)?.Translation;
	}

	private static int GetDefaultLocaleId()
	{
		return Person.GetCultureInfoOrDefault(new Alvao.API.Common.Model.Database.tPerson()).LCID;
	}

	private static int GetPersonLocaleId(int personId)
	{
		var locale = Person.GetById(personId).iPersonLocaleId;
		
		if (!locale.HasValue)
		{
			return GetDefaultLocaleId();
		}

		return locale.Value;
	}
}

public class LocalizationItem 
{
	public int LocaleId { get; set; }
	public string Name { get; set; }
	public string Translation { get; set; }

	public LocalizationItem (int localeId, string name, string translation) 
	{
		this.LocaleId = localeId;
		this.Name = name;
		this.Translation = translation;
	}
}
