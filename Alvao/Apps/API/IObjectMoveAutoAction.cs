namespace Alvao.Apps.API;

/// <summary>By implementing the IObjectMoveAutoAction interface in an application script, you can define custom actions that are automatically performed when an object is moved to another location in the object tree, including removing the object to the Trash.</summary>
/// <see href="https://doc.alvao.com/en/26/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move"/>
public interface IObjectMoveAutoAction {
    /// <summary>This method is called before moving an object in the tree to another location, e.g. within the Move statement.</summary>
    /// <see href="https://doc.alvao.com/en/26/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoving"/>
    /// <param name="e">The moved object, its new parent object (0 = root of the tree) and the user who invoked the action.</param>
    /// <param name="cancellationToken">Token to cancel the asynchronous operation.</param>
    /// <returns>bool - if the method returns true, the object is moved to a new position in the database. If the method returns false, the operation will not be performed and the upcoming object move will be canceled.<br/>string - the message that will be displayed to the user if the return value is false.</returns>
    Task<Tuple<bool, string>> OnObjectMovingAsync(ObjectEventArgs e, CancellationToken cancellationToken);
    /// <summary>This method is called after moving an object in the tree.</summary>
    /// <see href="https://doc.alvao.com/en/26/modules/alvao-am-custom-apps/applications/object-custom-actions-by-object-move#onobjectmoved"/>
    /// <param name="e">The moved object, its previous parent object (0 = root of the tree) and the user who triggered the action.</param>
    /// <param name="cancellationToken">Token to cancel the asynchronous operation.</param>
    Task OnObjectMovedAsync(ObjectEventArgs e, CancellationToken cancellationToken);
}
