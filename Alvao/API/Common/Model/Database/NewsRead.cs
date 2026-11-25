using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Records of reading the news. In multi-tenant operation, records of reading news displayed to other tenants are saved
/// in the provider's database.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html"/>
[Table("dbo.NewsRead")]
public class NewsRead {
    /// <summary>Date and time user first viewed the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_FirstDisplayed"/>
    /// <remarks>Column <c>FirstDisplayed</c>: datetime, not null.</remarks>
    public virtual DateTime FirstDisplayed { get; set; }
    /// <summary>News post ID (News.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_NewsId"/>
    /// <remarks>Column <c>NewsId</c>: int, not null. References <see cref="News"/>.</remarks>
    public virtual int NewsId { get; set; }
    /// <summary>Organization name in the tenant database. NULL if this is local news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_Organization"/>
    /// <remarks>Column <c>Organization</c>: nvarchar(255), null.</remarks>
    public virtual string Organization { get; set; }
    /// <summary>
    /// Person ID (tPerson.iPersonId). Person ID in the tenant's database in a multi-tenant operation.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Personâs username</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_PersonLogin"/>
    /// <remarks>Column <c>PersonLogin</c>: nvarchar(255), null.</remarks>
    public virtual string PersonLogin { get; set; }
    /// <summary>Name of the person</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_PersonName"/>
    /// <remarks>Column <c>PersonName</c>: nvarchar(255), null.</remarks>
    public virtual string PersonName { get; set; }
    /// <summary>Tenant ID in the tenant database. ZERO, if this is a local news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_TenantId"/>
    /// <remarks>Column <c>TenantId</c>: int, null.</remarks>
    public virtual int? TenantId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsRead.html#Alvao_API_Common_Model_Database_NewsRead_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
