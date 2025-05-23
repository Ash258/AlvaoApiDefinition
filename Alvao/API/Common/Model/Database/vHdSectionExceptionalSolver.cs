using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective exceptional solvers in services.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver.htm"/>
[TableAttribute("dbo.vHdSectionExceptionalSolver")]
public class vHdSectionExceptionalSolver
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_RequesterRoleId.htm"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionExceptionalSolver__ctor.htm"/>
    public vHdSectionExceptionalSolver() { }
}
