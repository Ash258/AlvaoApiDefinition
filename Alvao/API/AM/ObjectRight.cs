using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping object right methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html"/>
public static class ObjectRight {
    /// <summary>Sets object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_Add_Alvao_API_Common_Model_Database_tblUserNodeRight_System_Int32_"/>
    /// <param name="model">Permission model</param>
    /// <param name="authorId">Person ID (who set permission) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when model is not valid.</exception>
    public static void Add(tblUserNodeRight model, int authorId) { throw new NotImplementedException(); }
    /// <summary>Check if person from the tree has right to read the object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_CanNodePersonRead_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="personNodeId">Person node ID from the tree (tblNode.intNodeId)</param>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <returns>Returns true if person from the tree has right to read the object, otherwise false</returns>
    public static bool CanNodePersonRead(int personNodeId, int personId, int objectId) { throw new NotImplementedException(); }
    /// <summary>Check if person has exact right for object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_CheckForUser_System_Int32_System_Int32_Alvao_API_AM_Model_ObjectRight_Right_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="right">Right for object.</param>
    /// <exception cref="ArgumentException">Throws when right is not supported.</exception>
    /// <returns>Returns true if person has exact right for object, otherwise false</returns>
    public static bool CheckForUser(int personId, int objectId, Alvao.API.AM.Model.ObjectRight.Right right) { throw new NotImplementedException(); }
    /// <summary>Removes object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_Delete_System_Int32_System_Int32_"/>
    /// <param name="id">Permission ID (tblUserNodeRight.intUserNodeRightId)</param>
    /// <param name="authorId">Person ID (who deleted permission) (tPerson.iPersonId)</param>
    public static void Delete(int id, int authorId) { throw new NotImplementedException(); }
    /// <summary>Check if object rights in the tree are enabled.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_Enabled"/>
    /// <returns>Returns true if object rights in the tree are enabled, otherwise false</returns>
    public static bool Enabled() { throw new NotImplementedException(); }
    /// <summary>Check if person has exact right for object.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_HasUserObjectRight_System_Int32_System_Int32_Alvao_API_AM_Model_ObjectRight_Right_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <param name="right">Right for object.</param>
    /// <exception cref="ArgumentException">Throws when right is not supported.</exception>
    /// <returns>Returns true if person has exact right for object, otherwise false</returns>
    [Obsolete("HasUserObjectRight is deprecated, please use CheckForUser instead.")]
    public static bool HasUserObjectRight(int personId, int objectId, Alvao.API.AM.Model.ObjectRight.Right right) { throw new NotImplementedException(); }
    /// <summary>Updates object permission for user and creates record in audit log.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.ObjectRight.html#Alvao_API_AM_ObjectRight_Update_Alvao_API_Common_Model_Database_tblUserNodeRight_System_Int32_"/>
    /// <param name="model">Permission model</param>
    /// <param name="authorId">Person ID (who updated permission) (tPerson.iPersonId)</param>
    /// <exception cref="ArgumentNullException">Throws when model is null.</exception>
    /// <exception cref="ArgumentException">Throws when model is not valid.</exception>
    public static void Update(tblUserNodeRight model, int authorId) { throw new NotImplementedException(); }
}
