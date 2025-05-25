using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// </summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html"/>
[Table("dbo.SlaRightsLog")]
public class SlaRightsLog {
    /// <summary>Access permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Access"/>
    public virtual bool? Access { get; set; }
    /// <summary>Original access permissions</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_AccessOld"/>
    public virtual bool? AccessOld { get; set; }
    /// <summary>Marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Default"/>
    public virtual bool? Default { get; set; }
    /// <summary>Original marking of the default SLA</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_DefaultOld"/>
    public virtual bool? DefaultOld { get; set; }
    /// <summary>Service name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSection"/>
    public virtual string HdSection { get; set; }
    /// <summary>Service ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionId"/>
    public virtual int? HdSectionId { get; set; }
    /// <summary>ID of the original service</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionIdOld"/>
    public virtual int? HdSectionIdOld { get; set; }
    /// <summary>Original service name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_HdSectionOld"/>
    public virtual string HdSectionOld { get; set; }
    /// <summary>Inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Inheritance"/>
    public virtual bool? Inheritance { get; set; }
    /// <summary>Original value of inheritance.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_InheritanceOld"/>
    public virtual bool? InheritanceOld { get; set; }
    /// <summary>The name of the user who did the change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPerson"/>
    public virtual string ModifiedByPerson { get; set; }
    /// <summary>User ID of a person who performed the change.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_ModifiedByPersonId"/>
    public virtual int? ModifiedByPersonId { get; set; }
    /// <summary>User name of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Person"/>
    public virtual string Person { get; set; }
    /// <summary>User ID of a person who is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>User ID of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonIdOld"/>
    public virtual int? PersonIdOld { get; set; }
    /// <summary>User name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_PersonOld"/>
    public virtual string PersonOld { get; set; }
    /// <summary>User group name of a person who was originally a permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Role"/>
    public virtual string Role { get; set; }
    /// <summary>User group ID which is the permission holder.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleIdOld"/>
    public virtual int? RoleIdOld { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_RoleOld"/>
    public virtual string RoleOld { get; set; }
    /// <summary>SLA name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_Sla"/>
    public virtual string Sla { get; set; }
    /// <summary>SLA ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaId"/>
    public virtual int? SlaId { get; set; }
    /// <summary>ID of the original SLA</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaIdOld"/>
    public virtual int? SlaIdOld { get; set; }
    /// <summary>Original SLA name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_SlaOld"/>
    public virtual string SlaOld { get; set; }
    /// <summary>Change performance date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_TimeStamp"/>
    public virtual DateTime TimeStamp { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SlaRightsLog.html#Alvao_API_Common_Model_Database_SlaRightsLog_id"/>
    [Key]
    public virtual int id { get; set; }
}
