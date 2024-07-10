using System;
using Alvao.API.Common;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;
using Alvao.API.Common.Model.Database;
using MessageType = Alvao.API.Common.Model.CustomApps.MessageType;

public class TicketCreateOutlookMeetingCommand : IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public TicketCreateOutlookMeetingCommand()
    {
        Id = "TicketCreateOutlookMeeting".GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityCommandShowResult Show(int entityId, int personId)
    {
        int position = 2;
        string icon = "OutlookLogo";
        string name = "Create meeting";
        bool show = false;

        tHdTicket ticket = Alvao.API.SD.Ticket.GetById(entityId);

        if (ticket != null && ticket.liHdTicketHdSectionId > 0)
        {
            var teamRoles = PersonRights.TicketRoles.SectionManager | PersonRights.TicketRoles.SectionMainSolver | PersonRights.TicketRoles.SectionSolver;
            show = PersonRights.HaveTicketRole(personId, entityId, ticket.liHdTicketHdSectionId, teamRoles, true);
        }

        return new EntityCommandShowResult(show, name, icon, position);
    }

    public CommandResult Run(int entityId, int personId)
    {
        MessageType messageType = MessageType.None;
        string messageText = string.Empty;
        string navigateToUrl = string.Empty;

        try
        {
            var userMail = Person.GetById(personId).sPersonEmail;

            if (!string.IsNullOrEmpty(userMail))
            {
                // Get ticket info
                var waUrl = DbProperty.WebAppUrl;
                var ticket = Alvao.API.SD.Ticket.GetById(entityId);
                var ticketFullName = Settings.GetSubject(ticket.sHdTicket, ticket.sHdTicketMessageTag);
                var ticketUrl = "";
                if (!string.IsNullOrEmpty(waUrl))
                {
                    ticketUrl = waUrl + "/Ticket/" + entityId;
                }

                navigateToUrl = "https://outlook.office.com/calendar/deeplink/compose?subject=" + System.Net.WebUtility.UrlEncode(ticketFullName) + "&body=" + System.Net.WebUtility.UrlEncode(ticketUrl);
            }
        }
        catch (Exception e)
        {
            messageType = MessageType.Error;
            messageText = e.Message;
            return new CommandResult(messageType, messageText, navigateToUrl);
        }

        return new CommandResult(messageType, messageText, navigateToUrl);
    }
}
