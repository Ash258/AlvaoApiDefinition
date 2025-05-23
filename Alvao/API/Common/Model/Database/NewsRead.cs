using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Records of reading the news. In multi-tenant operation, records of reading news displayed to other tenants are saved in the provider's database.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewsRead.htm"/>
[TableAttribute("dbo.NewsRead")]
public class NewsRead {
    /// <summary>Date and time user first viewed the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_FirstDisplayed.htm"/>
    public virtual DateTime FirstDisplayed { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>News post ID (News.id).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_NewsId.htm"/>
    public virtual int NewsId { get; set; }
    /// <summary>Organization name in the tenant database. NULL if this is local news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_Organization.htm"/>
    public virtual string Organization { get; set; }
    /// <summary>Person ID (tPerson.iPersonId). Person ID in the tenant's database in a multi-tenant operation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Person’s username</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_PersonLogin.htm"/>
    public virtual string PersonLogin { get; set; }
    /// <summary>Name of the person</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_PersonName.htm"/>
    public virtual string PersonName { get; set; }
    /// <summary>Tenant ID in the tenant database. ZERO, if this is a local news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewsRead_TenantId.htm"/>
    public virtual int? TenantId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NewsRead__ctor.htm"/>
    public NewsRead() { }
}
