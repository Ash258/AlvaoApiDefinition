using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IPeriodicAction interface in a application script, you can define custom periodic actions.
/// Custom actions can be run at a regular time interval.
/// The system runs periodic custom actions every hour.
///
/// In the application, create a new script using the IPeriodicAction template and name it appropriately according to the functionality that the action performs.
/// In the newly created script, set the value of the Name property (the name of the action itself) in the class constructor.
///
/// Caution: Poor definition of a custom action can irreversibly damage the Alvao database, so always create and test actions in a test environment, e.g. on a copy of the production database.
/// Tip: A prerequisite for creating a working automated action is a good knowledge of Alvao database and Alvao.API.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/periodic-custom-actions"/>
public interface IPeriodicAction {
    public string Name { get; set; }

    /// <summary>In the method, define both the conditions for performing the operations and the operations themselves.</summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/periodic-custom-actions#OnPeriod"/>
    void OnPeriod(SqlConnection con);
}
