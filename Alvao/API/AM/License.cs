using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_License.htm"/>
public static class License
{

    /// <summary>Adds new product to license or updates it's notes.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_AddOrUpdateProduct.htm"/>
    ///
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="productId">Product (tblProduct.intProductId)</param>
    /// <param name="notes">Notes added to assignment of product</param>
    public static void AddOrUpdateProduct(
        int licenseId,
        int productId,
        string notes
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Adds or updates relation between two licenses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_AddOrUpdateRelation.htm"/>
    ///
    /// <param name="sourceLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="targetLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="relationTypeId">Relation type (LicHistRelationType.id)</param>
    /// <param name="relationId">Relation (LicHistRelation.id). If relationId is 0, new relation is created.</param>
    public static void AddOrUpdateRelation(
        int sourceLicenseId,
        int targetLicenseId,
        int relationTypeId,
        int relationId = 0
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Assigns license to object (device or user)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_Assign.htm"/>
    ///
    /// <param name="assgignment">Db model of assignment. Should contain License Id (tblLicHist.intLicHistId)</param>
    public static void Assign(
        tblLicHistItem assgignment
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Auto assigns licenses either to a computer (objectId != null) or specific license to all computers (licenseId != null) or all licenses to all computers (licenseId == null and objectId == null).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_AutoAssign.htm"/>
    ///
    /// <param name="objectId">Object (computer) ID (tblNode.intNodeId) to auto assign licenses</param>
    /// <param name="licenseId">License (tblHist.intLicHistId) to auto assign</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    public static int AutoAssign(
        int? objectId = null,
        int? licenseId = null,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Auto releases licenses either from a computer (objectId != null) or specific license from all computers (licenseId != null) or all licenses from all computers (licenseId == null and objectId == null).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_AutoRelease.htm"/>
    ///
    /// <param name="objectId">Object ID (tblNode.intNodeId) to auto release licenses</param>
    /// <param name="licenseId">License (tblHist.intLicHistId) to auto assign</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    public static int AutoRelease(
        int? objectId = null,
        int? licenseId = null,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether the user has the right to manage the license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CanUserManage.htm"/>
    ///
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static bool CanUserManage(
        int licenseId,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether the user has the right to manage any license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CanUserManageAny.htm"/>
    ///
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static bool CanUserManageAny(
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether the user has the right to manage the license in organization.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CanUserManageInOrganization.htm"/>
    ///
    /// <param name="nodeId">Organization (tblNode.intNodeId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static bool CanUserManageInOrganization(
        int? nodeId,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether the user has the right to read the license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CanUserRead.htm"/>
    ///
    /// <param name="licenseId">License (tblHist.intLicHistId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static bool CanUserRead(
        int licenseId,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Checks whether the user has the right to read any license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CanUserReadAny.htm"/>
    ///
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static bool CanUserReadAny(
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Create or update license</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_CreateOrUpdate.htm"/>
    ///
    /// <param name="license">Db model of license.</param>
    public static int CreateOrUpdate(
        tblLicHist license
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Detele assignment</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_DeleteAssignment.htm"/>
    ///
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    public static void DeleteAssignment(
        int licItemId,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Edit assignment of license</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_EditAssignment.htm"/>
    ///
    /// <param name="assgignment">Db model of assignment. Should contain License Id (tblLicHist.intLicHistId)</param>
    public static void EditAssignment(
        tblLicHistItem assgignment
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Gets license db model by license id</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_GetById.htm"/>
    ///
    /// <param name="id">License ID (tblLicHist.intLicHistId)</param>
    public static tblLicHist GetById(
        int id
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Gets license item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_GetItemById.htm"/>
    ///
    /// <param name="licenseItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    public static tblLicHistItem GetItemById(
        int licenseItemId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Returns record from which is covered product installation on object from parameter.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_GetShared.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId) which is covered by license</param>
    /// <param name="objectId">Object (device) ID (tblNode.intNodeId) which is covered by license</param>
    public static tblLicTrans GetShared(
        int productId,
        int objectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Gets all valid license items</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_GetValidItems.htm"/>
    ///
    /// <param name="licenseId">License ID (tblLicHist.intLicHistId)</param>
    public static IEnumerable<tblLicHistItem> GetValidItems(
        int licenseId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Moves license item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_Move.htm"/>
    ///
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="targetObjectId">Object ID (tblNode.intNodeId) where to move the license.</param>
    /// <param name="targetCostCenter">Cost center name where to move the license.</param>
    public static void Move(
        int licItemId,
        int? targetObjectId = null,
        string targetCostCenter = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Releases license item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_Release.htm"/>
    ///
    /// <param name="licItemId">License item ID (tblLicHistItem.intLicHistItemId)</param>
    /// <param name="personId">User ID (tPerson.iPersonId) recorded in object log.</param>
    public static void Release(
        int licItemId,
        int? personId = null
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Removes license relation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_RemoveRelation.htm"/>
    ///
    /// <param name="sourceLicenseId">License (tblHist.intLicHistId)</param>
    /// <param name="relationId">Relation (LicHistRelation.id)</param>
    public static void RemoveRelation(
        int sourceLicenseId,
        int relationId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Remove sharing of a license.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_RemoveSharing.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId)</param>
    public static void RemoveSharing(
        int productId,
        int objectId
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Shares license item</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_Share.htm"/>
    ///
    /// <param name="productId">Product ID (tblProduct.intProductId)</param>
    /// <param name="objectId">Object ID (tblNode.intNodeId) which will get the license.</param>
    /// <param name="licenseObjectId">Object ID (tblNode.intNodeId) which will share the license.</param>
    /// <param name="note">Share license text note.</param>
    public static void Share(
        int productId,
        int objectId,
        int licenseObjectId,
        string note
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Sets new license count</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_License_UpdateCount.htm"/>
    ///
    /// <param name="licenseId">License ID (tblLicHist.intLicHistId)</param>
    /// <param name="count">New license count</param>
    public static void UpdateCount(
        int licenseId,
        int count
    )
    { throw new System.NotImplementedException(); }
}
