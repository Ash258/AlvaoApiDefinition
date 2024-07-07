using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Products (software).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vProduct.htm"/>
[TableAttribute("dbo.vProduct")]
public class vProduct
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_AlternateApprovedProduct.htm"/>
    public virtual string AlternateApprovedProduct { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_bolValid.htm"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_dteTimeStamp.htm"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_intProductId.htm"/>
    public virtual int intProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_intProductUID.htm"/>
    public virtual int? intProductUID { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_lintLangId.htm"/>
    public virtual int? lintLangId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_lintProducerCompanyId.htm"/>
    public virtual int? lintProducerCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_lintProductCategoryId.htm"/>
    public virtual int? lintProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_lintProductTypeId.htm"/>
    public virtual int lintProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_nPrice.htm"/>
    public virtual double? nPrice { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_ProductRejectedFrom.htm"/>
    public virtual DateTime? ProductRejectedFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_ProductStateId.htm"/>
    public virtual int ProductStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_ProductStateModifiedDate.htm"/>
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_ProductStateModifiedPersonId.htm"/>
    public virtual int? ProductStateModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_SamTypeId.htm"/>
    public virtual int SamTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_SupportedVersion.htm"/>
    public virtual string SupportedVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_txtCertifiedBy.htm"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_txtDescription.htm"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProduct_txtProductName.htm"/>
    public virtual string txtProductName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vProduct__ctor.htm"/>
    public vProduct() { }
}
