namespace Alvao.API.AM;

/// <summary>Facade class grouping object relation methods</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRelation.html"/>
public static class ObjectRelation {
    /// <summary>Create object relation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRelation.html#Alvao_API_AM_ObjectRelation_Create_System_Int32_System_Int32_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="beginObjectId">Begin relation object ID (NodeRelation.BeginNodeId)</param>
    /// <param name="endObjectId">End relation object ID (NodeRelation.EndNodeId)</param>
    /// <param name="relationTypeId">Object relation type ID (NodeRelationType.id)</param>
    /// <param name="personId">Person ID (who created relation) (tPerson.iPersonId)</param>
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to manage object relation.</exception>
    /// <exception cref="ArgumentException">Throws when object with beginObjectId is same as object with endObjectId</exception>
    /// <exception cref="ObjectRelationConditionViolatedException">Throws when object relation cannot be created due to a condition violation (eg. cyclicity, one to many or duplicate).</exception>
    /// <returns>Created object relation ID (NodeRelation.id)</returns>
    public static int Create(int beginObjectId, int endObjectId, int relationTypeId, int personId, int relationId = 0) { throw new System.NotImplementedException(); }
    /// <summary>Edit object relation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRelation.html#Alvao_API_AM_ObjectRelation_Edit_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    /// <param name="relationTypeId">Object relation type ID (NodeRelationType.id)</param>
    /// <param name="personId">Person ID (who removed relation) (tPerson.iPersonId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to manage object relation.</exception>
    /// <exception cref="InvalidOperationException">Throws when object relation with relationId cannot be edited because it is already removed.</exception>
    /// <exception cref="ObjectRelationConditionViolatedException">Throws when object relation with relationId cannot be edited due to a condition violation (eg. cyclicity, one to many or duplicate).</exception>
    /// <returns>Edited object new relation ID (NodeRelation.id)</returns>
    public static int Edit(int relationId, int relationTypeId, int personId) { throw new System.NotImplementedException(); }
    /// <summary>Remove object relation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRelation.html#Alvao_API_AM_ObjectRelation_Remove_System_Int32_System_Int32_"/>
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    /// <param name="personId">Person ID (who removed relation) (tPerson.iPersonId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when person with personId doesn't have rights to manage object relation.</exception>
    /// <exception cref="InvalidOperationException">Throws when object relation with relationId is already removed.</exception>
    public static void Remove(int relationId, int personId) { throw new System.NotImplementedException(); }
}
