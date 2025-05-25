using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of ticket link types in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html"/>
[Table("dbo.vTicketRelationTypeLoc")]
public class vTicketRelationTypeLoc {
    /// <summary>Start of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_BeginName"/>
    public virtual string BeginName { get; set; }
    /// <summary>Custom field</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>If creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_Cyclic"/>
    public virtual bool Cyclic { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_Directional"/>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_EndName"/>
    public virtual string EndName { get; set; }
    /// <summary>Localized name of the beginning of the link</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_LocalizedBeginName"/>
    public virtual string LocalizedBeginName { get; set; }
    /// <summary>Localized name of the end of the link</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_LocalizedEndName"/>
    public virtual string LocalizedEndName { get; set; }
    /// <summary>The order of link types in menus</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_MenuOrder"/>
    public virtual int MenuOrder { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_OneToMany"/>
    public virtual bool OneToMany { get; set; }
    /// <summary>Language localization ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_RelationTypeLocaleId"/>
    public virtual int RelationTypeLocaleId { get; set; }
    /// <summary>System link type. When defining a custom link type, always use the value 1.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_TicketRelationTypeBehaviorId"/>
    public virtual int TicketRelationTypeBehaviorId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketRelationTypeLoc.html#Alvao_API_Common_Model_Database_vTicketRelationTypeLoc_id"/>
    public virtual int id { get; set; }
}
