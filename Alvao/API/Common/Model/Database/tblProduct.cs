using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products / software (software product library).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html"/>
[Table("dbo.tblProduct")]
public class tblProduct {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductCategory.html#fields"/>
    public enum ProductCategory {
        OS = 1,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductState.html#fields"/>
    public enum ProductState {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedRetirementPlanned = 4,
        Excluded = 5,
        Rejected = 6,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductType.html#fields"/>
    public enum ProductType {
        Commercial = 1,
        Freeware = 2,
        Shareware = 3,
        Unspecified = 4,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.SamType.html#fields"/>
    public enum SamType {
        Yes = 1,
        No = 2,
        Notify = 3,
    }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_AddToSoftwareLibrary"/>
    [Ignore]
    public bool AddToSoftwareLibrary { get; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_AlternateApprovedProduct"/>
    /// <remarks>Column <c>AlternateApprovedProduct</c>: nvarchar(max), null.</remarks>
    public virtual string AlternateApprovedProduct { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_CpeMatchScore"/>
    /// <remarks>Column <c>CpeMatchScore</c>: float, not null.</remarks>
    public virtual double CpeMatchScore { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_FullName"/>
    /// <remarks>Column <c>FullName</c>: nvarchar(1023), null.</remarks>
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_IsProductCpeManual"/>
    /// <remarks>Column <c>IsProductCpeManual</c>: bit, not null.</remarks>
    public virtual bool IsProductCpeManual { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductCpe"/>
    /// <remarks>Column <c>ProductCpe</c>: nvarchar(max), null.</remarks>
    public virtual string ProductCpe { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductRejectedFrom"/>
    /// <remarks>Column <c>ProductRejectedFrom</c>: datetime, null.</remarks>
    public virtual DateTime? ProductRejectedFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateId"/>
    /// <remarks>Column <c>ProductStateId</c>: int, not null. References <see cref="ProductState"/>.</remarks>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedDate"/>
    /// <remarks>Column <c>ProductStateModifiedDate</c>: datetime, null.</remarks>
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedPersonId"/>
    /// <remarks>Column <c>ProductStateModifiedPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? ProductStateModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_SamTypeId"/>
    /// <remarks>Column <c>SamTypeId</c>: int, not null. References <see cref="SamType"/>.</remarks>
    public virtual int SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_SupportedVersion"/>
    /// <remarks>Column <c>SupportedVersion</c>: nvarchar(32), null.</remarks>
    public virtual string SupportedVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_WaitingForValidation"/>
    [Ignore]
    public bool WaitingForValidation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_bolValid"/>
    /// <remarks>Column <c>bolValid</c>: bit, not null.</remarks>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_dteTimeStamp"/>
    /// <remarks>Column <c>dteTimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intFlags"/>
    /// <remarks>Column <c>intFlags</c>: int, null.</remarks>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intProductId"/>
    /// <remarks>Column <c>intProductId</c>: int, not null.</remarks>
    [Key]
    public virtual int intProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intProductUID"/>
    /// <remarks>Column <c>intProductUID</c>: int, null.</remarks>
    public virtual int? intProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintLangId"/>
    /// <remarks>Column <c>lintLangId</c>: int, null.</remarks>
    public virtual int? lintLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProducerCompanyId"/>
    /// <remarks>Column <c>lintProducerCompanyId</c>: int, null. References <see cref="tblCompany"/>.</remarks>
    public virtual int? lintProducerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProductCategoryId"/>
    /// <remarks>Column <c>lintProductCategoryId</c>: int, null. References <see cref="tblProductCategory"/>.</remarks>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProductTypeId"/>
    /// <remarks>Column <c>lintProductTypeId</c>: int, not null. References <see cref="tblProductType"/>.</remarks>
    public virtual int lintProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_nPrice"/>
    /// <remarks>Column <c>nPrice</c>: float, null.</remarks>
    public virtual double? nPrice { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtCertifiedBy"/>
    /// <remarks>Column <c>txtCertifiedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtDescription"/>
    /// <remarks>Column <c>txtDescription</c>: nvarchar(255), null.</remarks>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtEdition"/>
    /// <remarks>Column <c>txtEdition</c>: nvarchar(255), null.</remarks>
    public virtual string txtEdition { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), not null.</remarks>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtPlatform"/>
    /// <remarks>Column <c>txtPlatform</c>: nvarchar(255), null.</remarks>
    public virtual string txtPlatform { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtVersion"/>
    /// <remarks>Column <c>txtVersion</c>: nvarchar(255), null.</remarks>
    public virtual string txtVersion { get; set; }
}
