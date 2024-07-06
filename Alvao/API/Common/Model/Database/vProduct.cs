using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Products (software).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vProduct.htm"/>
[TableAttribute("dbo.vProduct")]
public class vProduct
{
    public virtual string AlternateApprovedProduct { get; set; }
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    public virtual int intProductId { get; set; }
    public virtual int? intProductUID { get; set; }
    public virtual int? lintLangId { get; set; }
    public virtual int? lintProducerCompanyId { get; set; }
    public virtual int? lintProductCategoryId { get; set; }
    public virtual int lintProductTypeId { get; set; }
    public virtual double? nPrice { get; set; }
    public virtual DateTime? ProductRejectedFrom { get; set; }
    public virtual int ProductStateId { get; set; }
    public virtual DateTime? ProductStateModifiedDate { get; set; }
    public virtual int? ProductStateModifiedPersonId { get; set; }
    public virtual int SamTypeId { get; set; }
    public virtual string SupportedVersion { get; set; }
    public virtual string txtCertifiedBy { get; set; }
    public virtual string txtDescription { get; set; }
    public virtual string txtProductName { get; set; }

    public vProduct() { }
}
