using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Permissions individuals and groups have in services (Main solver, Solver, ...).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html"/>
[Table("dbo.tHdSectionRights")]
public class tHdSectionRights {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_ExceptionalSolver"/>
    public virtual bool ExceptionalSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_MainSolver"/>
    public virtual bool MainSolver { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Manager"/>
    public virtual bool Manager { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Reader"/>
    public virtual bool Reader { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_RequesterRoleId"/>
    public virtual int RequesterRoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_Solver"/>
    public virtual bool Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_SolverGroup"/>
    public virtual bool SolverGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_TicketReporter"/>
    public virtual bool TicketReporter { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_iHdSectionRightsId"/>
    [Key]
    public virtual int iHdSectionRightsId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsHdSectionId"/>
    public virtual int liHdSectionRightsHdSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsPersonId"/>
    public virtual int? liHdSectionRightsPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdSectionRights.html#Alvao_API_Common_Model_Database_tHdSectionRights_liHdSectionRightsRoleId"/>
    public virtual int? liHdSectionRightsRoleId { get; set; }
}
