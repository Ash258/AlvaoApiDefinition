using Alvao.API.AM.Exceptions;
using Alvao.API.AM.Model;
using Alvao.API.AM.Model.XmlExport;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html"/>
public static class Object {
    /// <summary>Finds closest parent of specified type to the specified object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_ClosestParentOfType_System_Int32_System_Int32_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="parentObjectTypeId">Object type ID (tblClass.intClassId) of the parent object.</param>
    /// <returns>Object ID (tblNode.intNodeId) of the parent that has specified type. If there is no such a parent, 0 is returned.</returns>
    public static int ClosestParentOfType(int objectId, int parentObjectTypeId) { throw new NotImplementedException(); }
    /// <summary>Copy given object as a child of destination object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Copy_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <exception cref="ArgumentException">Throws when object with objectId or destinationObjectId does not exist.</exception>
    /// <exception cref="InvalidOperationException">Throws when object cannot be copied.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to create object in destinationObjectId.</exception>
    /// <returns>Created object ID (tblNode.intNodeId)</returns>
    public static int Copy(int personId, int objectId, int destinationObjectId) { throw new NotImplementedException(); }
    /// <summary>Copy given object as a child of destination object. CopyObject is deprecated, please use Copy instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_CopyObject_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <exception cref="ArgumentException">Throws when object with objectId or destinationObjectId does not exist.</exception>
    /// <exception cref="InvalidOperationException">Throws when object cannot be copied.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to create object in destinationObjectId.</exception>
    /// <returns>Created object ID (tblNode.intNodeId)</returns>
    [Obsolete("CopyObject is deprecated, please use Copy instead.")]
    public static int CopyObject(int personId, int objectId, int destinationObjectId) { throw new NotImplementedException(); }
    /// <summary>
    /// Create new object as a copy of object.
    /// <example>
    /// <code>
    /// int selectedObjectId = 50; //Object which will be copied
    /// int personId = 25; //Author of copy
    /// int destObjectId = 30; //Parent of new object
    /// Alvao.API.AM.Object.Create(personId, selectedObjectId, destObjectId); //Create new object
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Create_System_Int32_System_Int32_System_Nullable_System_Int32__System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId). Null for root</param>
    /// <param name="excludeGeneratingProperties">IDs of the object property types (tblKind.intKindId) for which the value from the numeric sequence will not be generated.</param>
    /// <exception cref="ArgumentException">Throws when object with objectId.</exception>
    /// <exception cref="InvalidOperationException">Throws when object cannot be copied.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to create object in destinationObjectId.</exception>
    /// <returns>Created object ID (tblNode.intNodeId)</returns>
    public static int Create(int personId, int objectId, int? destinationObjectId, IEnumerable<int> excludeGeneratingProperties = null) { throw new NotImplementedException(); }
    /// <summary>
    /// Asynchronously creates one or more objects based on the specified creation model.
    /// <example>
    /// <code>
    /// var model = new ObjectCreationModel
    /// {
    ///     ObjectId = 50, // Template/source object
    ///     ParentObjectId = 30, // Parent for new objects
    ///     Count = 5, // Create 5 copies
    ///     ExcludeGeneratingPropertyKindIds = new List&lt;int&gt; { 123, 456 } // Skip auto-generation for these properties
    /// };
    /// var newObjectIds = await Alvao.API.AM.Object.CreateAsync(model);
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_CreateAsync_Alvao_API_AM_Model_ObjectCreationModel_System_Threading_CancellationToken_"/>
    /// <param name="model">The creation model containing object specification details including:</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation</param>
    /// <exception cref="ArgumentException">Throws when source object ID is invalid or doesn't exist</exception>
    /// <exception cref="InvalidOperationException">Throws when object cannot be copied</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when user doesn't have rights to create object in the destination</exception>
    /// <returns>Collection of created object IDs (tblNode.intNodeId)</returns>
    public static Task<IEnumerable<int>> CreateAsync(ObjectCreationModel model, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <summary>Create new object from template.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_CreateByClass_System_Int32_System_String_System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="classId">Object (template) class ID (tblClass.intClassId)</param>
    /// <param name="objectName">Object name. When null, template name will be used.</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId). Use null for root.</param>
    /// <param name="creatorPersonId">Person ID (who created object) (tPerson.iPersonId). When null, _system person will be used.</param>
    /// <exception cref="ArgumentException">Throws when object class with ID classId or object with ID destinationObjectId or person with ID creatorPersonId does not exist.</exception>
    /// <returns>Created object ID (tblNode.intNodeId)</returns>
    public static int CreateByClass(int classId, string objectName, int? destinationObjectId, int? creatorPersonId) { throw new NotImplementedException(); }
    /// <summary>
    /// Create new object as a copy of object. CreateObject is deprecated, please use Create instead.
    /// <example>
    /// <code>
    /// int selectedObjectId = 50; //Object which will be copied
    /// int personId = 25; //Author of copy
    /// int destObjectId = 30; //Parent of new object
    /// Alvao.API.AM.Object.CreateObject(personId, selectedObjectId, destObjectId); //Create new object
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_CreateObject_System_Int32_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId). Null for root</param>
    /// <exception cref="ArgumentException">Throws when object with objectId.</exception>
    /// <exception cref="InvalidOperationException">Throws when object cannot be copied.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to create object in destinationObjectId.</exception>
    /// <returns>Created object ID (tblNode.intNodeId)</returns>
    [Obsolete("CreateObject is deprecated, please use Create instead.")]
    public static int CreateObject(int personId, int objectId, int? destinationObjectId) { throw new NotImplementedException(); }
    /// <summary>Move given objects to the recycle bin. If given objects are already in the recycle bin, it is permanently deleted from a database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Delete_System_Collections_Generic_IEnumerable_System_Int32__System_Boolean_"/>
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="InvalidOperationException">Throws when object in objectIds is deleted and is user who is responsible for some asset or organization that has linked licenses.</exception>
    /// <exception cref="ArgumentException">Throws when deleting only one object in objectIds and it does not exist.</exception>
    /// <exception cref="InvalidBulkMoveException">Throws when object in objectIds is deleted and user does not have permission or is deleting system object.</exception>
    public static void Delete(IEnumerable<int> objectIds, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Move given object to the recycle bin. If given object is already in the recycle bin, it is permanently deleted from a database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Delete_System_Int32_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="InvalidOperationException">Throws when object with objectId is deleted and is user who is responsible for some asset or organization that has linked licenses.</exception>
    /// <exception cref="ArgumentException">Throws when deleting object with objectId and it does not exist.</exception>
    /// <exception cref="InvalidBulkMoveException">Throws when object with objectId is deleted and user does not have permission or is deleting system object.</exception>
    public static void Delete(int objectId, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Move given object to the recycle bin. If given object is already in the recycle bin, it is permanently deleted from a database. DeleteObject is deprecated, please use Delete instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_DeleteObject_System_Int32_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="ArgumentException">Throws when object with objectId does not exist.</exception>
    /// <exception cref="InvalidOperationException">Throws when object is special or the recycle bin does not exist or when wanted to permanently delete responsible user or organization with license.</exception>
    [Obsolete("DeleteObject is deprecated, please use Delete instead.")]
    public static void DeleteObject(int objectId, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Empty the recycle bin. Objects are permanently deleted.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_EmptyRecycleBin_System_Int32_"/>
    /// <param name="personId">Person ID (who empty the recycle bin) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentException">Throws when the recycle bin does not exist or when wanted to permanently delete responsible user or organization with license.</exception>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId is not a member of Asset Management Administrators group.</exception>
    public static void EmptyRecycleBin(int personId) { throw new NotImplementedException(); }
    /// <summary>Creates a XML export of objects.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Export_System_Collections_Generic_List_System_Int32__System_Boolean_"/>
    /// <param name="objectIds">Object IDs to export (tblNode.intNodeId)</param>
    /// <param name="includeSubtree">If true, objects in the subtree of selected objects are also exported</param>
    /// <returns>Exported XML as a Memory Stream</returns>
    public static MemoryStream Export(List<int> objectIds, bool includeSubtree) { throw new NotImplementedException(); }
    /// <summary>Returns list of objects that are descendants of specified classId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_FilterDescendantsOf_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_"/>
    /// <param name="objectIds">List of Object IDs (tblNode.intNodeId)</param>
    /// <param name="parentClassId">Object class ID (tblClass.intClassId)</param>
    /// <returns>List of objects that are in specified classId</returns>
    public static IEnumerable<int> FilterDescendantsOf(IEnumerable<int> objectIds, int parentClassId) { throw new NotImplementedException(); }
    /// <summary>Finds or creates folder &quot;Imported objects&quot; in object tree</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_FindOrCreateImportedObjectsFolder"/>
    /// <remarks>Default place for this folder in the object tree is the root.</remarks>
    /// <returns>Imported objects folder ID (tblNode.intNodeId)</returns>
    public static int FindOrCreateImportedObjectsFolder() { throw new NotImplementedException(); }
    /// <summary>Gets object by ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_GetById_System_Int32_System_Int32_"/>
    /// <param name="personId">Person Id (for access check) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static tblNode GetById(int personId, int objectId) { throw new NotImplementedException(); }
    /// <summary>Get path to object by ID in form of object IDs from the root.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_GetNodePath_System_Int32_System_Int32_"/>
    /// <param name="personId">Person Id (for access check) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static IEnumerable<int> GetNodePath(int personId, int objectId) { throw new NotImplementedException(); }
    /// <summary>Gets object by ID. GetObjectById is deprecated, please use GetById instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_GetObjectById_System_Int32_System_Int32_"/>
    /// <param name="personId">Person Id (for access check) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    [Obsolete("GetObjectById is deprecated, please use GetById instead.")]
    public static tblNode GetObjectById(int personId, int objectId) { throw new NotImplementedException(); }
    /// <summary>Gets special object by its classId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_GetSpecialObject_Alvao_API_AM_Model_ObjectClass_Code_"/>
    /// <param name="classId">Special object class ID (tblClass.intClassId)</param>
    public static tblNode GetSpecialObject(ObjectClass.Code classId) { throw new NotImplementedException(); }
    /// <summary>Imports objects from an XML export model into the objects tree.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Import_Alvao_API_AM_Model_XmlExport_ExportRootXmlModel_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="exportRootModel">The XML model containing the data to be imported.</param>
    /// <param name="parentObjectId">The optional ID of the parent object under which the objects will be imported. If null, the objects will be imported at the root level.</param>
    /// <param name="isTemplates">A value indicating whether the import operation is for templates. true if importing templates; otherwise, false.</param>
    /// <returns>
    /// An ImportViewModel representing the result of the import operation, including any relevant
    /// status or metadata.
    /// </returns>
    public static ImportViewModel Import(ExportRootXmlModel exportRootModel, int? parentObjectId, bool isTemplates) { throw new NotImplementedException(); }
    /// <summary>Returns true if object is a computer.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_IsComputer_System_Int32_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <returns>True, if object is computer</returns>
    public static bool IsComputer(int objectId) { throw new NotImplementedException(); }
    /// <summary>Returns true if object is in object of specified classId.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_IsDescendantOf_System_Int32_System_Int32_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="classId">Object class ID (tblClass.intClassId)</param>
    /// <returns>True, if object is in specified classId</returns>
    public static bool IsDescendantOf(int objectId, int classId) { throw new NotImplementedException(); }
    /// <summary>Move given objects in bulk to destination object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Move_System_Collections_Generic_IEnumerable_System_Int32__System_Int32_System_Boolean_System_Boolean_"/>
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <param name="forceCheck">If true, object checking will not be performed (does not apply to permission checking or system objects)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="InvalidBulkMoveException">Throws when object in objectIds is moved to the Recycle bin and is user who is responsible for some asset or organization that has linked licenses. Can be also thrown when other conditions are not met (e.g. permissions, moving object to itself or when object is not movable).</exception>
    /// <exception cref="InvalidMoveException">Throws when moving only one object in objectIds and some conditions are not met (e.g. moving object to itself).</exception>
    /// <exception cref="ArgumentException">Throws when moving only one object in objectIds and it does not exist.</exception>
    /// <exception cref="InvalidOperationException">Throws when at least one of the objects in objectIds is moved to the location where will be no user responsible for it or when moving PC with licenses from one organization to another organization.</exception>
    public static void Move(IEnumerable<int> objectIds, int destinationObjectId, bool forceCheck, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Move given object to destination object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_Move_System_Int32_System_Int32_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="InvalidBulkMoveException">Throws when object with objectId is moved to the Recycle bin and is user who is responsible for some asset or organization that has linked licenses. Can be also thrown when other conditions are not met (e.g. permissions or when object is not movable).</exception>
    /// <exception cref="InvalidMoveException">Throws when object with objectId does not met any condition for moving (e.g. moving object to itself).</exception>
    /// <exception cref="ArgumentException">Throws when object with objectId does not exist.</exception>
    /// <exception cref="InvalidOperationException">Throws when object with objectId is moved to the location where will be no user responsible for it or when moving PC with licenses from one organization to another organization.</exception>
    public static void Move(int objectId, int destinationObjectId, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Move given object to destination object. MoveObject is deprecated, please use Move instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_MoveObject_System_Int32_System_Int32_System_Boolean_"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true. This method cannot be called in running transaction (if calling it is necessary, set the callCustomAction parameter to false).</param>
    /// <exception cref="ArgumentException">Throws when object with objectId or destinationObjectId does not exist.</exception>
    [Obsolete("MoveObject is deprecated, please use Move instead.")]
    public static void MoveObject(int objectId, int destinationObjectId, bool callCustomAction = true) { throw new NotImplementedException(); }
    /// <summary>Validates the provided import data and returns a model containing the validation results.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Object.html#Alvao_API_AM_Object_ValidateImport_Alvao_API_AM_Model_XmlExport_ExportRootXmlModel_System_Nullable_System_Int32__System_Boolean_"/>
    /// <param name="exportRootModel">The XML model representing the data to be imported.</param>
    /// <param name="parentObjectId">The optional ID of the parent object under which the data will be imported.</param>
    /// <param name="isTemplates">A boolean value indicating whether the import is for templates (true) or regular objects (false).</param>
    /// <remarks>Use the returned ImportViewModel to inspect validation results and determine if the import can proceed.</remarks>
    /// <returns>
    /// An ImportViewModel containing the results of the validation, including any errors or warnings
    /// encountered during the process.
    /// </returns>
    public static ImportViewModel ValidateImport(ExportRootXmlModel exportRootModel, int? parentObjectId, bool isTemplates) { throw new NotImplementedException(); }
}
