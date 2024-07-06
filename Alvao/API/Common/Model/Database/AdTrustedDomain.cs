using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of trustworthy domains.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AdTrustedDomain.htm"/>
[TableAttribute("dbo.AdTrustedDomain")]
public class AdTrustedDomain
{
    /// <summary>Domain name in a "dot" notation.</summary>
    public virtual string DomainName { get; set; }
    /// <summary>Network name of server where the domain controller is running.</summary>
    public virtual string Hostname { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Order in which ImportAD will try the servers of the replicated controller of the same domain.</summary>
    public virtual int Order { get; set; }
    /// <summary>1=skip elements from this domain during import.</summary>
    public virtual bool Skip { get; set; }

    public AdTrustedDomain() { }
}
