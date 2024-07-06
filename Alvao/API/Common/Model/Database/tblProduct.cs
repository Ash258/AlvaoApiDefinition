using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Products / software (software products library).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProduct.htm"/>
[TableAttribute("dbo.tblProduct")]
public class tblProduct
{
    public enum ProductCategory
    {
        OS = 1,
    }

    public enum ProductState
    {
        Unclassified = 1,
        Approving = 2,
        Approved = 3,
        ApprovedRetirementPlanned = 4,
        Excluded = 5,
        Rejected = 6,
    }

    public enum ProductType
    {
        Commercial = 1,
        Freeware = 2,
        Shareware = 3,
        Unspecified = 4,
    }

    public enum SamType
    {
        Yes = 1,
        No = 2,
        Notify = 3,
    }


    public bool AddToSoftwareLibrary { get; }
    public virtual string AlternateApprovedProduct { get; set; }
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    public virtual string FullName { get; set; }
    public virtual int? intFlags { get; set; }
    [KeyAttribute]
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
    public virtual string txtEdition { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPlatform { get; set; }
    public virtual string txtVersion { get; set; }
    public bool WaitingForValidation { get; set; }

    public tblProduct() { }
}
