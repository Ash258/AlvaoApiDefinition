using Alvao.API.AM.Model;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Object.htm"/>
public static class Object
{

    /// <summary>Copy given object as a child of destination object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Copy.htm"/>
    ///
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    public static int Copy(
        int personId,
        int objectId,
        int destinationObjectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Create new object as a copy of object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Create.htm"/>
    ///
    /// <param name="personId">Person ID (who copied object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId). Null for root</param>
    /// <param name="excludeGeneratingProperties">IDs of the object property types (tblKind.intKindId) for which the value from the numeric sequence will not be generated.</param>
    public static int Create(
        int personId,
        int objectId,
        int? destinationObjectId,
        IEnumerable<int> excludeGeneratingProperties = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Create new object from template.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_CreateByClass.htm"/>
    ///
    /// <param name="classId">Object (template) class ID (tblClass.intClassId)</param>
    /// <param name="objectName">Object name. When null, template name will be used.</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId). Use null for root.</param>
    /// <param name="creatorPersonId">Person ID (who created object) (tPerson.iPersonId). When null, _system person will be used.</param>
    public static int CreateByClass(
        int classId,
        string objectName,
        int? destinationObjectId,
        int? creatorPersonId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Move given objects to the recycle bin. If given objects are already in the recycle bin, it is permanently deleted from a database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Delete.htm"/>
    ///
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true.</param>
    public static void Delete(
        IEnumerable<int> objectIds,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Move given object to the recycle bin. If given object is already in the recycle bin, it is permanently deleted from a database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Delete_1.htm"/>
    ///
    /// <param name="personId">Person ID (who deleted object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true.</param>
    public static void Delete(
        int personId,
        int objectId,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Empty the recycle bin. Objects are permanently deleted.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_EmptyRecycleBin.htm"/>
    ///
    /// <param name="personId">Person ID (who empty the recycle bin) (tPerson.iPersonId)</param>
    public static void EmptyRecycleBin(
        int personId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns list of objects that are descendants of specified classId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_FilterDescendantsOf.htm"/>
    ///
    /// <param name="objectIds">List of Object IDs (tblNode.intNodeId)</param>
    /// <param name="parentClassId">Object class ID (tblClass.intClassId)</param>
    public static IEnumerable<int> FilterDescendantsOf(
        IEnumerable<int> objectIds,
        int parentClassId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Finds or creates folder "Imported objects" in object tree</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_FindOrCreateImportedObjectsFolder.htm"/>
    public static int FindOrCreateImportedObjectsFolder() { throw new System.NotImplementedException(); }

    /// <summary>Gets object by ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_GetById.htm"/>
    ///
    /// <param name="personId">Person Id (for access check) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static tblNode GetById(
        int personId,
        int objectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get path to object by ID in form of object IDs from the root.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_GetNodePath.htm"/>
    ///
    /// <param name="personId">Person Id (for access check) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static IEnumerable<int> GetNodePath(
        int personId,
        int objectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Gets special object by its classId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_GetSpecialObject.htm"/>
    ///
    /// <param name="classId">Special object class ID (tblClass.intClassId)</param>
    public static tblNode GetSpecialObject(
        ObjectClass.Code classId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns true if object is in object of specified classId.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_IsDescendantOf.htm"/>
    ///
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="classId">Object class ID (tblClass.intClassId)</param>
    public static bool IsDescendantOf(
        int objectId,
        int classId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Move given objects in bulk to destination object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Move.htm"/>
    ///
    /// <param name="objectIds">List of object IDs (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <param name="forceCheck">If true, object checking will not be performed (does not apply to permission checking or system objects)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true.</param>
    public static void Move(
        IEnumerable<int> objectIds,
        int destinationObjectId,
        bool forceCheck,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Move given object to destination object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Object_Move_1.htm"/>
    ///
    /// <param name="personId">Person ID (who moved object) (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="destinationObjectId">ID of object which will be parent (tblNode.intNodeId)</param>
    /// <param name="callCustomAction">If true, object auto actions are triggered. Default value is true.</param>
    public static void Move(
        int personId,
        int objectId,
        int destinationObjectId,
        bool callCustomAction = true
    )
    { throw new System.NotImplementedException(); }
}
