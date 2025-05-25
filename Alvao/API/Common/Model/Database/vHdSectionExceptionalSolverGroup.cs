using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective exceptional solvers from exceptional solver groups of services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolverGroup.html"/>
[Table("dbo.vHdSectionExceptionalSolverGroup")]
public class vHdSectionExceptionalSolverGroup {
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolverGroup_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolverGroup_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <summary>ID of the service where the user is an exceptional solver group member.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolverGroup_SectionId"/>
    public virtual int SectionId { get; set; }
}
