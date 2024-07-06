using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Last detection of the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vComputerDetectLast.htm"/>
[TableAttribute("dbo.vComputerDetectLast")]
public class vComputerDetectLast
{
    public virtual int lintComputerNodeId { get; set; }
    public virtual int? lintDetectId { get; set; }
    public virtual int lintDetectKindId { get; set; }

    public vComputerDetectLast() { }
}
