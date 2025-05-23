using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective solvers and exceptional solvers from solver groups of services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html"/>
[Table("dbo.vHdSectionAllSolverGroup")]
public class vHdSectionAllSolverGroup {
    /// <summary>1 = is exceptional solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionAllSolverGroup_ExceptionalSolver"/>
    public virtual int ExceptionalSolver { get; set; }

    /// <summary>User ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionAllSolverGroup_PersonId"/>
    public virtual int? PersonId { get; set; }

    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionAllSolverGroup_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }

    /// <summary>ID of the service.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionAllSolverGroup_SectionId"/>
    public virtual int SectionId { get; set; }

    /// <summary>1 = is solver.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionAllSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionAllSolverGroup_Solver"/>
    public virtual int Solver { get; set; }

}
