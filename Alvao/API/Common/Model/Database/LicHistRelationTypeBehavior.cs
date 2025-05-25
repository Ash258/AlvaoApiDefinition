using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between licenses in the AM from the viewpoint of system/custom links.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationTypeBehavior.html"/>
[Table("dbo.LicHistRelationTypeBehavior")]
public class LicHistRelationTypeBehavior {
    /// <summary>Name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationTypeBehavior.html#Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicHistRelationTypeBehavior.html#Alvao_API_Common_Model_Database_LicHistRelationTypeBehavior_id"/>
    [Key]
    public virtual int id { get; set; }
}
