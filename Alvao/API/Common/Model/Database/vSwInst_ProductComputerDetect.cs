using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SW detected in the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_ProductComputerDetect.htm"/>
[TableAttribute("dbo.vSwInst_ProductComputerDetect")]
public class vSwInst_ProductComputerDetect
{
    public virtual int intDetectId { get; set; }
    public virtual int intInstHistId { get; set; }
    public virtual int lintComputerNodeId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual string txtDetCDKey { get; set; }
    public virtual string txtDetProductVersion { get; set; }

    public vSwInst_ProductComputerDetect() { }
}
