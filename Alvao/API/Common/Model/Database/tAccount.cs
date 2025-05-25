using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Organization (in accordance with CRM, i.e. the company).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html"/>
[Table("dbo.tAccount")]
public class tAccount {
    /// <summary>Address 2</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Address2Id"/>
    public virtual int? Address2Id { get; set; }
    /// <summary>Address 1</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_AddressId"/>
    public virtual int? AddressId { get; set; }
    /// <summary>Email</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Email"/>
    public virtual string Email { get; set; }
    /// <summary>Email 2</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Email2"/>
    public virtual string Email2 { get; set; }
    /// <summary>Fax</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Fax"/>
    public virtual string Fax { get; set; }
    /// <summary>Company ID - company identification number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_IdentificationNumber"/>
    public virtual string IdentificationNumber { get; set; }
    /// <summary>Phone</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Phone"/>
    public virtual string Phone { get; set; }
    /// <summary>Phone 2</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Phone2"/>
    public virtual string Phone2 { get; set; }
    /// <summary>VAT ID - value added tax identification number</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_TaxIdentificationNumber"/>
    public virtual string TaxIdentificationNumber { get; set; }
    /// <summary>Company web</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_Web"/>
    public virtual string Web { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dCreated"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dModified"/>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_dRemoved"/>
    public virtual DateTime? dRemoved { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_iAccountId"/>
    [Key]
    public virtual int iAccountId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liCreatedPersonId"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liModifiedPersonId"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_liRemovedPersonId"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sAccount"/>
    public virtual string sAccount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sImportRecordId"/>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tAccount.html#Alvao_API_Common_Model_Database_tAccount_sImportSystem"/>
    public virtual string sImportSystem { get; set; }
}
