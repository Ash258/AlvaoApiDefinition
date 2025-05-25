using Alvao.API.AM.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object property methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html"/>
public static class ObjectProperty {
    /// <summary>Adds property to object template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_Add_System_Int32_System_Int32_System_Object_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="kindId">Property kind id (tblKind.intKindId)</param>
    /// <param name="value">New property value</param>
    /// <param name="inheritable">Inherit property into child objects</param>
    public static void Add(int objectId, int kindId, object value, bool inheritable) { throw new System.NotImplementedException(); }
    /// <summary>Adds property to object template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_Add_System_Int32_System_Int32_System_Object_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="kindId">Property kind id (tblKind.intKindId)</param>
    /// <param name="value">New property value</param>
    /// <param name="order">Order in object name</param>
    /// <param name="inheritable">Inherit property into child objects</param>
    [Obsolete("This version of Add is deprecated, please use Add without order parameter instead.")]
    public static void Add(int objectId, int kindId, object value, int? order, bool inheritable) { throw new System.NotImplementedException(); }
    /// <summary>Returns property kind database model.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetDefinition_System_Int32_"/>
    /// <param name="propertyKindId">Property kind ID</param>
    /// <returns>Property kind model (tblKind)</returns>
    public static tblKind GetDefinition(int propertyKindId) { throw new System.NotImplementedException(); }
    /// <summary>Return possible values for property</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetPosibleValues_Alvao_API_AM_Model_Property_"/>
    /// <param name="property">Groups properties connected to property.</param>
    /// <returns>Collection of possible values.</returns>
    public static IEnumerable<tblKindValue> GetPosibleValues(Property property) { throw new System.NotImplementedException(); }
    /// <summary>Return template properties for specific object kind.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetTemplateProperties_Alvao_API_Common_Model_Database_tblClass_ClassCode_"/>
    /// <param name="classCode">Object (template) class (tblClass.intClassId)</param>
    public static IEnumerable<tblKind> GetTemplateProperties(tblClass.ClassCode classCode) { throw new System.NotImplementedException(); }
    /// <summary>Return template properties for specific object kind.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetTemplateProperties_System_Int32_"/>
    /// <param name="typeId">Object (template) type (tblClass.intClassId)</param>
    public static IEnumerable<tblKind> GetTemplateProperties(int typeId) { throw new System.NotImplementedException(); }
    /// <summary>Return value list of property based on kind ID or kind code.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetValueList_System_Int32_System_Int32_"/>
    /// <param name="kindId">Property kind ID (tblKind.intKindId)</param>
    /// <param name="kindCode">Property kind code (tblKind.intKindCode)</param>
    /// <returns>Collection of values.</returns>
    public static IEnumerable<tblKindValue> GetValueList(int kindId = 0, int kindCode = 0) { throw new System.NotImplementedException(); }
    /// <summary>Returns property values of specific object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_GetValuesByKindCodes_System_Int32_System_Collections_Generic_IEnumerable_Alvao_API_Common_Model_Database_tblKind_KindCode__"/>
    /// <param name="nodeId">Object ID (tblNode.intNodeId)</param>
    /// <param name="codes">Object property kind codes to return</param>
    public static IDictionary<tblKind.KindCode, string> GetValuesByKindCodes(int nodeId, IEnumerable<tblKind.KindCode> codes) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether object template contains specific property</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_TemplateContains_System_Int32_Alvao_API_Common_Model_Database_tblKind_KindCode_"/>
    /// <param name="classId">Object (template) class (tblClass.intClassId)</param>
    /// <param name="kindCode">Property kind code (tblKind.intKindCode)</param>
    /// <returns>True, when template contains the property, false otherwise.</returns>
    public static bool TemplateContains(int classId, tblKind.KindCode kindCode) { throw new System.NotImplementedException(); }
    /// <summary>Updates value of one property on specific object</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_Update_System_Int32_Alvao_API_Common_Model_Database_tblKind_KindCode_System_Object_System_Boolean_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="kindCode">Property kind code (tblKind.intKindCode)</param>
    /// <param name="value">New property value</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <param name="shouldLog">If true, the property value change is logged into tblLog. Default value is true.</param>
    /// <exception cref="MissingPropertyException">
    /// Throws when object with objectId doesn't have property with kindCode.
    /// </exception>
    /// <exception cref="InvalidPropertyValueTypeException">
    /// Throws when property value type was not recognized or is not supported.
    /// </exception>
    public static void Update(int objectId, tblKind.KindCode kindCode, object value, bool callCustomAction = true, bool shouldLog = true) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// int objectId = 50; //Object which will be updated
    /// int personId = 25; //Author of update
    /// var properties = new Dictionary&lt;string, object&gt;(); //Create dictionary of properties
    /// properties.Add("property name", value); //Add property name and new typed value of property
    /// Alvao.API.AM.ObjectProperty.UpdateProperties(personId, objectId, properties); //Update properties
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_Update_System_Int32_System_Int32_System_Collections_Generic_IDictionary_System_String_System_Object__System_Boolean_"/>
    /// <param name="personId">Person ID (who updates properties) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="properties">Object properties to update</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="ObjectNotFoundException">
    /// Throws when object with objectId or objectId does not exist.
    /// </exception>
    /// <exception cref="UnauthorizedObjectOperationEception">
    /// Throws when person with personId doesn't have rights to move object with objectId.
    /// </exception>
    /// <exception cref="MissingPropertyException">
    /// Throws when property was not found on object.
    /// </exception>
    /// <exception cref="InvalidPropertyValueTypeException">
    /// Throws when property value was not validated, because it has wrong type.
    /// </exception>
    /// <exception cref="PropertyValueViolatesUniquenessException">
    /// Throws when property value violates uniqueness.
    /// </exception>
    public static void Update(int personId, int objectId, IDictionary<string, object> properties, bool callCustomAction = true) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// int objectId = 50; //Object which will be updated
    /// int personId = 25; //Author of update
    /// var properties = new Dictionary&lt;string, string&gt;(); //Create dictionary of properties
    /// properties.Add("property name", "property new value"); //Add property name and new value of property
    /// Alvao.API.AM.ObjectProperty.UpdateProperties(personId, objectId, properties); //Update properties
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_Update_System_Int32_System_Int32_System_Collections_Generic_IDictionary_System_String_System_String__System_Boolean_"/>
    /// <param name="personId">Person ID (who updates properties) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="properties">Object properties to update</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="ObjectNotFoundException">
    /// Throws when object with objectId or objectId does not exist.
    /// </exception>
    /// <exception cref="UnauthorizedObjectOperationEception">
    /// Throws when person with personId doesn't have rights to move object with objectId.
    /// </exception>
    /// <exception cref="MissingPropertyException">
    /// Throws when property was not found on object.
    /// </exception>
    /// <exception cref="InvalidPropertyValueTypeException">
    /// Throws when property value was not validated, because it has wrong type.
    /// </exception>
    /// <exception cref="PropertyValueViolatesUniquenessException">
    /// Throws when property value violates uniqueness.
    /// </exception>
    [Obsolete("Update with IDictionary<string, string> is deprecated, please use Update with IDictionary<string, object> instead.")]
    public static void Update(int personId, int objectId, IDictionary<string, string> properties, bool callCustomAction = true) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// int objectId = 50; //Object which will be updated
    /// int personId = 25; //Author of update
    /// var properties = new Dictionary&lt;string, string&gt;(); //Create dictionary of properties
    /// properties.Add("property name", "property new value"); //Add property name and new value of property
    /// Alvao.API.AM.ObjectProperty.UpdateProperties(personId, objectId, properties); //Update properties
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectProperty.html#Alvao_API_AM_ObjectProperty_UpdateProperties_System_Int32_System_Int32_System_Collections_Generic_IDictionary_System_String_System_String__System_Boolean_"/>
    /// <param name="personId">Person ID (who updates properties) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="properties">Object properties to update</param>
    /// <param name="callCustomAction">If true, object property auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="ObjectNotFoundException">
    /// Throws when object with objectId or objectId does not exist.
    /// </exception>
    /// <exception cref="UnauthorizedObjectOperationEception">
    /// Throws when person with personId doesn't have rights to move object with objectId.
    /// </exception>
    /// <exception cref="MissingPropertyException">
    /// Throws when property was not found on object.
    /// </exception>
    /// <exception cref="InvalidPropertyValueTypeException">
    /// Throws when property value was not validated, because it has wrong type.
    /// </exception>
    /// <exception cref="PropertyValueViolatesUniquenessException">
    /// Throws when property value violates uniqueness.
    /// </exception>
    [Obsolete("UpdateProperties is deprecated, please use Update instead.")]
    public static void UpdateProperties(int personId, int objectId, IDictionary<string, string> properties, bool callCustomAction = true) { throw new System.NotImplementedException(); }
}
