using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Software installed on the computers.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_ProductComputer.htm"/>
[TableAttribute("dbo.vSwInst_ProductComputer")]
public class vSwInst_ProductComputer
{
    public virtual int intInstHistId { get; set; }
    public virtual int lintComputerNodeId { get; set; }
    public virtual int lintProductId { get; set; }
    public virtual int ProductStateId { get; set; }
    public virtual string txtDetCDKey { get; set; }
    public virtual string txtDetProductVersion { get; set; }

    public vSwInst_ProductComputer() { }
}
