using Alvao.API.Common.Model.CustomApps;

namespace Alvao.Apps.API;

/// <summary>By implementing this interface, you can define custom commands for an object or a ticket.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command"/>
public interface IEntityCommand {
    /// <summary>This method controls display of the command in command menus.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command#show"/>
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command should be displayed.</param>
    /// <param name="personId">the ID of the user(tPerson.iPersonId) to whom the command should be displayed.</param>
    /// <returns>An instance of the class EntityCommandShowResult with properties:<br/>- Name (string) - a display name of the command<br/>- Show (bool) - true = the command will be displayed, false = the command will not be displayed.<br/>- Position (int) - the position in UI at which the command will be displayed:<br/>- 1 = first position of the entity main menu<br/>- 2 = last position of the entity main menu<br/>- 3 = first position of the nested menu in the entity main menu<br/>- 4 = last position of the nested menu in the entity main menu<br/>- Icon(string) - a command icon name; Use the Microsoft fluent library viewer with “20 Regular” filter on. After finding the most suitable icon, copy its name without “fluent:” and replace “-“ characters with “_”.<br/>- Example: The icon fluent: edit - 20 - regular use in your code as edit_20_regular.</returns>
    EntityCommandShowResult Show(int entityId, int personId);
    /// <summary>This method implements the command itself.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/i-entity-command#run"/>
    /// <param name="entityId">the entity ID (tblNode.intNodeId or tHdTicket.iHdTicketId) for which the command was run.</param>
    /// <param name="personId">the user ID(tPerson.iPersonId) who ran the command.</param>
    /// <returns>An instance of the CommandResult class containing properties:<br/><br/><br/>- MessageType (MessageType) - specify whether a message should be displayed to the user as a result of the command execution:<br/>- None – no message will be displayed<br/>- Info - an information message will be displayed<br/>- Warning - a warning message will be displayed<br/>- Error - an error message will be displayed<br/>- MessageText(string) - specify a text of the message that will be displayed to the user.<br/>- NavigateToUrl(string) - optionally specify an URL to navigate to after the command execution.</returns>
    CommandResult Run(int entityId, int personId);
}
