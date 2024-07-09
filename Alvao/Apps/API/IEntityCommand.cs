using Alvao.API.Common.Model.CustomApps;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing this interface, you can define custom commands for an object or a ticket. For an example, see the CostsCalculation application template.
/// In the application, create a new script using the IEntityCommand template and name it appropriately according to the functionality of the custom command.
/// In the newly created script, set the following properties in the constructor of the class:
///    Id - a unique command identifier (string)
///    Entity - the type of entity for which the command will be displayed(Entity.Ticket or Entity.Object).
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/i-entity-command"/>
public interface IEntityCommand
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    /// <summary>
    /// This method controls display of the command in command menus
    ///
    /// Tip: By calling this method in the Run method, you can check if the conditions for displaying the command haven't changed between the time of displaying the command and running it.
    /// </summary>
    ///
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.">SqlConnection to the database.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/i-entity-command#Show"/>
    EntityCommandShowResult Show(int entityId, int personId);

    /// <summary>
    /// This method implements the command itself.
    ///
    /// Tip: If the custom command is to open another Alvao WebApp page, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API to get the root URL of the WebApp.
    /// </summary>
    ///
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.">SqlConnection to the database.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/i-entity-command#Run"/>
    CommandResult Run(int entityId, int personId);
}
