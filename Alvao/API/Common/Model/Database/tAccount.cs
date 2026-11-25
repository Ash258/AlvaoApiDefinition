using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Organization (in accordance with CRM, i.e. the company).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html"/>
[Table("dbo.tAccount")]
public class tAccount {
    /// <summary>Address 2</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Address2Id"/>
    /// <remarks>Column <c>Address2Id</c>: int, null. References <see cref="tAddress"/>.</remarks>
    public virtual int? Address2Id { get; set; }
    /// <summary>Address 1</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_AddressId"/>
    /// <remarks>Column <c>AddressId</c>: int, null. References <see cref="tAddress"/>.</remarks>
    public virtual int? AddressId { get; set; }
    /// <summary>Email</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Email"/>
    /// <remarks>Column <c>Email</c>: nvarchar(50), null.</remarks>
    public virtual string Email { get; set; }
    /// <summary>Email 2</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Email2"/>
    /// <remarks>Column <c>Email2</c>: nvarchar(50), null.</remarks>
    public virtual string Email2 { get; set; }
    /// <summary>Fax</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Fax"/>
    /// <remarks>Column <c>Fax</c>: nvarchar(30), null.</remarks>
    public virtual string Fax { get; set; }
    /// <summary>Company ID - company identification number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_IdentificationNumber"/>
    /// <remarks>Column <c>IdentificationNumber</c>: nvarchar(20), null.</remarks>
    public virtual string IdentificationNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <summary>Phone</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Phone"/>
    /// <remarks>Column <c>Phone</c>: nvarchar(30), null.</remarks>
    public virtual string Phone { get; set; }
    /// <summary>Phone 2</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Phone2"/>
    /// <remarks>Column <c>Phone2</c>: nvarchar(30), null.</remarks>
    public virtual string Phone2 { get; set; }
    /// <summary>VAT ID - value added tax identification number</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_TaxIdentificationNumber"/>
    /// <remarks>Column <c>TaxIdentificationNumber</c>: nvarchar(20), null.</remarks>
    public virtual string TaxIdentificationNumber { get; set; }
    /// <summary>Company web</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Web"/>
    /// <remarks>Column <c>Web</c>: nvarchar(50), null.</remarks>
    public virtual string Web { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dCreated"/>
    /// <remarks>Column <c>dCreated</c>: datetime, not null.</remarks>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dModified"/>
    /// <remarks>Column <c>dModified</c>: datetime, not null.</remarks>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dRemoved"/>
    /// <remarks>Column <c>dRemoved</c>: datetime, null.</remarks>
    public virtual DateTime? dRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_iAccountId"/>
    /// <remarks>Column <c>iAccountId</c>: int, not null.</remarks>
    [Key]
    public virtual int iAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liCreatedPersonId"/>
    /// <remarks>Column <c>liCreatedPersonId</c>: int, null.</remarks>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liModifiedPersonId"/>
    /// <remarks>Column <c>liModifiedPersonId</c>: int, null.</remarks>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liRemovedPersonId"/>
    /// <remarks>Column <c>liRemovedPersonId</c>: int, null.</remarks>
    public virtual int? liRemovedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sAccount"/>
    /// <remarks>Column <c>sAccount</c>: nvarchar(255), not null.</remarks>
    public virtual string sAccount { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sImportRecordId"/>
    /// <remarks>Column <c>sImportRecordId</c>: nvarchar(255), null.</remarks>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sImportSystem"/>
    /// <remarks>Column <c>sImportSystem</c>: nvarchar(255), null.</remarks>
    public virtual string sImportSystem { get; set; }
}
