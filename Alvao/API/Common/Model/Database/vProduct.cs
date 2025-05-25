using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products (software).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html"/>
[Table("dbo.vProduct")]
public class vProduct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_AlternateApprovedProduct"/>
    public virtual string AlternateApprovedProduct { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_ProductRejectedFrom"/>
    public virtual DateTime? ProductRejectedFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_ProductStateId"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_ProductStateModifiedDate"/>
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_ProductStateModifiedPersonId"/>
    public virtual int? ProductStateModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_SamTypeId"/>
    public virtual int SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_SupportedVersion"/>
    public virtual string SupportedVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_intProductId"/>
    public virtual int intProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_intProductUID"/>
    public virtual int? intProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_lintLangId"/>
    public virtual int? lintLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_lintProducerCompanyId"/>
    public virtual int? lintProducerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_lintProductCategoryId"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_lintProductTypeId"/>
    public virtual int lintProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_nPrice"/>
    public virtual double? nPrice { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_txtDescription"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProduct.html#Alvao_API_Common_Model_Database_vProduct_txtProductName"/>
    public virtual string txtProductName { get; set; }
}
