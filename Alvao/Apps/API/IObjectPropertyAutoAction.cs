namespace Alvao.Apps.API;

/// <summary>By implementing the IObjectPropertyAutoAction interface in a application script, you can define custom actions that are automatically performed when the user manually modifies the value of an object property.</summary>
/// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change"/>
public interface IObjectPropertyAutoAction {
    /// <summary>This method is called before saving the modified property value to the database, e.g. within the Modify (property) statement.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#onobjectpropertymodifying"/>
    /// <param name="e">Property event method parameters:<br/> - ObjectId - ID of the object (tblNode.intNodeId) that is being modified.<br/> - PropertyKindId - ID of the property kind (tblKind.intKindId) of the object that is being modified.<br/> - PersonId - the ID of the user (tPerson.iPersonId) who invoked the action.<br/> - NewValue - new value of the property.</param>
    ObjectPropertyModifyResult OnObjectPropertyModifying(ObjectPropertyEventArgs e);
    /// <summary>This method is called after writing a new property value to the database, e.g. by the *Modify (property)*statement.</summary>
    /// <see href="https://doc.alvao.com/en/25/modules/alvao-am-custom-apps/applications/object-custom-actions-by-property-change#onobjectpropertymodified"/>
    /// <param name="e">Property event method parameters:<br/> - ObjectId - ID of the object (tblNode.intNodeId) that is being modified.<br/> - PropertyKindId - ID of the property kind (tblKind.intKindId) of the object that is being modified.<br/> - PersonId - the ID of the user (tPerson.iPersonId) who invoked the action.<br/> - NewValue - new value of the property.</param>
    void OnPropertyModified(ObjectPropertyEventArgs e);
}
