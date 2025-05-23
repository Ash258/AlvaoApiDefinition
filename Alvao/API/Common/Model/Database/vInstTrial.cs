using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Installations covered by "special installation", including the coverage for package components.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vInstTrial.htm"/>
[TableAttribute("dbo.vInstTrial")]
public class vInstTrial
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstTrial_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstTrial_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vInstTrial_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vInstTrial__ctor.htm"/>
    public vInstTrial() { }
}
