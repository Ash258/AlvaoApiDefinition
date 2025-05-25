using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping role methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html"/>
public static class Role {
    /// <summary>Add role as member to another role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_AddToRole_System_Int32_System_Int32_"/>
    /// <param name="addedRoleId">Role ID (tRole.iRoleId) of added role</param>
    /// <param name="intoRoleId">Role ID (tRole.iRoleId) of role to be added into</param>
    public static void AddToRole(int addedRoleId, int intoRoleId) { throw new NotImplementedException(); }
    /// <summary>Create new role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_Create_System_String_System_String_System_String_System_Nullable_System_Int32__"/>
    /// <param name="name">Name of new role</param>
    /// <param name="description">Role description</param>
    /// <param name="azureAdObjectId">Object ID from Azure AD</param>
    /// <param name="azureAdTenantId">Tenant ID from table AzureAdTenant</param>
    /// <exception cref="ArgumentException">Throws when name is null, empty or too long or when description is null or too long.</exception>
    /// <returns>ID of created role (tRole.iRoleId)</returns>
    public static int Create(string name, string description, string azureAdObjectId = null, int? azureAdTenantId = null) { throw new NotImplementedException(); }
    /// <summary>Delete role</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_Delete_System_Int32_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <exception cref="ArgumentException">Throws when role with roleId does not exist or cannot be deleted.</exception>
    public static void Delete(int roleId) { throw new NotImplementedException(); }
    /// <summary>Get list of all roles.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetAll"/>
    /// <returns>List of all roles (tRole)</returns>
    public static IEnumerable<tRole> GetAll() { throw new NotImplementedException(); }
    /// <summary>Get detail of role by Azure object ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetByAzureObjectId_System_String_"/>
    /// <param name="azureAdObjectId">Azure object ID of role</param>
    /// <returns>Role model (tRole)</returns>
    public static tRole GetByAzureObjectId(string azureAdObjectId) { throw new NotImplementedException(); }
    /// <summary>Get detail of role</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetById_System_Int32_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <exception cref="ArgumentException">Throws when role with roleId does not exist.</exception>
    /// <returns>Role model (tRole)</returns>
    public static tRole GetById(int roleId) { throw new NotImplementedException(); }
    /// <summary>Get detail of role</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetByName_System_String_"/>
    /// <param name="name">Role name (tRole.sRole)</param>
    /// <returns>Role model (tRole)</returns>
    public static tRole GetByName(string name) { throw new NotImplementedException(); }
    /// <summary>Get all direct member roles of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetDirectMemberRoles_System_Int32_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <returns>List of direct member roles (tRole)</returns>
    public static IEnumerable<tRole> GetDirectMemberRoles(int roleId) { throw new NotImplementedException(); }
    /// <summary>Get all direct member user ID's of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetDirectMemberUserIds_System_Int32_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <returns>List of IDs of direct member users (tPerson.iPersonId)</returns>
    public static IEnumerable<int> GetDirectMemberUserIds(int roleId) { throw new NotImplementedException(); }
    /// <summary>Get all direct member users of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetDirectMemberUsers_System_Int32_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <returns>List of direct member users (tPerson)</returns>
    public static IEnumerable<tPerson> GetDirectMemberUsers(int roleId) { throw new NotImplementedException(); }
    /// <summary>Get members of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetMembers_System_Int32_System_Boolean_System_Boolean_System_Boolean_System_Boolean_"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <param name="includeRemoved">Include removed. Default is false.</param>
    /// <param name="includeDisabled">Include disabled. Default is false.</param>
    /// <param name="includeHidden">Include hidden. Default is false.</param>
    /// <param name="onlyWithEmail">Include only users with at leat one e-mail address. Default is false.</param>
    /// <returns>List of members (tPerson)</returns>
    public static IEnumerable<tPerson> GetMembers(int roleId, bool includeRemoved = false, bool includeDisabled = false, bool includeHidden = false, bool onlyWithEmail = false) { throw new NotImplementedException(); }
    /// <summary>Returns list of request IDs, that provided groups are solving.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetRequestIdsSolvingByGroups_System_Collections_Generic_IEnumerable_System_Int32__System_Boolean_"/>
    /// <param name="roleIds">List of Role IDs (tRole.iRoleId)</param>
    /// <param name="onlyWithoutSolver">When true, the method returns only requests withour solver. Otherwise, it returns all requests solving by the group.</param>
    /// <returns>List of Request IDs (tHdTicket.iHdTicketId)/&gt;</returns>
    public static IEnumerable<int> GetRequestIdsSolvingByGroups(IEnumerable<int> roleIds, bool onlyWithoutSolver = false) { throw new NotImplementedException(); }
    /// <summary>Get a special purpose system role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_GetSystemRole_Alvao_API_Common_Model_Database_RoleBehavior_BehaviorId_"/>
    /// <param name="roleBehavior">type of system role</param>
    /// <returns>Role model (tRole)</returns>
    public static tRole GetSystemRole(RoleBehavior.BehaviorId roleBehavior) { throw new NotImplementedException(); }
    /// <summary>Checks whether role is member of another role or system defined role. If both parameters (memberRoleId, roleBehaviorId) are defined, only memberRoleId will be processed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_IsMemberOfAnotherRole_System_Int32_System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="roleId">Role ID (tRole.iRoleId) of role we want to check</param>
    /// <param name="memberRoleId">Role ID (tRole.iRoleId) of role we want to check out</param>
    /// <param name="roleBehaviorId">Role behavior ID (RoleBehavior.id) of role we want to check ou</param>
    /// <returns>Is role member of another role or system defined role</returns>
    public static bool IsMemberOfAnotherRole(int roleId, int? memberRoleId = null, int? roleBehaviorId = null) { throw new NotImplementedException(); }
    /// <summary>Remove member role from another role.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_RemoveFromRole_System_Int32_System_Int32_"/>
    /// <param name="removedRoleId">Role ID (tRole.iRoleId) of role to be removed</param>
    /// <param name="fromRoleId">Role ID (tRole.iRoleId) of role to be removed from</param>
    public static void RemoveFromRole(int removedRoleId, int fromRoleId) { throw new NotImplementedException(); }
    /// <summary>Update role</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Role.html#Alvao_API_Common_Role_Update_Alvao_API_Common_Model_Database_tRole_"/>
    /// <param name="role">Role model</param>
    /// <exception cref="ArgumentException">Throws when role does not exist.</exception>
    public static void Update(tRole role) { throw new NotImplementedException(); }
}
