using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Number of product installations in the subtree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_TreeCnt.html"/>
[Table("dbo.vSwInst_TreeCnt")]
public class vSwInst_TreeCnt {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_TreeCnt.html#Alvao_API_Common_Model_Database_vSwInst_TreeCnt_intCount"/>
    public virtual int? intCount { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_TreeCnt.html#Alvao_API_Common_Model_Database_vSwInst_TreeCnt_lintParentNodeId"/>
    public virtual int lintParentNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSwInst_TreeCnt.html#Alvao_API_Common_Model_Database_vSwInst_TreeCnt_lintProductId"/>
    public virtual int lintProductId { get; set; }
}
