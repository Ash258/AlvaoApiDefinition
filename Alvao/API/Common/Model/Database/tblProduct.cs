using AutoMapper.Configuration.Annotations;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products / software (software products library).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html"/>
[Table("dbo.tblProduct")]
public class tblProduct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductCategory.html#fields"/>
    public enum ProductCategory {
        OS = 1,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductState.html#fields"/>
    public enum ProductState {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedRetirementPlanned = 4,
        Excluded = 5,
        Rejected = 6,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.ProductType.html#fields"/>
    public enum ProductType {
        Commercial = 1,
        Freeware = 2,
        Shareware = 3,
        Unspecified = 4,
    }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.SamType.html#fields"/>
    public enum SamType {
        Yes = 1,
        No = 2,
        Notify = 3,
    }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_AddToSoftwareLibrary"/>
    [Ignore]
    public bool AddToSoftwareLibrary { get; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_AlternateApprovedProduct"/>
    public virtual string AlternateApprovedProduct { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_FullName"/>
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductRejectedFrom"/>
    public virtual DateTime? ProductRejectedFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateId"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedDate"/>
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedPersonId"/>
    public virtual int? ProductStateModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_SamTypeId"/>
    public virtual int SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_SupportedVersion"/>
    public virtual string SupportedVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_WaitingForValidation"/>
    [Ignore]
    public bool WaitingForValidation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intProductId"/>
    [Key]
    public virtual int intProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_intProductUID"/>
    public virtual int? intProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintLangId"/>
    public virtual int? lintLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProducerCompanyId"/>
    public virtual int? lintProducerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProductCategoryId"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_lintProductTypeId"/>
    public virtual int lintProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_nPrice"/>
    public virtual double? nPrice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtDescription"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtEdition"/>
    public virtual string txtEdition { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtPlatform"/>
    public virtual string txtPlatform { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProduct.html#Alvao_API_Common_Model_Database_tblProduct_txtVersion"/>
    public virtual string txtVersion { get; set; }
}
