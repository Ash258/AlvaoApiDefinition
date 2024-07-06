using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Number of product installations in the subtree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_TreeCnt.htm"/>
[TableAttribute("dbo.vSwInst_TreeCnt")]
public class vSwInst_TreeCnt
{
    public virtual int? intCount { get; set; }
    public virtual int lintParentNodeId { get; set; }
    public virtual int lintProductId { get; set; }

    public vSwInst_TreeCnt() { }
}
