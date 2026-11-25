using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective solvers from solver groups of services.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolverGroup.html"/>
[Table("dbo.HdSectionSolverGroup")]
public class HdSectionSolverGroup {
    /// <summary>ID of the service where the user is a solver group member.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolverGroup.html#Alvao_API_Common_Model_Database_HdSectionSolverGroup_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolverGroup.html#Alvao_API_Common_Model_Database_HdSectionSolverGroup_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>
    /// ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolverGroup.html#Alvao_API_Common_Model_Database_HdSectionSolverGroup_RequesterRoleId"/>
    /// <remarks>Column <c>RequesterRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int RequesterRoleId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionSolverGroup.html#Alvao_API_Common_Model_Database_HdSectionSolverGroup_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
