using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeParentJoin.html"/>
[Table("dbo.vNodeParentJoin")]
public class vNodeParentJoin {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeParentJoin.html#Alvao_API_Common_Model_Database_vNodeParentJoin_lintNodeId"/>
    public virtual int lintNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeParentJoin.html#Alvao_API_Common_Model_Database_vNodeParentJoin_lintParentNodeId"/>
    public virtual int lintParentNodeId { get; set; }
}
