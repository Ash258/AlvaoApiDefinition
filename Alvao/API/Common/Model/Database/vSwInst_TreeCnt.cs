using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Number of product installations in the subtree.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSwInst_TreeCnt.htm"/>
[TableAttribute("dbo.vSwInst_TreeCnt")]
public class vSwInst_TreeCnt {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_TreeCnt_intCount.htm"/>
    public virtual int? intCount { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_TreeCnt_lintParentNodeId.htm"/>
    public virtual int lintParentNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSwInst_TreeCnt_lintProductId.htm"/>
    public virtual int lintProductId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSwInst_TreeCnt__ctor.htm"/>
    public vSwInst_TreeCnt() { }
}
