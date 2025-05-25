using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of trustworthy domains.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html"/>
[Table("dbo.AdTrustedDomain")]
public class AdTrustedDomain {
    /// <summary>Domain name in a &quot;dot&quot; notation.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_DomainName"/>
    public virtual string DomainName { get; set; }
    /// <summary>Network name of server where the domain controller is running.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Hostname"/>
    public virtual string Hostname { get; set; }
    /// <summary>Order in which ImportAD will try the servers of the replicated controller of the same domain.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Order"/>
    public virtual int Order { get; set; }
    /// <summary>1=skip elements from this domain during import.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_Skip"/>
    public virtual bool Skip { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.AdTrustedDomain.html#Alvao_API_Common_Model_Database_AdTrustedDomain_id"/>
    [Key]
    public virtual int id { get; set; }
}
