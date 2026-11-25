using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective service solvers.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolver.html"/>
[Table("dbo.HdSectionSolver")]
public class HdSectionSolver {
    /// <summary>ID of the service where the user is a solver.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolver.html#Alvao_API_Common_Model_Database_HdSectionSolver_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolver.html#Alvao_API_Common_Model_Database_HdSectionSolver_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>
    /// ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolver.html#Alvao_API_Common_Model_Database_HdSectionSolver_RequesterRoleId"/>
    /// <remarks>Column <c>RequesterRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int RequesterRoleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolver.html#Alvao_API_Common_Model_Database_HdSectionSolver_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
