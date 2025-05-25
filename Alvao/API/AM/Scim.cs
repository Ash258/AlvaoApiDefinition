using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping AM SCIM methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html"/>
public static class Scim {
    /// <summary>Create new user if none exists with given UserName or AdGuid. Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html#Alvao_API_AM_Scim_CreateUser_System_String_System_String_System_String_System_Collections_Generic_IDictionary_Alvao_API_Common_Model_Database_tblKind_KindCode_System_Object__System_Collections_Generic_IDictionary_System_Int32_System_Object__"/>
    /// <param name="userName">User Name (Login)</param>
    /// <param name="adGuid">Object AD Guid (NodeCust.AdGuid)</param>
    /// <param name="email">Email</param>
    /// <param name="properties">Object properties</param>
    /// <param name="extensionProperties">Object extension properties. Key is property KindId (tblKind.intKindId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when method is called elsewhere than in the SCIM user import.</exception>
    /// <returns>Object ID (tblNode.intNodeId) of user object (new or already existing)</returns>
    public static int CreateUser(string userName, string adGuid, string email, IDictionary<tblKind.KindCode, dynamic> properties, IDictionary<int, dynamic> extensionProperties) { throw new System.NotImplementedException(); }
    /// <summary>Get string value for property 'Account is disabled' Method can only be called within SCIM user import.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html#Alvao_API_AM_Scim_GetAccountDisabledStringValue_System_Boolean_"/>
    /// <param name="disabled">Boolean value of property</param>
    /// <exception cref="UnauthorizedAccessException">Throws when method is called elsewhere than in the SCIM user import.</exception>
    /// <returns>String value for property.</returns>
    public static string GetAccountDisabledStringValue(bool disabled) { throw new System.NotImplementedException(); }
    /// <summary>Get user properties Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html#Alvao_API_AM_Scim_GetUserProperties_System_Int32_System_Collections_Generic_IEnumerable_System_Int32__"/>
    /// <param name="personId">Service Desk Person Id (tPerson.iPersonId). Asset user is found via database view vAssetUserPerson</param>
    /// <param name="properties">List of KindIds (tblKind.intKindId) of properties to get</param>
    public static IDictionary<int, dynamic> GetUserProperties(int personId, IEnumerable<int> properties) { throw new System.NotImplementedException(); }
    /// <summary>Check if AM SCIM import is enabled or not. Import is enabled when AM module is activated and import is not explicitly disabled in tProperty (AM.Scim.ImportUsers)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html#Alvao_API_AM_Scim_IsImportEnabled"/>
    /// <exception cref="UnauthorizedAccessException">Throws when method is called elsewhere than in the SCIM user import.</exception>
    /// <returns>True if Asset import is enabled, otherwise false</returns>
    public static bool IsImportEnabled() { throw new System.NotImplementedException(); }
    /// <summary>Update existing user properties Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.Scim.html#Alvao_API_AM_Scim_UpdateUser_System_Int32_System_Collections_Generic_IDictionary_Alvao_API_Common_Model_Database_tblKind_KindCode_System_Object__System_Collections_Generic_IDictionary_System_Int32_System_Object__"/>
    /// <param name="personId">Service Desk Person Id (tPerson.iPersonId). Asset user is found via database view vAssetUserPerson</param>
    /// <param name="properties">User properties to update</param>
    /// <param name="extensionProperties">User extension properties to update. Key is property KindId (tblKind.intKindId)</param>
    /// <exception cref="UnauthorizedAccessException">Throws when method is called elsewhere than in the SCIM user import.</exception>
    public static void UpdateUser(int personId, IDictionary<tblKind.KindCode, dynamic> properties, IDictionary<int, dynamic> extensionProperties) { throw new System.NotImplementedException(); }
}
