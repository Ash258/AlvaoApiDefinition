using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in user permissions to services. The meaning of values in permission columns: 1=enable 0=not set
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html"/>
[Table("dbo.HdSectionRightsLog")]
public class HdSectionRightsLog {
    /// <summary>Exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolver"/>
    /// <remarks>Column <c>ExceptionalSolver</c>: bit, not null.</remarks>
    public virtual bool ExceptionalSolver { get; set; }
    /// <summary>Original exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolverOld"/>
    /// <remarks>Column <c>ExceptionalSolverOld</c>: bit, not null.</remarks>
    public virtual bool ExceptionalSolverOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSection"/>
    /// <remarks>Column <c>HdSection</c>: nvarchar(1024), null.</remarks>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, null.</remarks>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionIdOld"/>
    /// <remarks>Column <c>HdSectionIdOld</c>: int, null.</remarks>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionOld"/>
    /// <remarks>Column <c>HdSectionOld</c>: nvarchar(1024), null.</remarks>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_MainSolver"/>
    /// <remarks>Column <c>MainSolver</c>: bit, not null.</remarks>
    public virtual bool MainSolver { get; set; }
    /// <summary>Original main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_MainSolverOld"/>
    /// <remarks>Column <c>MainSolverOld</c>: bit, not null.</remarks>
    public virtual bool MainSolverOld { get; set; }
    /// <summary>Manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Manager"/>
    /// <remarks>Column <c>Manager</c>: bit, not null.</remarks>
    public virtual bool Manager { get; set; }
    /// <summary>Original manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ManagerOld"/>
    /// <remarks>Column <c>ManagerOld</c>: bit, not null.</remarks>
    public virtual bool ManagerOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPerson"/>
    /// <remarks>Column <c>ModifiedByPerson</c>: nvarchar(255), not null.</remarks>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPersonId"/>
    /// <remarks>Column <c>ModifiedByPersonId</c>: int, null.</remarks>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Person"/>
    /// <remarks>Column <c>Person</c>: nvarchar(255), null.</remarks>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonIdOld"/>
    /// <remarks>Column <c>PersonIdOld</c>: int, null.</remarks>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonOld"/>
    /// <remarks>Column <c>PersonOld</c>: nvarchar(255), null.</remarks>
    public virtual string PersonOld { get; set; }
    /// <summary>Reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Reader"/>
    /// <remarks>Column <c>Reader</c>: bit, not null.</remarks>
    public virtual bool Reader { get; set; }
    /// <summary>Original reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ReaderOld"/>
    /// <remarks>Column <c>ReaderOld</c>: bit, not null.</remarks>
    public virtual bool ReaderOld { get; set; }
    /// <summary>
    /// Name of the group of requesters associated with the permissions (mapping of requesters to the solver team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRole"/>
    /// <remarks>Column <c>RequesterRole</c>: nvarchar(255), null.</remarks>
    public virtual string RequesterRole { get; set; }
    /// <summary>
    /// ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleId"/>
    /// <remarks>Column <c>RequesterRoleId</c>: int, null.</remarks>
    public virtual int? RequesterRoleId { get; set; }
    /// <summary>
    /// ID of the group of requesters originally associated with the permissions (mapping of requesters to the solver
    /// team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleIdOld"/>
    /// <remarks>Column <c>RequesterRoleIdOld</c>: int, null.</remarks>
    public virtual int? RequesterRoleIdOld { get; set; }
    /// <summary>
    /// Name of the group of requesters originally associated with the permissions (mapping of requesters to the solver
    /// team).
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleOld"/>
    /// <remarks>Column <c>RequesterRoleOld</c>: nvarchar(255), null.</remarks>
    public virtual string RequesterRoleOld { get; set; }
    /// <summary>User group name which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Role"/>
    /// <remarks>Column <c>Role</c>: nvarchar(255), null.</remarks>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null.</remarks>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleIdOld"/>
    /// <remarks>Column <c>RoleIdOld</c>: int, null.</remarks>
    public virtual int? RoleIdOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleOld"/>
    /// <remarks>Column <c>RoleOld</c>: nvarchar(255), null.</remarks>
    public virtual string RoleOld { get; set; }
    /// <summary>Solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Solver"/>
    /// <remarks>Column <c>Solver</c>: bit, not null.</remarks>
    public virtual bool Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroup"/>
    /// <remarks>Column <c>SolverGroup</c>: bit, not null.</remarks>
    public virtual bool SolverGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroupOld"/>
    /// <remarks>Column <c>SolverGroupOld</c>: bit, not null.</remarks>
    public virtual bool SolverGroupOld { get; set; }
    /// <summary>Original solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverOld"/>
    /// <remarks>Column <c>SolverOld</c>: bit, not null.</remarks>
    public virtual bool SolverOld { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1"/>
    /// <remarks>Column <c>SolverTake1</c>: bit, not null.</remarks>
    public virtual bool SolverTake1 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1Old"/>
    /// <remarks>Column <c>SolverTake1Old</c>: bit, not null.</remarks>
    public virtual bool SolverTake1Old { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2"/>
    /// <remarks>Column <c>SolverTake2</c>: bit, not null.</remarks>
    public virtual bool SolverTake2 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2Old"/>
    /// <remarks>Column <c>SolverTake2Old</c>: bit, not null.</remarks>
    public virtual bool SolverTake2Old { get; set; }
    /// <summary>Permissions of the ticket reporter (formerly of the irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TicketReporter"/>
    /// <remarks>Column <c>TicketReporter</c>: bit, not null.</remarks>
    public virtual bool TicketReporter { get; set; }
    /// <summary>The original permissions of the ticket reporter (formerly of irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TicketReporterOld"/>
    /// <remarks>Column <c>TicketReporterOld</c>: bit, not null.</remarks>
    public virtual bool TicketReporterOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
