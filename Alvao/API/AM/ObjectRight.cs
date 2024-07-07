using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object right methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_ObjectRight.htm"/>
public static class ObjectRight
{

    /// <summary>Sets object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRight_Add.htm"/>
    ///
    /// <param name="model">Permission model</param>
    /// <param name="authorId">Person ID (who set permission) (tPerson.iPersonId)</param>
    public static void Add(
        tblUserNodeRight model,
        int authorId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRight_Delete.htm"/>
    ///
    /// <param name="id">Permission ID (tblUserNodeRight.intUserNodeRightId)</param>
    /// <param name="authorId">Person ID (who deleted permission) (tPerson.iPersonId)</param>
    public static void Delete(
        int id,
        int authorId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Check if object rights in the tree are enabled.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRight_Enabled.htm"/>
    public static bool Enabled() { throw new System.NotImplementedException(); }

    /// <summary>Check if person has exact right for object.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRight_CheckForUser.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="right">Right for object.</param>
    public static bool CheckForUser(
        int personId,
        int objectId,
        Alvao.API.AM.Model.ObjectRight.Right right
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Updates object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_ObjectRight_Update.htm"/>
    ///
    /// <param name="model">Permission model</param>
    /// <param name="authorId">Person ID (who updated permission) (tPerson.iPersonId)</param>
    public static void Update(
        tblUserNodeRight model,
        int authorId
    )
    { throw new System.NotImplementedException(); }
}
