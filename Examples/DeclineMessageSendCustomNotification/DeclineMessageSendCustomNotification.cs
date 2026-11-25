using System;
using System.Threading;
using System.Threading.Tasks;
using Alvao.API;
using Alvao.Apps.API;
using Alvao.Context;

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

    public async Task<bool> OnMessageReceivedAsync(MailMessageEventArgs e, CancellationToken cancellationToken)
    {       
        bool supportedService = Array.Exists(Settings.SupportedServices, element => element == e.SectionId);
        if (e.TicketId == 0 && supportedService)
        {            
            if (!Helpers.UserHasSla(e.FromPersonId, e.SectionId))
            {
                // Last two parameters are localization texts for HTML body message.
                // If you want to add more, or swap for different language, modify this method call and method GetMailBody in Helpers script.
                Rebex.Mail.MailMessage msg = Helpers.GetMailBody(e.SectionId, e.Message, e.FromPersonId, Settings.MailMessageCzech, Settings.MailMessageEnglish);
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
