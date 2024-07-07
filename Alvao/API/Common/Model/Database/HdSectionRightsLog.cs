using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in user permissions to services. The meaning of values in permission columns: 1=enable 0=refuse NULL=not set</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionRightsLog.htm"/>
[TableAttribute("dbo.HdSectionRightsLog")]
public class HdSectionRightsLog
{
    /// <summary>Exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolver.htm"/>
    public virtual bool? ExceptionalSolver { get; set; }
    /// <summary>Original exceptional solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ExceptionalSolverOld.htm"/>
    public virtual bool? ExceptionalSolverOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSection.htm"/>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionId.htm"/>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionIdOld.htm"/>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_HdSectionOld.htm"/>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Permissions of the ticket reporter (formerly of the irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_IrregularOperator.htm"/>
    public virtual bool? IrregularOperator { get; set; }
    /// <summary>The original permissions of the ticket reporter (formerly of irregular operator)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_IrregularOperatorOld.htm"/>
    public virtual bool? IrregularOperatorOld { get; set; }
    /// <summary>Manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Manager.htm"/>
    public virtual bool? Manager { get; set; }
    /// <summary>Original manager permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ManagerOld.htm"/>
    public virtual bool? ManagerOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPerson.htm"/>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ModifiedByPersonId.htm"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>Main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Operator.htm"/>
    public virtual bool? Operator { get; set; }
    /// <summary>Original main solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_OperatorOld.htm"/>
    public virtual bool? OperatorOld { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Person.htm"/>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonIdOld.htm"/>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_PersonOld.htm"/>
    public virtual string PersonOld { get; set; }
    /// <summary>Reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Reader.htm"/>
    public virtual bool? Reader { get; set; }
    /// <summary>Original reader permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_ReaderOld.htm"/>
    public virtual bool? ReaderOld { get; set; }
    /// <summary>Name of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRole.htm"/>
    public virtual string RequesterRole { get; set; }
    /// <summary>ID of the group of requesters associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleId.htm"/>
    public virtual int? RequesterRoleId { get; set; }
    /// <summary>ID of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleIdOld.htm"/>
    public virtual int? RequesterRoleIdOld { get; set; }
    /// <summary>Name of the group of requesters originally associated with the permissions (mapping of requesters to the solver team).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RequesterRoleOld.htm"/>
    public virtual string RequesterRoleOld { get; set; }
    /// <summary>User group name which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Role.htm"/>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleIdOld.htm"/>
    public virtual int? RoleIdOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_RoleOld.htm"/>
    public virtual string RoleOld { get; set; }
    /// <summary>Solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_Solver.htm"/>
    public virtual bool? Solver { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroup.htm"/>
    public virtual bool? SolverGroup { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverGroupOld.htm"/>
    public virtual bool? SolverGroupOld { get; set; }
    /// <summary>Original solver permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverOld.htm"/>
    public virtual bool? SolverOld { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1.htm"/>
    public virtual bool? SolverTake1 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (main)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake1Old.htm"/>
    public virtual bool? SolverTake1Old { get; set; }
    /// <summary>Solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2.htm"/>
    public virtual bool? SolverTake2 { get; set; }
    /// <summary>Original solver permissions with the right to take the ticket over (secondary)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_SolverTake2Old.htm"/>
    public virtual bool? SolverTake2Old { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionRightsLog_TimeStamp.htm"/>
    public virtual DateTime TimeStamp { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionRightsLog__ctor.htm"/>
    public HdSectionRightsLog() { }
}
