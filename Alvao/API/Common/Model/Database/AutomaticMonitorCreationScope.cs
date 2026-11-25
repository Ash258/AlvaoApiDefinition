using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Object IDs under which monitors can be created.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationScope.html"/>
[Table("dbo.AutomaticMonitorCreationScope")]
public class AutomaticMonitorCreationScope {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationScope.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreationScope_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Parent object ID (tblNode.intNodeId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.AutomaticMonitorCreationScope.html#Alvao_API_Common_Model_Database_AutomaticMonitorCreationScope_ParentNodeId"/>
    public virtual int ParentNodeId { get; set; }
}
