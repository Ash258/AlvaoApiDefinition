using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>&quot;Objects&quot; in AM.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Node.html"/>
[Table("dbo.Node")]
public class Node {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Node.html#Alvao_API_Common_Model_Database_Node_Node_Id"/>
    public virtual int Node_Id { get; set; }
}
