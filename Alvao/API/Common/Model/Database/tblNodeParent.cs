using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Objects in the tree - tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNodeParent.html"/>
[Table("dbo.tblNodeParent")]
public class tblNodeParent {
    /// <summary>object - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNodeParent.html#Alvao_API_Common_Model_Database_tblNodeParent_lintNodeId"/>
    [ExplicitKey]
    public virtual int lintNodeId { get; set; }
    /// <summary>object on path to tree root - tblNode</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNodeParent.html#Alvao_API_Common_Model_Database_tblNodeParent_lintParentNodeId"/>
    public virtual int lintParentNodeId { get; set; }
}
