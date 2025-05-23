using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Organization (in accordance with CRM, i.e. the company).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tAccount.htm"/>
[TableAttribute("dbo.tAccount")]
public class tAccount
{
    /// <summary>Address 2</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Address2Id.htm"/>
    public virtual int? Address2Id { get; set; }
    /// <summary>Address 1</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_AddressId.htm"/>
    public virtual int? AddressId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_dCreated.htm"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_dModified.htm"/>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_dRemoved.htm"/>
    public virtual DateTime? dRemoved { get; set; }
    /// <summary>Email</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Email.htm"/>
    public virtual string Email { get; set; }
    /// <summary>Email 2</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Email2.htm"/>
    public virtual string Email2 { get; set; }
    /// <summary>Fax</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Fax.htm"/>
    public virtual string Fax { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_iAccountId.htm"/>
    [KeyAttribute]
    public virtual int iAccountId { get; set; }
    /// <summary>Company ID - company identification number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_IdentificationNumber.htm"/>
    public virtual string IdentificationNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_liCreatedPersonId.htm"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_liModifiedPersonId.htm"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_liRemovedPersonId.htm"/>
    public virtual int? liRemovedPersonId { get; set; }
    /// <summary>Phone</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Phone.htm"/>
    public virtual string Phone { get; set; }
    /// <summary>Phone 2</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Phone2.htm"/>
    public virtual string Phone2 { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_sAccount.htm"/>
    public virtual string sAccount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_sImportRecordId.htm"/>
    public virtual string sImportRecordId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_sImportSystem.htm"/>
    public virtual string sImportSystem { get; set; }
    /// <summary>VAT ID - value added tax identification number</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_TaxIdentificationNumber.htm"/>
    public virtual string TaxIdentificationNumber { get; set; }
    /// <summary>Company web</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tAccount_Web.htm"/>
    public virtual string Web { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tAccount__ctor.htm"/>
    public tAccount() { }
}
