using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - tree.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vNodeParentJoin.htm"/>
[TableAttribute("dbo.vNodeParentJoin")]
public class vNodeParentJoin {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeParentJoin_lintNodeId.htm"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vNodeParentJoin_lintParentNodeId.htm"/>
    public virtual int lintParentNodeId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vNodeParentJoin__ctor.htm"/>
    public vNodeParentJoin() { }
}
