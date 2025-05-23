using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IGeneralCommand interface in a application script, you can define custom main menu commands.
///
/// By placing a command in the main menu, you can give users access to frequently used pages and operations that are not tied to a specific ticket in ALVAO Service Desk or Asset Management function.
/// Commands are displayed in the main menu of the Alvao WebApp application.
/// In the Service Desk or Asset Management application, create a new script using the IGeneralCommand template and name it appropriately according to the functionality of the custom command.
/// In the newly created script, set the id, name, position, and icon property values in the constructor of the command class:
///    id - command number (unique)
///    name - the name of the command that will be displayed in applications
///    position - the position at which the command will be displayed in applications
///        1 = in main menu under system commands
///        2 = in the main menu above the More menu
///        3 = in the main menu in the More menu above the Administration system command
///        4 = in the user menu above the Settings system command
///    icon - the name of the command icon
///        Use the icon name from the Microsoft Fabric library as the command icon name (the icon name will appear on the page when you hover over the selected icon). If you do not specify an icon, the LightningBolt icon is used.
///
/// Tip: To store the properties and settings of the command, we recommend defining the Settings class in a separate script that you create from the Class Library template.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/general-custom-commands"/>
public interface IGeneralCommand {

    /// <summary>
    /// This method checks the defined conditions for displaying the command.
    ///
    /// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="personId">User ID (tPerson.iPersonId) to which the command should be displayed.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/general-custom-commands#Show"/>
    bool Show(SqlConnection con, int personId);

    /// <summary>
    /// This method runs the command itself.
    ///
    /// Tip: If the custom command is to open a different page from the Alvao WebApp, use the Alvao.API.Common.DbProperty.WebAppUrl property from the Alvao.API interface to get the root URL.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="personId">The user ID (tPerson.iPersonId) that runs the command.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/general-custom-commands#Show"/>
    Tuple<bool, string, string> Run(SqlConnection con, int personId);
}
