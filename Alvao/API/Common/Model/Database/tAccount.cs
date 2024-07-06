using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Organization (in accordance with CRM, i.e. the company).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAccount.htm"/>
[TableAttribute("dbo.tAccount")]
public class tAccount
{
    /// <summary>Address 2</summary>
    public virtual int? Address2Id { get; set; }
    /// <summary>Address 1</summary>
    public virtual int? AddressId { get; set; }
    public virtual DateTime dCreated { get; set; }
    public virtual DateTime dModified { get; set; }
    public virtual DateTime? dRemoved { get; set; }
    /// <summary>Email</summary>
    public virtual string Email { get; set; }
    /// <summary>Email 2</summary>
    public virtual string Email2 { get; set; }
    /// <summary>Fax</summary>
    public virtual string Fax { get; set; }
    [KeyAttribute]
    public virtual int iAccountId { get; set; }
    /// <summary>Company ID - company identification number</summary>
    public virtual string IdentificationNumber { get; set; }
    public virtual int? liCreatedPersonId { get; set; }
    public virtual int? liModifiedPersonId { get; set; }
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Phone</summary>
    public virtual string Phone { get; set; }
    /// <summary>Phone 2</summary>
    public virtual string Phone2 { get; set; }
    public virtual string sAccount { get; set; }
    public virtual string sImportRecordId { get; set; }
    public virtual string sImportSystem { get; set; }
    /// <summary>VAT ID - value added tax identification number</summary>
    public virtual string TaxIdentificationNumber { get; set; }
    /// <summary>Company web</summary>
    public virtual string Web { get; set; }

    public tAccount() { }
}
