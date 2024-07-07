using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Effective solvers from solver groups of services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionSolverGroup.htm"/>
[TableAttribute("dbo.HdSectionSolverGroup")]
public class HdSectionSolverGroup
{
    /// <summary>ID of the service where the user is a solver group member.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionSolverGroup_HdSectionId.htm"/>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionSolverGroup_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionSolverGroup_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionSolverGroup_RequesterRoleId.htm"/>
    public virtual int RequesterRoleId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionSolverGroup__ctor.htm"/>
    public HdSectionSolverGroup() { }
}
