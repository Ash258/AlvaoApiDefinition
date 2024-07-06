using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in SLA assignment The meaning of values in permission columns: 1=enable 0=refuse NULL=not///           set
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaRightsLog.htm"/>
[TableAttribute("dbo.SlaRightsLog")]
public class SlaRightsLog
{
    /// <summary>Access permissions</summary>
    public virtual bool? Access { get; set; }
    /// <summary>Original access permissions</summary>
    public virtual bool? AccessOld { get; set; }
    /// <summary>Marking of the default SLA</summary>
    public virtual bool? Default { get; set; }
    /// <summary>Original marking of the default SLA</summary>
    public virtual bool? DefaultOld { get; set; }
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
    /// <summary>Inheritance.</summary>
    public virtual bool? Inheritance { get; set; }
    /// <summary>Original value of inheritance.</summary>
    public virtual bool? InheritanceOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    public virtual string PersonOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    public virtual int? RoleId { get; set; }
    public virtual int? RoleIdOld { get; set; }
    public virtual string RoleOld { get; set; }
    /// <summary>SLA name</summary>
    public virtual string Sla { get; set; }
    /// <summary>SLA ID</summary>
    public virtual int? SlaId { get; set; }
    /// <summary>ID of the original SLA</summary>
    public virtual int? SlaIdOld { get; set; }
    /// <summary>Original SLA name</summary>
    public virtual string SlaOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    public virtual DateTime TimeStamp { get; set; }

    public SlaRightsLog() { }
}
