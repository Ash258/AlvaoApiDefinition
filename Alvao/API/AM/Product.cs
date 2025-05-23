using Alvao.API.Common.Model.Database;

namespace Alvao.API.AM;

/// <summary>Facade class grouping AM Products methods.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AM_Product.htm"/>
public static class Product {

    /// <summary>Add custom product to queue that will be sent to validation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_AddCustomProductToValidationQueueTable.htm"/>
    ///
    /// <param name="productId">Product object (tblProduct.intProductId)</param>
    public static void AddCustomProductToValidationQueueTable(
        int productId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Adds component to product package if the package is not certified by ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_AddPackageComponent.htm"/>
    ///
    /// <param name="productId">Product package ID (tblProduct.intProductId)</param>
    /// <param name="componentId">Product component ID(tblProduct.intProductId) which needs to be added from the package.</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static void AddPackageComponent(
        int productId,
        int componentId,
        int? personId = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Creates or updates new Product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_CreateOrUpdate.htm"/>
    ///
    /// <param name="product">Product object (tblProduct)</param>
    public static int CreateOrUpdate(
        tblProduct product
    ) { throw new System.NotImplementedException(); }

    /// <summary>Permanently deletes custom product from database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_Delete.htm"/>
    ///
    /// <param name="productId">Product Id (tblProduct.intProductId)</param>
    public static void Delete(
        int productId
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns existing Product from Db.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_GetById.htm"/>
    ///
    /// <param name="id">Product object (tblProduct.intProductId)</param>
    public static tblProduct GetById(
        int id
    ) { throw new System.NotImplementedException(); }

    /// <summary>Changes status of product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_ChangeStatus.htm"/>
    ///
    /// <param name="productId">Product package ID (tblProduct.intProductId)</param>
    /// <param name="status">Product status ID(ProductState.id).</param>
    /// <param name="approvedVersion">Version of product which is approved.</param>
    /// <param name="willBeRetired">Date when product will be retired.</param>
    public static void ChangeStatus(
        int productId,
        int status,
        string approvedVersion = null,
        DateTime? willBeRetired = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Returns true if product is certified by ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_IsCertifiedByALVAO.htm"/>
    ///
    /// <param name="id">Product object (tblProduct.intProductId)</param>
    public static bool IsCertifiedByALVAO(
        int id
    ) { throw new System.NotImplementedException(); }

    /// <summary>Removes component from product package if the package is not certified by ALVAO.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_RemovePackageComponent.htm"/>
    ///
    /// <param name="productId">Product package ID (tblProduct.intProductId)</param>
    /// <param name="componentId">Product component ID(tblProduct.intProductId) which needs to be removed from the package.</param>
    /// <param name="personId">User ID (tPerson.iPersonId) if not specified its current user id.</param>
    public static void RemovePackageComponent(
        int productId,
        int componentId,
        int? personId = null
    ) { throw new System.NotImplementedException(); }

    /// <summary>Replaces custom product with certified product.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AM_Product_ReplaceWithCertified.htm"/>
    ///
    /// <param name="productId">Product to be replaced ID (tblProduct.intProductId)</param>
    /// <param name="newProductId">Product status ID(ProductState.id).</param>
    public static void ReplaceWithCertified(
        int productId,
        int newProductId
    ) { throw new System.NotImplementedException(); }
}
