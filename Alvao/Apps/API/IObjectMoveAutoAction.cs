using Microsoft.Data.SqlClient;

namespace Alvao.Apps.API;

/// <summary>
/// By implementing the IObjectMoveAutoAction interface in an application script, you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.
/// 
/// Note: The interface methods are also called in the Alvao.API.AM.Object.Move and Alvao.API.AM.Object.Delete methods. When automatically removing computer components to the Recycle Bin based on hw detection, the methods are not called.
///
/// Caution: If you want to use only some of the methods of the implemented interface in the automatic action, leave an exception in the body of the other methods from the interface: throw new NotImplementedException()
/// </summary>
/// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move"/>
public interface IObjectMoveAutoAction
{

    /// <summary>
    /// This method checks the defined conditions for displaying the command.
    ///
    /// Tip: By calling this method in the Run method, you can check before running the command that the conditions for displaying it have not changed between the time the command was displayed and the time it was run.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="objectId">ID of the object (tblNode.intNodeId) to be moved.</param>
    /// <param name="newParentObjectId">ID of the object (tblNode.intNodeId) to which the object is to be moved. A value of 0 means that the object will be moved to the root of the tree.</param>
    /// <param name="personId">the ID of the user (tPerson.iPersonId) who invoked the action.">SqlConnection to the database.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#OnObjectMoving"/>
    Tuple<bool, string> OnObjectMoving(SqlConnection con, int objectId, int newParentObjectId, int personId);

    /// <summary>
    /// This method is called after moving an object in the tree.
    /// </summary>
    ///
    /// <param name="con">SqlConnection to the database.</param>
    /// <param name="objectId">ID of the object (tblNode.intNodeId) to be moved.</param>
    /// <param name="oldParentObjectId">the ID of the object (tblNode.intNodeId) that was the father (parent object) of the object with objectId before it was moved. A value of 0 means that the object was moved from the root of the tree.</param>
    /// <param name="personId">the user ID (tPerson.iPersonId) that triggered the action.</param>
    ///
    /// <see href="https://doc.alvao.com/en/11.2/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#OnObjectMoved"/>
    void OnObjectMoved(SqlConnection con, int objectId, int oldParentObjectId, int personId);
}
