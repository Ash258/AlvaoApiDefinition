using Alvao.API.Common.Model.CustomApps;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing this interface, you can define custom tabs on the object or ticket page. A custom tab can view any web content displayable in an iframe tag. For an example, see the ShowRequesterAddress application template.
/// 
/// In the application create a new script using the IElementTab template and name it appropriately according to the content of the tab. In the newly created script, set the following properties in the constructor of the class:
///     Id - a unique tab identifier (string)
///     Entity - the type of entity for which the tab will be displayed (Entity.Ticket or Entity.Object).
/// By implementing this interface, you can define custom commands for an object or a ticket. For an example, see the CostsCalculation application template.
/// In the application, create a new script using the IEntityCommand template and name it appropriately according to the functionality of the custom command.
/// In the newly created script, set the following properties in the constructor of the class:
///    Id - a unique command identifier (string)
///    Entity - the type of entity for which the command will be displayed(Entity.Ticket or Entity.Object).
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/i-entity-tab"/>
public interface IEntityTab
{
    public string Id { get; set; }
    public Entity Entity { get; set; }

    /// <summary>
    /// This method handles the display of the entity custom tab.
    ///
    /// Tip: If the custom tab is to display a different page from the Alvao WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API interface to get the root URL.
    /// </summary>
    ///
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the custom tab should be displayed.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) to whom the command should be displayed.">SqlConnection to the database.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/i-entity-tab#Show"/>
    EntityTabShowResult Show(int entityId, int personId);
}
