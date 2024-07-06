using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Installed software, detected version and activation code.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vInstDetect.htm"/>
[TableAttribute("dbo.vInstDetect")]
public class vInstDetect
{
    public virtual int? intDetectId { get; set; }
    public virtual int lintComputerNodeId { get; set; }
    public virtual int? lintProductId { get; set; }
    public virtual string txtDetCDKey { get; set; }
    public virtual string txtProductVersion { get; set; }

    public vInstDetect() { }
}
