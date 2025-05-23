using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>IP address range for Integrated Windows Authentication.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_IntegratedAuthIpRange.htm"/>
[TableAttribute("dbo.IntegratedAuthIpRange")]
public class IntegratedAuthIpRange {
    /// <summary>Beginning of the range of IP addresses, including.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_IntegratedAuthIpRange_FromIP.htm"/>
    public virtual long? FromIP { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_IntegratedAuthIpRange_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>End of the range of IP addresses, including endpoint.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_IntegratedAuthIpRange_ToIP.htm"/>
    public virtual long? ToIP { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_IntegratedAuthIpRange__ctor.htm"/>
    public IntegratedAuthIpRange() { }
}
