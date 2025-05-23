namespace Alvao.API.AM;

/// <summary>Facade class grouping object relation methods</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_ObjectRelation.htm"/>
public static class ObjectRelation {

    /// <summary>Create object relation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRelation_Create.htm"/>
    ///
    /// <param name="beginObjectId">Begin relation object ID (NodeRelation.BeginNodeId)</param>
    /// <param name="endObjectId">End relation object ID (NodeRelation.EndNodeId)</param>
    /// <param name="relationTypeId">Object relation type ID (NodeRelationType.id)</param>
    /// <param name="personId">Person ID (who created relation) (tPerson.iPersonId)</param>
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    public static int Create(
        int beginObjectId,
        int endObjectId,
        int relationTypeId,
        int personId,
        int relationId = 0
    ) { throw new System.NotImplementedException(); }

    /// <summary>Edit object relation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRelation_Edit.htm"/>
    ///
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    /// <param name="relationTypeId">Object relation type ID (NodeRelationType.id)</param>
    /// <param name="personId">Person ID (who removed relation) (tPerson.iPersonId)</param>
    public static int Edit(
        int relationId,
        int relationTypeId,
        int personId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Remove object relation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRelation_Remove.htm"/>
    ///
    /// <param name="relationId">Object relation ID (NodeRelation.id)</param>
    /// <param name="personId">Person ID (who removed relation) (tPerson.iPersonId)</param>
    public static void Remove(
        int relationId,
        int personId
    ) { throw new System.NotImplementedException(); }
}
