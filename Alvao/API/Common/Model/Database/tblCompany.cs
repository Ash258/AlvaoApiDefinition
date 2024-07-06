using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Code list of organizations (software products library).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblCompany.htm"/>
[TableAttribute("dbo.tblCompany")]
public class tblCompany
{
    public virtual bool bolPrint { get; set; }
    public virtual bool bolProducer { get; set; }
    public virtual bool bolReseller { get; set; }
    public virtual bool bolValid { get; set; }
    public virtual DateTime dteTimeStamp { get; set; }
    [KeyAttribute]
    public virtual int intCompanyId { get; set; }
    public virtual int? intCompanyUID { get; set; }
    public virtual int? intFlags { get; set; }
    public virtual string txtAddress1 { get; set; }
    public virtual string txtAddress2 { get; set; }
    public virtual string txtCertifiedBy { get; set; }
    public virtual string txtCity { get; set; }
    public virtual string txtDescription { get; set; }
    public virtual string txtName { get; set; }
    public virtual string txtPhone { get; set; }
    public virtual string txtState { get; set; }
    public virtual string txtWeb { get; set; }
    public virtual string txtZIP { get; set; }

    public tblCompany() { }
}
