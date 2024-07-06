using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installations covered by "special installation", including the coverage for package components.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vInstTrial.htm"/>
[TableAttribute("dbo.vInstTrial")]
public class vInstTrial
{
    public virtual int lintComputerNodeId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual string txtDesc { get; set; }

    public vInstTrial() { }
}
