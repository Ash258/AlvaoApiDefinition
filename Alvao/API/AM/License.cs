using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html"/>
public static class License {
    /// <summary>Adds new product to license or updates it's notes.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_AddOrUpdateProduct_System_Int32_System_Int32_System_String_"/>
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="productId">Product (tblProduct.intProductId)</param>
    /// <param name="notes">Notes added to assignment of product</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to manage the license.
    /// </exception>
    public static void AddOrUpdateProduct(int licenseId, int productId, string notes) { throw new System.NotImplementedException(); }
    /// <summary>Adds or updates relation between two licenses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_AddOrUpdateRelation_System_Int32_System_Int32_System_Int32_System_Int32_"/>
    /// <param name="sourceLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="targetLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="relationTypeId">Relation type (LicHistRelationType.id)</param>
    /// <param name="relationId">Relation (LicHistRelation.id). If relationId is 0, new relation is created.</param>
    public static void AddOrUpdateRelation(int sourceLicenseId, int targetLicenseId, int relationTypeId, int relationId = 0) { throw new System.NotImplementedException(); }
    /// <summary>Assigns license to object (device or user)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_Assign_Alvao_API_Common_Model_Database_tblLicHistItem_"/>
    /// <param name="assignment">Db model of assignment. Should contain License Id (tblLicHist.intLicHistId)</param>
    /// <exception cref="LicenseAlreadyAssignedException">
    /// Throws when license is already assigned to the object.
    /// </exception>
    /// <exception cref="LicenseException">
    /// Throws when any assignment property has forbidden value.
    /// </exception>
    public static void Assign(tblLicHistItem assignment) { throw new System.NotImplementedException(); }
    /// <summary>Auto assigns licenses either to a computer (objectId != null) or specific license to all computers (licenseId != null) or all licenses to all computers (licenseId == null and objectId == null).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_AutoAssign_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="objectId">Object (computer) ID (tblNode.intNodeId) to auto assign licenses</param>
    /// <param name="licenseId">License (tblHist.intLicHistId) to auto assign</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    /// <returns>Number of assigned licenses.</returns>
    public static int AutoAssign(int? objectId = null, int? licenseId = null, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Auto releases licenses either from a computer (objectId != null) or specific license from all computers (licenseId != null) or all licenses from all computers (licenseId == null and objectId == null).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_AutoRelease_System_Nullable_System_Int32__System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="objectId">Object ID (tblNode.intNodeId) to auto release licenses</param>
    /// <param name="licenseId">License (tblHist.intLicHistId) to auto assign</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    /// <returns>Number of released licenses.</returns>
    public static int AutoRelease(int? objectId = null, int? licenseId = null, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether the user has the right to manage the license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CanUserManage_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    /// <returns>True, if the user has the right to manage the license.</returns>
    public static bool CanUserManage(int licenseId, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether the user has the right to manage any license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CanUserManageAny_System_Nullable_System_Int32__"/>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    /// <returns>True, if the user has the right to manage any license.</returns>
    public static bool CanUserManageAny(int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether the user has the right to manage the license in organization.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CanUserManageInOrganization_System_Nullable_System_Int32__System_Nullable_System_Int32__"/>
    /// <param name="nodeId">Organization (tblNode.intNodeId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    /// <returns>True, if the user has the right to manage the license.</returns>
    public static bool CanUserManageInOrganization(int? nodeId, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether the user has the right to read the license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CanUserRead_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    /// <returns>True, if the user has the right to read the license.</returns>
    public static bool CanUserRead(int licenseId, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Checks whether the user has the right to read any license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CanUserReadAny_System_Nullable_System_Int32__"/>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    /// <returns>True, if the user has the right to read any license.</returns>
    public static bool CanUserReadAny(int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Create or update license</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_CreateOrUpdate_Alvao_API_Common_Model_Database_tblLicHist_"/>
    /// <param name="license">Db model of license.</param>
    /// <exception cref="LicenseException">
    /// Throws when any license property has forbidden value.
    /// </exception>
    public static int CreateOrUpdate(tblLicHist license) { throw new System.NotImplementedException(); }
    /// <summary>Detele assignment</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_DeleteAssignment_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to manage the license.
    /// </exception>
    public static void DeleteAssignment(int licItemId, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Edit assignment of license</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_EditAssignment_Alvao_API_Common_Model_Database_tblLicHistItem_"/>
    /// <param name="assignment">Db model of assignment. Should contain License Id (tblLicHist.intLicHistId)</param>
    /// <exception cref="LicenseException">
    /// Throws when any assignment property has forbidden value.
    /// </exception>
    public static void EditAssignment(tblLicHistItem assignment) { throw new System.NotImplementedException(); }
    /// <summary>Gets license db model by license id</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_GetById_System_Int32_"/>
    /// <param name="id">License ID (tblLicHist.intLicHistId)</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to read the license.
    /// </exception>
    /// <exception cref="LicenseNotFoundException">
    /// Throws when license was not found.
    /// </exception>
    public static tblLicHist GetById(int id) { throw new System.NotImplementedException(); }
    /// <summary>Gets license item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_GetItemById_System_Int32_"/>
    /// <param name="licenseItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    public static tblLicHistItem GetItemById(int licenseItemId) { throw new System.NotImplementedException(); }
    /// <summary>Returns record from which is covered product installation on object from parameter.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_GetShared_System_Int32_System_Int32_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId) which is covered by license</param>
    /// <param name="objectId">Object (device) ID (tblNode.intNodeId) which is covered by license</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to read licenses.
    /// </exception>
    /// <returns>Record from which a license is shared. If the license is not shared, returns null.</returns>
    public static tblLicTrans GetShared(int productId, int objectId) { throw new System.NotImplementedException(); }
    /// <summary>Gets all valid license items</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_GetValidItems_System_Int32_"/>
    /// <param name="licenseId">License ID (tblLicHist.intLicHistId)</param>
    public static IEnumerable<tblLicHistItem> GetValidItems(int licenseId) { throw new System.NotImplementedException(); }
    /// <summary>Moves license item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_Move_System_Int32_System_Nullable_System_Int32__System_String_"/>
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="targetObjectId">Object ID (tblNode.intNodeId) where to move the license.</param>
    /// <param name="targetCostCenter">Cost center name where to move the license.</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to manage the license.
    /// </exception>
    /// <exception cref="LicenseAlreadyAssignedException">
    /// Throws when license is already assigned to the object.
    /// </exception>
    public static void Move(int licItemId, int? targetObjectId = null, string targetCostCenter = null) { throw new System.NotImplementedException(); }
    /// <summary>Releases license item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_Release_System_Int32_System_Nullable_System_Int32__"/>
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to manage the license.
    /// </exception>
    public static void Release(int licItemId, int? personId = null) { throw new System.NotImplementedException(); }
    /// <summary>Removes license relation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_RemoveRelation_System_Int32_System_Int32_"/>
    /// <param name="sourceLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="relationId">Relation (LicHistRelation.id)</param>
    public static void RemoveRelation(int sourceLicenseId, int relationId) { throw new System.NotImplementedException(); }
    /// <summary>Remove sharing of a license.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_RemoveSharing_System_Int32_System_Int32_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    /// <exception cref="UnauthorizedAccessException">
    /// Throws when user does not have rights to manage licenses.
    /// </exception>
    public static void RemoveSharing(int productId, int objectId) { throw new System.NotImplementedException(); }
    /// <summary>Shares license item</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_Share_System_Int32_System_Int32_System_Int32_System_String_"/>
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId) which will get the license.</param>
    /// <param name="licenseObjectId">Object ID (tblNode.intNodeId) which will share the license.</param>
    /// <param name="note">Share license text note.</param>
    public static void Share(int productId, int objectId, int licenseObjectId, string note) { throw new System.NotImplementedException(); }
    /// <summary>Sets new license count</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AM.License.html#Alvao_API_AM_License_UpdateCount_System_Int32_System_Int32_"/>
    /// <param name="licenseId">License ID (tblLicHist.intLicHistId)</param>
    /// <param name="count">New license count</param>
    /// <exception cref="ArgumentException">
    /// Throws when license with ID licenseId doesn't exist.
    /// </exception>
    public static void UpdateCount(int licenseId, int count) { throw new System.NotImplementedException(); }
}
