using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between objects in the AM from the viewpoint of system/custom links.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeBehavior.html"/>
[Table("dbo.NodeRelationTypeBehavior")]
public class NodeRelationTypeBehavior {
    /// <summary>Enumeration representing behavior of node relation types.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeBehavior.Behavior.html#fields"/>
    public enum Behavior {
        Custom = 1,
        Relates_to = 2,
        Is_used_by_Uses = 3,
        Is_parent_of_Is_child_of = 4,
        Targets_Is_targeted_by = 5,
        Exposes_Is_exposed_by = 6,
        Threatens_Is_Threatened_by = 7,
    }

    /// <summary>Name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeBehavior.html#Alvao_API_Common_Model_Database_NodeRelationTypeBehavior_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NodeRelationTypeBehavior.html#Alvao_API_Common_Model_Database_NodeRelationTypeBehavior_id"/>
    [Key]
    public virtual int id { get; set; }
}
