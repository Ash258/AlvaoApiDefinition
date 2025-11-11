using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IGeneralCommand interface in a application script, you can define custom main menu commands.
///                 By placing a command in the main menu, you can give users access to frequently used pages and operations that are not tied to a specific ticket in ALVAO Service Desk or Asset Management function. Commands are displayed in the main menu of the Alvao WebApp application. In the Service Desk or Asset Management application, create a new script using the IGeneralCommand template and name it appropriately according to the functionality of the custom command. In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:
/// </summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands"/>
public interface IGeneralCommand {
    /// <summary>This method checks the defined conditions for displaying the command.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands/#show"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="personId">User ID (tPerson.iPersonId) to which the command should be displayed.</param>
    /// <returns>The true value of whether the command should be displayed to the user in the main menu of the application.</returns>
    bool Show(SqlConnection con, int personId);
    /// <summary>This method runs the command itself.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/general-custom-commands/#run"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="personId">The user ID (tPerson.iPersonId) that runs the command.</param>
    /// <returns>- bool - the truth value of whether the command was executed.<br/>- string - text that can be displayed in the message to the user.<br/>- string - URL to open in the browser.</returns>
    Tuple<bool, string, string> Run(SqlConnection con, int personId);
}
