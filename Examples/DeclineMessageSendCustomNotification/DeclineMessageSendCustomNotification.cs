using System;
using Microsoft.Data.SqlClient;
using System.Net.Mail;
using Alvao.API;
using Alvao.Apps.API;

public class DeclineMessageSendCustomNotification : IMailMessageAutoAction
{
    public string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DeclineMessageSendCustomNotification()
    {
        name = "Send your own notification about request denial because of SLA reasons";
    }

    public bool OnMessageReceived(SqlConnection con, SqlTransaction trans, Rebex.Mail.MailMessage message, int sectionId, int ticketId, int fromPersonId)
    {       
        bool supportedService = Array.Exists(Settings.SupportedServices, element => element == sectionId);
        if (ticketId == 0 && supportedService)
        {            
            if (!Helpers.UserHasSla(fromPersonId, sectionId, con, trans))
            {
                // Last two parameters are localization texts for HTML body message.
                // If you want to add more, or swap for different language, modify this method call and method GetMailBody in Helpers script.
                MailMessage msg = Helpers.GetMailBody(sectionId, message, fromPersonId, Settings.MailMessageCzech, Settings.MailMessageEnglish);
                Alvao.API.Common.Email.Queue(msg);
                return false;
            }
            return true;
        }
        else
        {
            return true;  
        }
    }
}
