namespace Alvao.Apps.API;

/// <summary>!!!CAUTION: This class is not documented. Its shape is taken from the Alvao 26 application templates.<br/><br/>Parameters of object move auto action methods.</summary>
public class ObjectEventArgs {
    /// <summary>ID of the object (tblNode.intNodeId) being moved.</summary>
    public int ObjectId { get; set; }
    /// <summary>ID of the new (OnObjectMovingAsync) or previous (OnObjectMovedAsync) parent object (tblNode.intNodeId). A value of 0 means the root of the tree.</summary>
    public int ParentObjectId { get; set; }
    /// <summary>The ID of the user (tPerson.iPersonId) who invoked the action.</summary>
    public int PersonId { get; set; }
}
