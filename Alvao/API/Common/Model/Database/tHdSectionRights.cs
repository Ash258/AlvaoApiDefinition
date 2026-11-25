using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions individuals and groups have in services (Main solver, Solver, ...).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html"/>
[Table("dbo.tHdSectionRights")]
public class tHdSectionRights {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_ExceptionalSolver"/>
    /// <remarks>Column <c>ExceptionalSolver</c>: bit, not null.</remarks>
    public virtual bool ExceptionalSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_MainSolver"/>
    /// <remarks>Column <c>MainSolver</c>: bit, not null.</remarks>
    public virtual bool MainSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Manager"/>
    /// <remarks>Column <c>Manager</c>: bit, not null.</remarks>
    public virtual bool Manager { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Reader"/>
    /// <remarks>Column <c>Reader</c>: bit, not null.</remarks>
    public virtual bool Reader { get; set; }
    /// <summary>
    /// ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_RequesterRoleId"/>
    /// <remarks>Column <c>RequesterRoleId</c>: int, not null. References <see cref="tRole"/>.</remarks>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Solver"/>
    /// <remarks>Column <c>Solver</c>: bit, not null.</remarks>
    public virtual bool Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_SolverGroup"/>
    /// <remarks>Column <c>SolverGroup</c>: bit, not null.</remarks>
    public virtual bool SolverGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_TicketReporter"/>
    /// <remarks>Column <c>TicketReporter</c>: bit, not null.</remarks>
    public virtual bool TicketReporter { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_iHdSectionRightsId"/>
    /// <remarks>Column <c>iHdSectionRightsId</c>: int, not null.</remarks>
    [Key]
    public virtual int iHdSectionRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsHdSectionId"/>
    /// <remarks>
    /// Column <c>liHdSectionRightsHdSectionId</c>: int, not null. References <see cref="tHdSection"/>.
    /// </remarks>
    public virtual int liHdSectionRightsHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsPersonId"/>
    /// <remarks>Column <c>liHdSectionRightsPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liHdSectionRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsRoleId"/>
    /// <remarks>Column <c>liHdSectionRightsRoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? liHdSectionRightsRoleId { get; set; }
}
