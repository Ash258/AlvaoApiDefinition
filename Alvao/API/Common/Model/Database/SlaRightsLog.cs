using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Logging of changes in SLA assignment The meaning of values in permission columns: 1=enable 0=refuse NULL=not set</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaRightsLog.htm"/>
[TableAttribute("dbo.SlaRightsLog")]
public class SlaRightsLog {
    /// <summary>Access permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Access.htm"/>
    public virtual bool? Access { get; set; }
    /// <summary>Original access permissions</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_AccessOld.htm"/>
    public virtual bool? AccessOld { get; set; }
    /// <summary>Marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Default.htm"/>
    public virtual bool? Default { get; set; }
    /// <summary>Original marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_DefaultOld.htm"/>
    public virtual bool? DefaultOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_HdSection.htm"/>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionId.htm"/>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionIdOld.htm"/>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionOld.htm"/>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Inheritance.htm"/>
    public virtual bool? Inheritance { get; set; }
    /// <summary>Original value of inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_InheritanceOld.htm"/>
    public virtual bool? InheritanceOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPerson.htm"/>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPersonId.htm"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Person.htm"/>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_PersonIdOld.htm"/>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_PersonOld.htm"/>
    public virtual string PersonOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Role.htm"/>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_RoleIdOld.htm"/>
    public virtual int? RoleIdOld { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_RoleOld.htm"/>
    public virtual string RoleOld { get; set; }
    /// <summary>SLA name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_Sla.htm"/>
    public virtual string Sla { get; set; }
    /// <summary>SLA ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_SlaId.htm"/>
    public virtual int? SlaId { get; set; }
    /// <summary>ID of the original SLA</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_SlaIdOld.htm"/>
    public virtual int? SlaIdOld { get; set; }
    /// <summary>Original SLA name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_SlaOld.htm"/>
    public virtual string SlaOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaRightsLog_TimeStamp.htm"/>
    public virtual DateTime TimeStamp { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SlaRightsLog__ctor.htm"/>
    public SlaRightsLog() { }
}
