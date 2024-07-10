using System;
using System.Linq;
using Alvao.Context;
using Alvao.Apps.API;
using Alvao.API.AM;
using Alvao.API.SD;
using Alvao.API.Common;
using Alvao.API.Common.Model.Database;
using Alvao.API.Common.Model.CustomApps;
using Dapper;

public class EntityTab : IEntityTab
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    public EntityTab()
    {
        Id = Settings.CMD_TabName.GetHashCode().ToString();
        Entity = Entity.Request;
    }

    public EntityTabShowResult Show(int entityId, int personId)
    {
        bool show = false;
        string name = Settings.CMD_TabName;
        string url = ""; // Url to show in the ticket tab.

        var ticket = Ticket.GetById(entityId);
        var listOfNodes = Relation.GetLinkedNodes(entityId);

        if (Settings.SupportedServices.Contains(ticket.liHdTicketHdSectionId) && // Check for a supported services.
            listOfNodes.Any() && // Ticket has some related objects.
            PersonRights.IsSectionRoleMemberForTicket(personId, entityId, PersonRights.SectionRoles.Solver | PersonRights.SectionRoles.MainSolver | PersonRights.SectionRoles.Manager) && // User is a member of the solver team for that service.
            PersonRights.HaveAnyAssetManagementRole(personId, false) && // User has ANY AM role -> can see objects.
            PersonRights.HaveGlobalRole(personId, PersonRights.GlobalRoles.AssetAdministrators | PersonRights.GlobalRoles.AssetRelationsManagers | PersonRights.GlobalRoles.AssetRelationsReaders, false)) // Can see CMDB diagram.
        {
            string waUrl = DbProperty.WebAppUrl; // WebApp address.

            if (!string.IsNullOrEmpty(waUrl))
            {
                int objectId = 0;
                using (var scope = AlvaoContext.GetConnectionScope())
                {
                    try
                    {
                        // Find object that is linked to the ticket and is not removed.
                        objectId = scope.Connection.ExecuteScalar<int>(@"
                            SELECT TOP 1 NodeId FROM TicketNode TN
                            LEFT JOIN tblNode N ON N.intNodeId = TN.NodeId
                            WHERE TN.TicketId = @ticketId and TN.Removed is null and N.IsRemoved = 0",
                        new { ticketId = entityId }, scope.LegacyTransaction);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                }

                if (objectId > 0 && ObjectRight.CheckForUser(personId, objectId, Alvao.API.AM.Model.ObjectRight.Right.CanObjectRead))
                {
                    // Vlastní formulář
                    string diagram = "/LinkDiagram/Index/" + objectId;
                    url = waUrl + diagram;
                    show = true;
                }
            }
        }

        return new EntityTabShowResult(show, name, url);
    }
}
