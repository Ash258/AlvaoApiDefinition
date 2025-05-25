using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Code list of organizations (software products library).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html"/>
[Table("dbo.tblCompany")]
public class tblCompany {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolPrint"/>
    public virtual bool bolPrint { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolProducer"/>
    public virtual bool bolProducer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolReseller"/>
    public virtual bool bolReseller { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolValid"/>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_dteTimeStamp"/>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intCompanyId"/>
    [Key]
    public virtual int intCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intCompanyUID"/>
    public virtual int? intCompanyUID { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intFlags"/>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtAddress1"/>
    public virtual string txtAddress1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtAddress2"/>
    public virtual string txtAddress2 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtCertifiedBy"/>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtCity"/>
    public virtual string txtCity { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtDescription"/>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtName"/>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtPhone"/>
    public virtual string txtPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtState"/>
    public virtual string txtState { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtWeb"/>
    public virtual string txtWeb { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtZIP"/>
    public virtual string txtZIP { get; set; }
}
