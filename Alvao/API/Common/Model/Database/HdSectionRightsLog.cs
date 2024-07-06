using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in user permissions to services. The meaning of values in permission columns: 1=enable///           0=refuse NULL=not set
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionRightsLog.htm"/>
[TableAttribute("dbo.HdSectionRightsLog")]
public class HdSectionRightsLog
{
    /// <summary>Exceptional solver permissions</summary>
    public virtual bool? ExceptionalSolver { get; set; }
    /// <summary>Original exceptional solver permissions</summary>
    public virtual bool? ExceptionalSolverOld { get; set; }
    /// <summary>Service name</summary>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Permissions of the ticket reporter (formerly of the irregular operator)</summary>
    public virtual bool? IrregularOperator { get; set; }
    /// <summary>The original permissions of the ticket reporter (formerly of irregular operator)</summary>
    public virtual bool? IrregularOperatorOld { get; set; }
    /// <summary>Manager permissions</summary>
    public virtual bool? Manager { get; set; }
    /// <summary>Original manager permissions</summary>
    public virtual bool? ManagerOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Main solver permissions</summary>
    public virtual bool? Operator { get; set; }
    /// <summary>Original main solver permissions</summary>
    public virtual bool? OperatorOld { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    public virtual string PersonOld { get; set; }
    /// <summary>Reader permissions</summary>
    public virtual bool? Reader { get; set; }
    /// <summary>Original reader permissions</summary>
    public virtual bool? ReaderOld { get; set; }
    /// <summary>Name of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual string RequesterRole { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual int? RequesterRoleId { get; set; }
    /// <summary>ID of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual int? RequesterRoleIdOld { get; set; }
    /// <summary>Name of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    public virtual string RequesterRoleOld { get; set; }
    /// <summary>User group name which is the permission holder.</summary>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    public virtual int? RoleId { get; set; }
    public virtual int? RoleIdOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    public virtual string RoleOld { get; set; }
    /// <summary>Solver permissions</summary>
    public virtual bool? Solver { get; set; }
    public virtual bool? SolverGroup { get; set; }
    public virtual bool? SolverGroupOld { get; set; }
    /// <summary>Original solver permissions</summary>
    public virtual bool? SolverOld { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (main)</summary>
    public virtual bool? SolverTake1 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (main)</summary>
    public virtual bool? SolverTake1Old { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (secondary)</summary>
    public virtual bool? SolverTake2 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (secondary)</summary>
    public virtual bool? SolverTake2Old { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    public virtual DateTime TimeStamp { get; set; }

    public HdSectionRightsLog() { }
}
