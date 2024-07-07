using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective solvers from solver groups of services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vHdSectionSolverGroup.htm"/>
[TableAttribute("dbo.vHdSectionSolverGroup")]
public class vHdSectionSolverGroup
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionSolverGroup_HdSectionId.htm"/>
    public virtual int HdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionSolverGroup_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vHdSectionSolverGroup_RequesterRoleId.htm"/>
    public virtual int RequesterRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vHdSectionSolverGroup__ctor.htm"/>
    public vHdSectionSolverGroup() { }
}
