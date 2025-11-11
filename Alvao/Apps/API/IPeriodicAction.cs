using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>By implementing the IPeriodicAction interface in a application script, you can define custom periodic actions. Custom actions can be run at a regular time interval. The system runs periodic custom actions every hour.<br/><br/>In the application, create a new script using the IPeriodicAction template and name it appropriately according to the functionality that the action performs. In the newly created script, set the value of the Name property (the name of the action itself) in the class constructor.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/periodic-custom-actions/"/>
public interface IPeriodicAction {
    /// <summary>In the method, define both the conditions for performing the operations and the operations themselves.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/periodic-custom-actions/#onperiod"/>
    /// <param name="con">SqlConnection to the database.</param>
    void OnPeriod(SqlConnection con);
}
