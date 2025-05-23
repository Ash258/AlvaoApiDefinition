using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products / software (software products library).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct.htm"/>
[TableAttribute("dbo.tblProduct")]
public class tblProduct {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct_ProductCategory.htm"/>
    public enum ProductCategory {
        OS = 1,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct_ProductState.htm"/>
    public enum ProductState {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedRetirementPlanned = 4,
        Excluded = 5,
        Rejected = 6,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct_ProductType.htm"/>
    public enum ProductType {
        Commercial = 1,
        Freeware = 2,
        Shareware = 3,
        Unspecified = 4,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct_SamType.htm"/>
    public enum SamType {
        Yes = 1,
        No = 2,
        Notify = 3,
    }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_AddToSoftwareLibrary.htm"/>
    public bool AddToSoftwareLibrary { get; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_AlternateApprovedProduct.htm"/>
    public virtual string AlternateApprovedProduct { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_bolValid.htm"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_dteTimeStamp.htm"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_FullName.htm"/>
    public virtual string FullName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_intFlags.htm"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_intProductId.htm"/>
    [KeyAttribute]
    public virtual int intProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_intProductUID.htm"/>
    public virtual int? intProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_lintLangId.htm"/>
    public virtual int? lintLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_lintProducerCompanyId.htm"/>
    public virtual int? lintProducerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_lintProductCategoryId.htm"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_lintProductTypeId.htm"/>
    public virtual int lintProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_nPrice.htm"/>
    public virtual double? nPrice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_ProductRejectedFrom.htm"/>
    public virtual DateTime? ProductRejectedFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_ProductStateId.htm"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedDate.htm"/>
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_ProductStateModifiedPersonId.htm"/>
    public virtual int? ProductStateModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_SamTypeId.htm"/>
    public virtual int SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_SupportedVersion.htm"/>
    public virtual string SupportedVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtCertifiedBy.htm"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtDescription.htm"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtEdition.htm"/>
    public virtual string txtEdition { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtName.htm"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtPlatform.htm"/>
    public virtual string txtPlatform { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_txtVersion.htm"/>
    public virtual string txtVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProduct_WaitingForValidation.htm"/>
    public bool WaitingForValidation { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblProduct__ctor.htm"/>
    public tblProduct() { }
}
