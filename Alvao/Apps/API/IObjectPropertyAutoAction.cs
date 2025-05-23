using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IObjectPropertyAutoAction interface in a application script, you can define custom actions that are automatically performed when the user manually modifies the value of an object property.
/// 
/// Note: Interface methods are also called in both variants of the Alvao.API.AM.ObjectProperty.Update method. The AM Console command - Properties tab - Generate Value does not call the OnObjectPropertyModifying method. It only calls the OnObjectPropertyModified method.
///
/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException();.
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change"/>
public interface IObjectPropertyAutoAction
{

    /// <summary>
    /// This method checks the defined conditions for displaying the command.
    ///
    /// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="propertyId">ID of the property (tblProperty.intPropertyId) that is being modified.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) who invoked the action.">SqlConnection to the database.</param>
    /// <param name="newValue">new value of the property.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#OnObjectPropertyModifying"/>
    Tuple<bool, string> OnObjectPropertyModifying(SqlConnection con, int propertyId, int personId, string newValue);

    /// <summary>
    /// This method is called after writing a new property value to the database, e.g. by the Modify (property) statement.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="propertyId"> ID of the property (tblProperty.intPropertyId) that has been changed.</param>
    /// <param name="personId">the user ID (tPerson.iPersonId) that triggered the action.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#OnPropertyModified"/>
    void OnPropertyModified(SqlConnection con, int propertyId, int personId);
}
