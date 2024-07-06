using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping role methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Role.htm"/>
public static class Role
{

    /// <summary>Add role as member to another role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_AddToRole.htm"/>
    /// <param name="addedRoleId">Role ID (tRole.iRoleId) of added role</param>
    /// <param name="intoRoleId">Role ID (tRole.iRoleId) of role to be added into</param>
    public static void AddToRole(
        int addedRoleId,
        int intoRoleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Create new role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_Create.htm"/>
    /// <param name="name">Name of new role</param>
    /// <param name="description">Role description</param>
    /// <param name="azureAdObjectId">Object ID from Azure AD</param>
    /// <param name="azureAdTenantId">Tenant ID from table AzureAdTenant</param>
    public static int Create(
        string name,
        string description,
        string azureAdObjectId = null,
        int? azureAdTenantId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Delete role</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_Delete.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static void Delete(
        int roleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get list of all roles.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetAll.htm"/>
    public static IEnumerable<tRole> GetAll() { throw new System.NotImplementedException(); }

    /// <summary>Get detail of role by Azure object ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetByAzureObjectId.htm"/>
    /// <param name="azureAdObjectId">Azure object ID of role</param>
    public static tRole GetByAzureObjectId(
        string azureAdObjectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get detail of role</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetById.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static tRole GetById(
        int roleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get detail of role</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetByName.htm"/>
    /// <param name="name">Role name (tRole.sRole)</param>
    public static tRole GetByName(
        string name
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get all direct member roles of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetDirectMemberRoles.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static IEnumerable<tRole> GetDirectMemberRoles(
        int roleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get all direct member user ID's of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetDirectMemberUserIds.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static IEnumerable<int> GetDirectMemberUserIds(
        int roleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get all direct member users of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetDirectMemberUsers.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    public static IEnumerable<tPerson> GetDirectMemberUsers(
        int roleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get members of specified role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetMembers.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId)</param>
    /// <param name="includeRemoved">Include removed. Default is false.</param>
    /// <param name="includeDisabled">Include disabled. Default is false.</param>
    /// <param name="includeHidden">Include hidden. Default is false.</param>
    /// <param name="onlyWithEmail">Include only users with at leat one e-mail address. Default is false.</param>
    public static IEnumerable<tPerson> GetMembers(
        int roleId,
        bool includeRemoved = false,
        bool includeDisabled = false,
        bool includeHidden = false,
        bool onlyWithEmail = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns list of request IDs, that provided groups are solving.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetRequestIdsSolvingByGroups.htm"/>
    /// <param name="roleIds">List of Role IDs (tRole.iRoleId)</param>
    /// <param name="onlyWithoutSolver">When true, the method returns only requests withour solver. Otherwise, it returns all requests solving by the group.</param>
    public static IEnumerable<int> GetRequestIdsSolvingByGroups(
        IEnumerable<int> roleIds,
        bool onlyWithoutSolver = false
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get a special purpose system role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_GetSystemRole.htm"/>
    /// <param name="roleBehavior">type of system role</param>
    public static tRole GetSystemRole(
        RoleBehavior.BehaviorId roleBehavior
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether role is member of another role or system defined role. If both parameters (memberRoleId, roleBehaviorId) are defined, only memberRoleId will be processed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_IsMemberOfAnotherRole.htm"/>
    /// <param name="roleId">Role ID (tRole.iRoleId) of role we want to check</param>
    /// <param name="memberRoleId">Role ID (tRole.iRoleId) of role we want to check out</param>
    /// <param name="roleBehaviorId">Role behavior ID (RoleBehavior.id) of role we want to check ou</param>
    public static bool IsMemberOfAnotherRole(
        int roleId,
        int? memberRoleId = null,
        int? roleBehaviorId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Remove member role from another role.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_RemoveFromRole.htm"/>
    /// <param name="removedRoleId">Role ID (tRole.iRoleId) of role to be removed</param>
    /// <param name="fromRoleId">Role ID (tRole.iRoleId) of role to be removed from</param>
    public static void RemoveFromRole(
        int removedRoleId,
        int fromRoleId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Update role</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Role_Update.htm"/>
    /// <param name="role">Role model</param>
    public static void Update(
        tRole role
    )
    { throw new System.NotImplementedException(); }
}
