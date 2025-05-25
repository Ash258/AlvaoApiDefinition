using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Effective solvers from solver groups of services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionSolverGroup.html"/>
[Table("dbo.vHdSectionSolverGroup")]
public class vHdSectionSolverGroup {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionSolverGroup_HdSectionId"/>
    public virtual int HdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionSolverGroup_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Link to the group of requesters for which the permission for the given person is valid.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vHdSectionSolverGroup.html#Alvao_API_Common_Model_Database_vHdSectionSolverGroup_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
}
