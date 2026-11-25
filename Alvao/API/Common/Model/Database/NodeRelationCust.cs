using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Object relation custom fields values.<br/><br/>!!!CAUTION: This class is not part of the API documentation. It was
/// generated from the database documentation
/// </summary>
/// <see href="https://doc.alvao.com/en/26/admin-guide/customization/alvao-database/tables/#U_dbo.NodeRelationCust"/>
[Table("dbo.NodeRelationCust")]
public class NodeRelationCust {
    /// <summary>Link to object relation to which the values belong (NodeRelation.id)</summary>
    /// <remarks>Column <c>NodeRelationId</c>: int, not null. References <see cref="NodeRelation"/>.</remarks>
    public virtual int NodeRelationId { get; set; }
    /// <remarks>Column <c>Weight</c>: int, null.</remarks>
    public virtual int? Weight { get; set; }
    /// <remarks>Column <c>ThreatOccurrenceLikelihood</c>: int, null.</remarks>
    public virtual int? ThreatOccurrenceLikelihood { get; set; }
    /// <remarks>Column <c>ProbabilityOfVulnerabilityBeingExploited</c>: int, null.</remarks>
    public virtual int? ProbabilityOfVulnerabilityBeingExploited { get; set; }
    /// <remarks>Column <c>RiskLevel</c>: int, null.</remarks>
    public virtual int? RiskLevel { get; set; }
}
