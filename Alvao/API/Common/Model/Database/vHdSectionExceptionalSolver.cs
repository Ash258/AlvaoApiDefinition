using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective exceptional solvers in services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolver.html"/>
[Table("dbo.vHdSectionExceptionalSolver")]
public class vHdSectionExceptionalSolver {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolver.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolver.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionExceptionalSolver.html#Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_SectionId"/>
    public virtual int SectionId { get; set; }
}
