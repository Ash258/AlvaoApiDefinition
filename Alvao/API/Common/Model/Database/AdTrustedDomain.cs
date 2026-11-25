using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of trustworthy domains.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html"/>
[Table("dbo.AdTrustedDomain")]
public class AdTrustedDomain {
    /// <summary>Domain name in a &quot;dot&quot; notation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_DomainName"/>
    /// <remarks>Column <c>DomainName</c>: nvarchar(128), not null.</remarks>
    public virtual string DomainName { get; set; }
    /// <summary>Network name of server where the domain controller is running.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Hostname"/>
    /// <remarks>Column <c>Hostname</c>: nvarchar(32), not null.</remarks>
    public virtual string Hostname { get; set; }
    /// <summary>Order in which ImportAD will try the servers of the replicated controller of the same domain.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>1=skip elements from this domain during import.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Skip"/>
    /// <remarks>Column <c>Skip</c>: bit, not null.</remarks>
    public virtual bool Skip { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
