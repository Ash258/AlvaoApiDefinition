using System;
using Alvao.API.Common;
using Alvao.API.Common.Model.CustomApps;
using Alvao.Apps.API;

public class SectionKnowledges : IEntityTab
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public SectionKnowledges()
    {
        Id = Settings.SK_TabName.GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityTabShowResult Show(int entityId, int personId)
    {
        bool show = false;
        string name = Settings.SK_TabName;
        string url = string.Empty;

        try
        {
            var ticket = Alvao.API.SD.Ticket.GetById(entityId);
            if (ticket == null)
            {
                return new EntityTabShowResult(show, name, url);
            }

            //Check if the request service is in the service list
            int sectionId = ticket.liHdTicketHdSectionId;
            if (Settings.SupportedServices != null && Array.IndexOf(Settings.SupportedServices, sectionId) == -1)
            {
                return new EntityTabShowResult(show, name, url);
            }

            var teamRoles = PersonRights.TicketRoles.SectionManager | PersonRights.TicketRoles.SectionMainSolver | PersonRights.TicketRoles.SectionSolver;
            show = PersonRights.HaveTicketRole(personId, entityId, sectionId, teamRoles, true);


            //Show only to members of the Service team
            if (show)
            {
                string webAppUrl = DbProperty.WebAppUrl;
                if (!string.IsNullOrEmpty(webAppUrl))
                {
                    //Address of tab with articles from knowledge base
                    url = webAppUrl + "/KnowledgeBase?id=" + sectionId;
                }
            }
        }
        catch
        {
            return new EntityTabShowResult(show, name, url);
        }

        return new EntityTabShowResult(show, name, url);
    }
}
