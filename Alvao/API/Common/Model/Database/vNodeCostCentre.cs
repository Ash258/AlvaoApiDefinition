using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cost center of the objects in the tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeCostCentre.htm"/>
[TableAttribute("dbo.vNodeCostCentre")]
public class vNodeCostCentre
{
    public virtual string Centre { get; set; }
    public virtual int? ClassId { get; set; }
    public virtual int NodeId { get; set; }

    public vNodeCostCentre() { }
}
