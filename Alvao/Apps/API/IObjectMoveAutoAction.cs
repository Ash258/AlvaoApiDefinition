using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>By implementing the IObjectMoveAutoAction interface in an application script, you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move"/>
public interface IObjectMoveAutoAction {
    /// <summary>This method is called before moving an object in the tree to another location, e.g. within the Move statement.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoving"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="objectId">ID of the object (tblNode.intNodeId) to be moved.</param>
    /// <param name="newParentObjectId">ID of the object (tblNode.intNodeId) to which the object is to be moved. A value of 0 means that the object will be moved to the root of the tree.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) who invoked the action.</param>
    /// <returns>bool - if the method returns true, the object is moved to a new position in the database. If the method returns false, the operation will not be performed and the upcoming object move will be canceled.<br/>string - the message that will be displayed to the user if the return value is false.</returns>
    Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId);
    /// <summary>This method is called after moving an object in the tree.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoved"/>
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="objectId">ID of the object (tblNode.intNodeId) to be moved.</param>
    /// <param name="oldParentObjectId">the ID of the object (tblNode.intNodeId) that was the father (parent object) of the object with objectId before it was moved. A value of 0 means that the object was moved from the root of the tree.</param>
    /// <param name="personId">the user ID (tPerson.iPersonId) that triggered the action.</param>
    void OnObjectMoved(SqlConnection con, int objectId, int oldParentObjectId, int personId);
}
