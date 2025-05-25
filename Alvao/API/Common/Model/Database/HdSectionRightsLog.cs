using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in user permissions to services.
/// The meaning of values in permission columns:
/// 1=enable
/// 0=not set
/// </summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html"/>
[Table("dbo.HdSectionRightsLog")]
public class HdSectionRightsLog {
    /// <summary>Exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolver"/>
    public virtual bool ExceptionalSolver { get; set; }
    /// <summary>Original exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolverOld"/>
    public virtual bool ExceptionalSolverOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSection"/>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionId"/>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionIdOld"/>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionOld"/>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_MainSolver"/>
    public virtual bool MainSolver { get; set; }
    /// <summary>Original main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_MainSolverOld"/>
    public virtual bool MainSolverOld { get; set; }
    /// <summary>Manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Manager"/>
    public virtual bool Manager { get; set; }
    /// <summary>Original manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ManagerOld"/>
    public virtual bool ManagerOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPerson"/>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPersonId"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Person"/>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonIdOld"/>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonOld"/>
    public virtual string PersonOld { get; set; }
    /// <summary>Reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Reader"/>
    public virtual bool Reader { get; set; }
    /// <summary>Original reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_ReaderOld"/>
    public virtual bool ReaderOld { get; set; }
    /// <summary>Name of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRole"/>
    public virtual string RequesterRole { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleId"/>
    public virtual int? RequesterRoleId { get; set; }
    /// <summary>ID of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleIdOld"/>
    public virtual int? RequesterRoleIdOld { get; set; }
    /// <summary>Name of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleOld"/>
    public virtual string RequesterRoleOld { get; set; }
    /// <summary>User group name which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Role"/>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleIdOld"/>
    public virtual int? RoleIdOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleOld"/>
    public virtual string RoleOld { get; set; }
    /// <summary>Solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_Solver"/>
    public virtual bool Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroup"/>
    public virtual bool SolverGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroupOld"/>
    public virtual bool SolverGroupOld { get; set; }
    /// <summary>Original solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverOld"/>
    public virtual bool SolverOld { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1"/>
    public virtual bool SolverTake1 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1Old"/>
    public virtual bool SolverTake1Old { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2"/>
    public virtual bool SolverTake2 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2Old"/>
    public virtual bool SolverTake2Old { get; set; }
    /// <summary>Permissions of the ticket reporter (formerly of the irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TicketReporter"/>
    public virtual bool TicketReporter { get; set; }
    /// <summary>The original permissions of the ticket reporter (formerly of irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TicketReporterOld"/>
    public virtual bool TicketReporterOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_TimeStamp"/>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionRightsLog.html#Alvao_API_Common_Model_Database_HdSectionRightsLog_id"/>
    [Key]
    public virtual int id { get; set; }
}
