using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions individuals and groups have in services (Main solver, Solver, ...).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdSectionRights.htm"/>
[TableAttribute("dbo.tHdSectionRights")]
public class tHdSectionRights {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_bHdSectionRightsManager.htm"/>
    public virtual bool? bHdSectionRightsManager { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_bHdSectionRightsOperator.htm"/>
    public virtual bool? bHdSectionRightsOperator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_bHdSectionRightsSolver.htm"/>
    public virtual bool? bHdSectionRightsSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_ExceptionalSolver.htm"/>
    public virtual bool? ExceptionalSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_iHdSectionRightsId.htm"/>
    [KeyAttribute]
    public virtual int iHdSectionRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_IrregularOperator.htm"/>
    public virtual bool? IrregularOperator { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsHdSectionId.htm"/>
    public virtual int liHdSectionRightsHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsPersonId.htm"/>
    public virtual int? liHdSectionRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsRoleId.htm"/>
    public virtual int? liHdSectionRightsRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_Reader.htm"/>
    public virtual bool? Reader { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_RequesterRoleId.htm"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tHdSectionRights_SolverGroup.htm"/>
    public virtual bool? SolverGroup { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tHdSectionRights__ctor.htm"/>
    public tHdSectionRights() { }
}
