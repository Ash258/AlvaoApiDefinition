using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Logging of changes in SLA assignment The meaning of values in permission columns: 1=enable 0=refuse NULL=not set
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html"/>
[Table("dbo.SlaRightsLog")]
public class SlaRightsLog {
    /// <summary>Access permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Access"/>
    /// <remarks>Column <c>Access</c>: bit, null.</remarks>
    public virtual bool? Access { get; set; }
    /// <summary>Original access permissions</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_AccessOld"/>
    /// <remarks>Column <c>AccessOld</c>: bit, null.</remarks>
    public virtual bool? AccessOld { get; set; }
    /// <summary>Marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Default"/>
    /// <remarks>Column <c>Default</c>: bit, null.</remarks>
    public virtual bool? Default { get; set; }
    /// <summary>Original marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_DefaultOld"/>
    /// <remarks>Column <c>DefaultOld</c>: bit, null.</remarks>
    public virtual bool? DefaultOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSection"/>
    /// <remarks>Column <c>HdSection</c>: nvarchar(1024), null.</remarks>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, null.</remarks>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionIdOld"/>
    /// <remarks>Column <c>HdSectionIdOld</c>: int, null.</remarks>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionOld"/>
    /// <remarks>Column <c>HdSectionOld</c>: nvarchar(1024), null.</remarks>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Inheritance"/>
    /// <remarks>Column <c>Inheritance</c>: bit, null.</remarks>
    public virtual bool? Inheritance { get; set; }
    /// <summary>Original value of inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_InheritanceOld"/>
    /// <remarks>Column <c>InheritanceOld</c>: bit, null.</remarks>
    public virtual bool? InheritanceOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPerson"/>
    /// <remarks>Column <c>ModifiedByPerson</c>: nvarchar(255), not null.</remarks>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPersonId"/>
    /// <remarks>Column <c>ModifiedByPersonId</c>: int, null.</remarks>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Person"/>
    /// <remarks>Column <c>Person</c>: nvarchar(255), null.</remarks>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonIdOld"/>
    /// <remarks>Column <c>PersonIdOld</c>: int, null.</remarks>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonOld"/>
    /// <remarks>Column <c>PersonOld</c>: nvarchar(255), null.</remarks>
    public virtual string PersonOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Role"/>
    /// <remarks>Column <c>Role</c>: nvarchar(255), null.</remarks>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null.</remarks>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleIdOld"/>
    /// <remarks>Column <c>RoleIdOld</c>: int, null.</remarks>
    public virtual int? RoleIdOld { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleOld"/>
    /// <remarks>Column <c>RoleOld</c>: nvarchar(255), null.</remarks>
    public virtual string RoleOld { get; set; }
    /// <summary>SLA name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Sla"/>
    /// <remarks>Column <c>Sla</c>: nvarchar(255), null.</remarks>
    public virtual string Sla { get; set; }
    /// <summary>SLA ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaId"/>
    /// <remarks>Column <c>SlaId</c>: int, null.</remarks>
    public virtual int? SlaId { get; set; }
    /// <summary>ID of the original SLA</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaIdOld"/>
    /// <remarks>Column <c>SlaIdOld</c>: int, null.</remarks>
    public virtual int? SlaIdOld { get; set; }
    /// <summary>Original SLA name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaOld"/>
    /// <remarks>Column <c>SlaOld</c>: nvarchar(255), null.</remarks>
    public virtual string SlaOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_TimeStamp"/>
    /// <remarks>Column <c>TimeStamp</c>: datetime, not null.</remarks>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
