using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of trustworthy domains.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AdTrustedDomain.htm"/>
[TableAttribute("dbo.AdTrustedDomain")]
public class AdTrustedDomain {
    /// <summary>Domain name in a "dot" notation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AdTrustedDomain_DomainName.htm"/>
    public virtual string DomainName { get; set; }
    /// <summary>Network name of server where the domain controller is running.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AdTrustedDomain_Hostname.htm"/>
    public virtual string Hostname { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AdTrustedDomain_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Order in which ImportAD will try the servers of the replicated controller of the same domain.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AdTrustedDomain_Order.htm"/>
    public virtual int Order { get; set; }
    /// <summary>1=skip elements from this domain during import.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AdTrustedDomain_Skip.htm"/>
    public virtual bool Skip { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_AdTrustedDomain__ctor.htm"/>
    public AdTrustedDomain() { }
}
