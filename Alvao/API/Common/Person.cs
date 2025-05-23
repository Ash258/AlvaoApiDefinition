using System.Globalization;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping person methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Person.htm"/>
public static class Person {

    /// <summary>Adds person to group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_AddToGroup.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleIds">Group IDs (tRole.iRoleId)</param>
    public static void AddToGroup(
        int personId,
        IEnumerable<int> roleIds
    ) { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_ConvertUtcToPersonLocal.htm"/>
    ///
    /// <param name="person"> </param>
    /// <param name="utcDate"> </param>
    public static DateTime ConvertUtcToPersonLocal(
        tPerson person,
        DateTime utcDate
    ) { throw new System.NotImplementedException(); }

    /// <summary>Creates person.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_Create.htm"/>
    ///
    /// <param name="fullName">Name and surname</param>
    /// <param name="login">User name</param>
    /// <param name="email">E-mail</param>
    /// <param name="phone">Work phone</param>
    /// <param name="personalNumber">Personal number</param>
    /// <param name="azureAdObjectId">Object ID from Azure AD</param>
    /// <param name="azureAdTenantId">Tenant ID from Azure AD</param>
    public static int Create(
        string fullName,
        string login,
        string email,
        string phone,
        string personalNumber,
        string azureAdObjectId = null,
        int? azureAdTenantId = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns all persons</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetAll.htm"/>
    ///
    /// <param name="includeRemoved">Include removed persons in result</param>
    public static IEnumerable<tPerson> GetAll(
        bool includeRemoved = false
    ) { throw new System.NotImplementedException(); }

    /// <summary>Search for person by AzureObjectId. If not found, tries to find by person SID and then by email.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetByAzureIdSidOrEmail.htm"/>
    ///
    /// <param name="azureAdObjectId">Azure Active Directory object ID. Cannot be null.</param>
    /// <param name="userSid">User SID from on-premise AD or null</param>
    /// <param name="email">User email or null</param>
    public static tPerson GetByAzureIdSidOrEmail(
        string azureAdObjectId,
        string userSid = null,
        string email = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Return all persons which are synchronized from Azure Active Directory tenant.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetByAzureTenant.htm"/>
    ///
    /// <param name="azureAdTenantId">Azure Tenant ID</param>
    public static IEnumerable<tPerson> GetByAzureTenant(
        int azureAdTenantId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns person by email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetByEmail.htm"/>
    ///
    /// <param name="email">Person email</param>
    public static tPerson GetByEmail(
        string email
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns person</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetById.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    public static tPerson GetById(
        int personId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Search for person by persons login</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetByLogin.htm"/>
    ///
    /// <param name="login">Person login</param>
    public static tPerson GetByLogin(
        string login
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns CultureInfo for given person. If person does not have set preffered language , CultureInfo of system language is returned.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetCultureInfoOrDefault.htm"/>
    ///
    /// <param name="person">Person to get CultureInfo for</param>
    public static CultureInfo GetCultureInfoOrDefault(
        tPerson person
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns custom list of persons.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetCustomList.htm"/>
    ///
    /// <param name="columns">Database columns from tPerson and tPersonCust. These columns will be included in the result</param>
    /// <param name="filterCondition">SQL filter condition (without WHERE keyword)</param>
    /// <param name="sorting">SQL sorting condition (without ORDER BY keyword)</param>
    public static IEnumerable<Object> GetCustomList(
        string columns,
        string filterCondition,
        string sorting
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns group ID (tRole.iRoleId) of all groups that the person is member of.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetGroupMembership.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="onlyDirectMembership">Get only direct membership</param>
    public static IEnumerable<int> GetGroupMembership(
        int personId,
        bool onlyDirectMembership
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns guest person</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetGuest.htm"/>
    public static tPerson GetGuest() { throw new System.NotImplementedException(); }

    /// <summary>Finds person name by email or name and surname</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetNameFromMail.htm"/>
    ///
    /// <param name="email">Person email</param>
    /// <param name="displayName">Person email display name</param>
    public static string GetNameFromMail(
        string email,
        string displayName
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns system person</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetSystem.htm"/>
    public static tPerson GetSystem() { throw new System.NotImplementedException(); }

    /// <summary>Returns user's timezone. If person does not have timezone specified, system timezone is returned.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetTimezone.htm"/>
    ///
    /// <param name="person">Person to get timezone for</param>
    public static string GetTimezone(
        tPerson person
    ) { throw new System.NotImplementedException(); }

    /// <summary>Gets Azure Active Directory Bearer token from the on-behalf-of flow. The token can be used for communication with other Azure services on behalf of the user.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_GetToken.htm"/>
    ///
    /// <param name="personId">The ID of the person (tPerson.iPersonId) who is the subject of the token.</param>
    /// <param name="scope">Scope (target application) the token is intended for.</param>
    public static string GetToken(
        int personId,
        string scope
    ) { throw new System.NotImplementedException(); }

    /// <summary>Inserts an email address to persons email usage</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_InsertToEmailUsage.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="email">Email address</param>
    public static void InsertToEmailUsage(
        int personId,
        string email
    ) { throw new System.NotImplementedException(); }

    /// <summary>Checks whether person is member of group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_IsMemberOfGroup.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleId">Group ID (tRole.iRoleId)</param>
    public static bool IsMemberOfGroup(
        int personId,
        int roleId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Recompute contents of PersonManager table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_RecomputePersonManager.htm"/>
    public static void RecomputePersonManager() { throw new System.NotImplementedException(); }

    /// <summary>Removes person from group.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_RemoveFromGroup.htm"/>
    ///
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleId">Group ID (tRole.iRoleId)</param>
    public static void RemoveFromGroup(
        int personId,
        int roleId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Updates person.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Person_Update.htm"/>
    ///
    /// <param name="person">Person to update</param>
    public static void Update(
        tPerson person
    ) { throw new System.NotImplementedException(); }
}
