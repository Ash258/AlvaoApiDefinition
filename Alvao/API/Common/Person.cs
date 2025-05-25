using System.Globalization;
using Alvao.API.Common.Model.Database;

namespace Alvao.API.Common;

/// <summary>Facade class grouping person methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html"/>
public static class Person {
    /// <summary>Adds person to group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_AddToGroup_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleIds">Group IDs (tRole.iRoleId)</param>
    public static void AddToGroup(int personId, IEnumerable<int> roleIds) { throw new System.NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_ConvertUtcToPersonLocal_Alvao_API_Common_Model_Database_tPerson_System_DateTime_"/>
    public static DateTime ConvertUtcToPersonLocal(tPerson person, DateTime utcDate) { throw new System.NotImplementedException(); }
    /// <summary>Creates person.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_Create_System_String_System_String_System_String_System_String_System_String_System_String_System_Nullable_System_Int32__"/>
    /// <param name="fullName">Name and surname</param>
    /// <param name="login">User name</param>
    /// <param name="email">E-mail</param>
    /// <param name="phone">Work phone</param>
    /// <param name="personalNumber">Personal number</param>
    /// <param name="azureAdObjectId">Object ID from Azure AD</param>
    /// <param name="azureAdTenantId">Tenant ID from Azure AD</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when fullName is null.
    /// </exception>
    /// <returns>Created person ID (tPerson.iPersonId)</returns>
    public static int Create(string fullName, string login, string email, string phone, string personalNumber, string azureAdObjectId = null, int? azureAdTenantId = null) { throw new System.NotImplementedException(); }
    /// <summary>Returns all persons</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetAll_System_Boolean_"/>
    /// <param name="includeRemoved">Include removed persons in result</param>
    /// <returns>Collection of tPerson</returns>
    public static IEnumerable<tPerson> GetAll(bool includeRemoved = false) { throw new System.NotImplementedException(); }
    /// <summary>Search for person by AzureObjectId. If not found, tries to find by person SID and then by email.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetByAzureIdSidOrEmail_System_String_System_String_System_String_"/>
    /// <param name="azureAdObjectId">Azure Active Directory object ID. Cannot be null.</param>
    /// <param name="userSid">User SID from on-premise AD or null</param>
    /// <param name="email">User email or null</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when azureAdObjectId is null.
    /// </exception>
    /// <returns>Found person (tPerson) or null if there was no such person</returns>
    public static tPerson GetByAzureIdSidOrEmail(string azureAdObjectId, string userSid = null, string email = null) { throw new System.NotImplementedException(); }
    /// <summary>Return all persons which are synchronized from Azure Active Directory tenant.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetByAzureTenant_System_Int32_"/>
    /// <param name="azureAdTenantId">Azure Tenant ID</param>
    public static IEnumerable<tPerson> GetByAzureTenant(int azureAdTenantId) { throw new System.NotImplementedException(); }
    /// <summary>Returns person by email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetByEmail_System_String_"/>
    /// <param name="email">Person email</param>
    /// <returns>Person object email (tPerson)</returns>
    public static tPerson GetByEmail(string email) { throw new System.NotImplementedException(); }
    /// <summary>Returns person</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetById_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <returns>Person object (tPerson)</returns>
    public static tPerson GetById(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Search for person by persons login</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetByLogin_System_String_"/>
    /// <param name="login">Person login</param>
    public static tPerson GetByLogin(string login) { throw new System.NotImplementedException(); }
    /// <summary>Returns CultureInfo for given person. If person does not have set preffered language , CultureInfo of system language is returned.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetCultureInfoOrDefault_Alvao_API_Common_Model_Database_tPerson_"/>
    /// <param name="person">Person to get CultureInfo for</param>
    /// <returns>Found CultureInfo</returns>
    public static CultureInfo GetCultureInfoOrDefault(tPerson person) { throw new System.NotImplementedException(); }
    /// <summary>Returns custom list of persons.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetCustomList_System_String_System_String_System_String_"/>
    /// <param name="columns">Database columns from tPerson and tPersonCust. These columns will be included in the result</param>
    /// <param name="filterCondition">SQL filter condition (without WHERE keyword)</param>
    /// <param name="sorting">SQL sorting condition (without ORDER BY keyword)</param>
    /// <returns>List of dynamic objects. Each object has properties specified in columns parameter.</returns>
    public static IEnumerable<dynamic> GetCustomList(string columns, string filterCondition, string sorting) { throw new System.NotImplementedException(); }
    /// <summary>Returns group ID (tRole.iRoleId) of all groups that the person is member of.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetGroupMembership_System_Int32_System_Boolean_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="onlyDirectMembership">Get only direct membership</param>
    /// <returns>List of groups ID</returns>
    public static IEnumerable<int> GetGroupMembership(int personId, bool onlyDirectMembership) { throw new System.NotImplementedException(); }
    /// <summary>Returns guest person</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetGuest"/>
    /// <returns>Guest person object (tPerson)</returns>
    public static tPerson GetGuest() { throw new System.NotImplementedException(); }
    /// <summary>Finds person name by email or name and surname</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetNameFromMail_System_String_System_String_"/>
    /// <param name="email">Person email</param>
    /// <param name="displayName">Person email display name</param>
    /// <returns>Person name and surname</returns>
    public static string GetNameFromMail(string email, string displayName) { throw new System.NotImplementedException(); }
    /// <summary>Returns person by email GetPersonByEmail is deprecated, please use GetByEmail instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetPersonByEmail_System_String_"/>
    /// <param name="email">Person email</param>
    /// <returns>Person object email (tPerson)</returns>
    [Obsolete("GetPersonByEmail is deprecated, please use GetByEmail instead.")]
    public static tPerson GetPersonByEmail(string email) { throw new System.NotImplementedException(); }
    /// <summary>Returns person GetPersonById is deprecated, please use GetById instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetPersonById_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <returns>Person object (tPerson)</returns>
    [Obsolete("GetPersonById is deprecated, please use GetById instead.")]
    public static tPerson GetPersonById(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Returns CultureInfo for given person. If person does not have set preffered language , CultureInfo of system language is returned. GetPersonCultureInfoOrDefault is deprecated, please use GetCultureInfoOrDefault instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetPersonCultureInfoOrDefault_Alvao_API_Common_Model_Database_tPerson_"/>
    /// <param name="person">Person to get CultureInfo for</param>
    /// <returns>Found CultureInfo</returns>
    [Obsolete("GetPersonCultureInfoOrDefault is deprecated, please use GetCultureInfoOrDefault instead.")]
    public static CultureInfo GetPersonCultureInfoOrDefault(tPerson person) { throw new System.NotImplementedException(); }
    /// <summary>Returns system person</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetSystem"/>
    /// <returns>System person object (tPerson)</returns>
    public static tPerson GetSystem() { throw new System.NotImplementedException(); }
    /// <summary>Returns user's timezone. If person does not have timezone specified, system timezone is returned.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetTimezone_Alvao_API_Common_Model_Database_tPerson_"/>
    /// <param name="person">Person to get timezone for</param>
    /// <returns>Timezone name</returns>
    public static string GetTimezone(tPerson person) { throw new System.NotImplementedException(); }
    /// <summary>Gets Azure Active Directory Bearer token from the on-behalf-of flow. The token can be used for communication with other Azure services on behalf of the user.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetToken_System_Int32_System_String_"/>
    /// <param name="personId">The ID of the person (tPerson.iPersonId) who is the subject of the token.</param>
    /// <param name="scope">Scope (target application) the token is intended for.</param>
    /// <exception cref="UserTokenServiceError">
    /// An unexpected error occurred.
    /// </exception>
    /// <returns>Bearer token or null if getting a token is impossible.</returns>
    public static string GetToken(int personId, string scope) { throw new System.NotImplementedException(); }
    /// <summary>Returns NodeId for given personId. If person does not connected object user null is returned.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_GetUserNodeIdByPersonId_System_Int32_"/>
    /// <param name="personId">Person Id to get NodeId for</param>
    /// <returns>Found NodeId</returns>
    public static int? GetUserNodeIdByPersonId(int personId) { throw new System.NotImplementedException(); }
    /// <summary>Inserts an email address to persons email usage</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_InsertToEmailUsage_System_Int32_System_String_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="email">Email address</param>
    public static void InsertToEmailUsage(int personId, string email) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether person is member of group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_IsMemberOfGroup_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleId">Group ID (tRole.iRoleId)</param>
    /// <returns>Is person member of group</returns>
    public static bool IsMemberOfGroup(int personId, int roleId) { throw new System.NotImplementedException(); }
    /// <summary>Recompute contents of PersonManager table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_RecomputePersonManager"/>
    public static void RecomputePersonManager() { throw new System.NotImplementedException(); }
    /// <summary>Removes person from group.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_RemoveFromGroup_System_Int32_System_Int32_"/>
    /// <param name="personId">Person ID (tPerson.iPersonId)</param>
    /// <param name="roleId">Group ID (tRole.iRoleId)</param>
    public static void RemoveFromGroup(int personId, int roleId) { throw new System.NotImplementedException(); }
    /// <summary>Updates person.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Person.html#Alvao_API_Common_Person_Update_Alvao_API_Common_Model_Database_tPerson_"/>
    /// <param name="person">Person to update</param>
    /// <exception cref="ArgumentNullException">
    /// Throws when person is null.
    /// </exception>
    public static void Update(tPerson person) { throw new System.NotImplementedException(); }
}
