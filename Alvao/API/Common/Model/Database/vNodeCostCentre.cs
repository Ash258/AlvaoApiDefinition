using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cost center of the objects in the tree.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeCostCentre.html"/>
[Table("dbo.vNodeCostCentre")]
public class vNodeCostCentre {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeCostCentre.html#Alvao_API_Common_Model_Database_vNodeCostCentre_Centre"/>
    public virtual string Centre { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeCostCentre.html#Alvao_API_Common_Model_Database_vNodeCostCentre_ClassId"/>
    public virtual int? ClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vNodeCostCentre.html#Alvao_API_Common_Model_Database_vNodeCostCentre_NodeId"/>
    public virtual int NodeId { get; set; }
}
