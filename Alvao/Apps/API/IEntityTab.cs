using Alvao.API.Common.Model.CustomApps;

namespace Alvao.Apps.API;

/// <summary>By implementing this interface, you can define custom tabs on the object or ticket page. A custom tab can view any web content displayable in an iframe tag. For an example, see the ShowRequesterAddress application template.<br/><br/>In the application create a new script using the IElementTab template and name it appropriately according to the content of the tab. In the newly created script, set the following properties in the constructor of the class:<br/> - Id - a unique tab identifier (string)<br/> - Entity - the type of entity for which the tab will be displayed(Entity.Ticket or Entity.Object).</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-tab"/>
public interface IEntityTab {
    /// <summary>This method handles the display of the entity custom tab.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-tab#show"/>
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the custom tab should be displayed.</param>
    /// <param name="personId">the ID of the user(tPerson.iPersonId) to whom the custom tab should be displayed.</param>
    /// <returns>An instance of the class EntityTabShowResult with properties:<br/>- Show (bool) - true = the tab will be displayed; false = the tab will not be displayed.<br/>- Name ( string) - a display name of the tab<br/>- Url ( string) - an URL of a content of the tab.</returns>
    EntityTabShowResult Show(int entityId, int personId);
}
