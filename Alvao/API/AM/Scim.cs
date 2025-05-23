using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping AM SCIM methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Scim.htm"/>
public static class Scim
{

    /// <summary>Create new user if none exists with given UserName or AdGuid. Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Scim_CreateUser.htm"/>
    ///
    /// <param name="userName">User Name (Login)</param>
    /// <param name="adGuid">Object AD Guid (tblNode.txtLDAPGUID)</param>
    /// <param name="properties">Object properties</param>
    /// <param name="extensionProperties">Object extension properties. Key is property KindId (tblKind.intKindId)</param>
    public static int CreateUser(
        string userName,
        string adGuid,
        IDictionary<tblKind.KindCode, string> properties,
        IDictionary<int, string> extensionProperties
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get string value for property 'Account is disabled' Method can only be called within SCIM user import.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Scim_GetAccountDisabledStringValue.htm"/>
    ///
    /// <param name="disabled">Boolean value of property</param>
    public static string GetAccountDisabledStringValue(
        bool disabled
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Get user properties Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Scim_GetUserProperties.htm"/>
    ///
    /// <param name="personId">Service Desk Person Id (tPerson.iPersonId). Asset user is found via database view vAssetUserPerson</param>
    /// <param name="properties">List of KindIds (tblKind.intKindId) of properties to get</param>
    public static IEnumerable<tblProperty> GetUserProperties(
        int personId,
        IEnumerable<int> properties
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Check if AM SCIM import is enabled or not. Import is enabled when AM module is activated and import is not explicitly disabled in tProperty (AM.Scim.ImportUsers)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Scim_IsImportEnabled.htm"/>
    public static bool IsImportEnabled() { throw new System.NotImplementedException(); }

    /// <summary>Update existing user properties Method can only be called within SCIM user import only.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Scim_UpdateUser.htm"/>
    ///
    /// <param name="personId">Service Desk Person Id (tPerson.iPersonId). Asset user is found via database view vAssetUserPerson</param>
    /// <param name="properties">User properties to update</param>
    /// <param name="extensionProperties">User extension properties to update. Key is property KindId (tblKind.intKindId)</param>
    public static void UpdateUser(
        int personId,
        IDictionary<tblKind.KindCode, string> properties,
        IDictionary<int, string> extensionProperties
    )
    { throw new System.NotImplementedException(); }
}
