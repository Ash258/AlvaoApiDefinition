using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Permissions individuals and groups have in services (Main solver, Solver, ...).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdSectionRights.htm"/>
[TableAttribute("dbo.tHdSectionRights")]
public class tHdSectionRights
{
    public virtual bool? bHdSectionRightsManager { get; set; }
    public virtual bool? bHdSectionRightsOperator { get; set; }
    public virtual bool? bHdSectionRightsSolver { get; set; }
    public virtual bool? ExceptionalSolver { get; set; }
    [KeyAttribute]
    public virtual int iHdSectionRightsId { get; set; }
    public virtual bool? IrregularOperator { get; set; }
    public virtual int liHdSectionRightsHdSectionId { get; set; }
    public virtual int? liHdSectionRightsPersonId { get; set; }
    public virtual int? liHdSectionRightsRoleId { get; set; }
    public virtual bool? Reader { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual int RequesterRoleId { get; set; }
    public virtual bool? SolverGroup { get; set; }

    public tHdSectionRights() { }
}
