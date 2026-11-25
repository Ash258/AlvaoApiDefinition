using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Code list of organizations (software product library).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html"/>
[Table("dbo.tblCompany")]
public class tblCompany {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_CpeMatchScore"/>
    /// <remarks>Column <c>CpeMatchScore</c>: float, not null.</remarks>
    public virtual double CpeMatchScore { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_IsVendorCpeManual"/>
    /// <remarks>Column <c>IsVendorCpeManual</c>: bit, not null.</remarks>
    public virtual bool IsVendorCpeManual { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_VendorCpe"/>
    /// <remarks>Column <c>VendorCpe</c>: nvarchar(max), null.</remarks>
    public virtual string VendorCpe { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolPrint"/>
    /// <remarks>Column <c>bolPrint</c>: bit, not null.</remarks>
    public virtual bool bolPrint { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolProducer"/>
    /// <remarks>Column <c>bolProducer</c>: bit, not null.</remarks>
    public virtual bool bolProducer { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolReseller"/>
    /// <remarks>Column <c>bolReseller</c>: bit, not null.</remarks>
    public virtual bool bolReseller { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_bolValid"/>
    /// <remarks>Column <c>bolValid</c>: bit, not null.</remarks>
    public virtual bool bolValid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_dteTimeStamp"/>
    /// <remarks>Column <c>dteTimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime dteTimeStamp { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intCompanyId"/>
    /// <remarks>Column <c>intCompanyId</c>: int, not null.</remarks>
    [Key]
    public virtual int intCompanyId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intCompanyUID"/>
    /// <remarks>Column <c>intCompanyUID</c>: int, null.</remarks>
    public virtual int? intCompanyUID { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_intFlags"/>
    /// <remarks>Column <c>intFlags</c>: int, null.</remarks>
    public virtual int? intFlags { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtAddress1"/>
    /// <remarks>Column <c>txtAddress1</c>: nvarchar(255), null.</remarks>
    public virtual string txtAddress1 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtAddress2"/>
    /// <remarks>Column <c>txtAddress2</c>: nvarchar(255), null.</remarks>
    public virtual string txtAddress2 { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtCertifiedBy"/>
    /// <remarks>Column <c>txtCertifiedBy</c>: nvarchar(255), null.</remarks>
    public virtual string txtCertifiedBy { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtCity"/>
    /// <remarks>Column <c>txtCity</c>: nvarchar(255), null.</remarks>
    public virtual string txtCity { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtDescription"/>
    /// <remarks>Column <c>txtDescription</c>: nvarchar(255), null.</remarks>
    public virtual string txtDescription { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtName"/>
    /// <remarks>Column <c>txtName</c>: nvarchar(255), not null.</remarks>
    public virtual string txtName { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtPhone"/>
    /// <remarks>Column <c>txtPhone</c>: nvarchar(255), null.</remarks>
    public virtual string txtPhone { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtState"/>
    /// <remarks>Column <c>txtState</c>: nvarchar(255), null.</remarks>
    public virtual string txtState { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtWeb"/>
    /// <remarks>Column <c>txtWeb</c>: nvarchar(255), null.</remarks>
    public virtual string txtWeb { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblCompany.html#Alvao_API_Common_Model_Database_tblCompany_txtZIP"/>
    /// <remarks>Column <c>txtZIP</c>: nvarchar(255), null.</remarks>
    public virtual string txtZIP { get; set; }
}
