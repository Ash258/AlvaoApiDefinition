using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects in the tree - tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeParentJoin.htm"/>
[TableAttribute("dbo.vNodeParentJoin")]
public class vNodeParentJoin
{
    public virtual int lintNodeId { get; set; }
    public virtual int lintParentNodeId { get; set; }

    public vNodeParentJoin() { }
}
