using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last detection of the computers.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputerDetectLast.htm"/>
[TableAttribute("dbo.vComputerDetectLast")]
public class vComputerDetectLast
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerDetectLast_lintComputerNodeId.htm"/>
    public virtual int lintComputerNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerDetectLast_lintDetectId.htm"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vComputerDetectLast_lintDetectKindId.htm"/>
    public virtual int lintDetectKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vComputerDetectLast__ctor.htm"/>
    public vComputerDetectLast() { }
}
