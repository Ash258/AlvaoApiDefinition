using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Objects in the tree - tree.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNodeParent.htm"/>
[TableAttribute("dbo.tblNodeParent")]
public class tblNodeParent
{
    /// <summary>object - tblNode</summary>
    [ExplicitKeyAttribute]
    public virtual int lintNodeId { get; set; }
    /// <summary>object on path to tree root - tblNode</summary>
    public virtual int lintParentNodeId { get; set; }

    public tblNodeParent() { }
}
