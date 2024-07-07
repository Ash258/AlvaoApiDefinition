using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - product statuses.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSwPresence.htm"/>
[TableAttribute("dbo.tSwPresence")]
public class tSwPresence
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwPresence_iSwPresenceId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSwPresence_sSwPresence.htm"/>
    public virtual string sSwPresence { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSwPresence__ctor.htm"/>
    public tSwPresence() { }
}
