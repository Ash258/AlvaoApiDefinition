using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of links between tickets.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html"/>
[Table("dbo.TicketRelationType")]
public class TicketRelationType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.RelationId.html#fields"/>
    public enum RelationId {
        RelatesTo = 1,
        ParentOf_ChildOf = 2,
        PrecedesBefore_FollowsAfter = 3,
        Blocks_IsBlockedBy = 4,
        IsDuplicateBy_Duplicated = 5,
    }
    /// <summary>The name of the link from the ticket view at the beginning of the link</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_BeginName"/>
    public virtual string BeginName { get; set; }
    /// <summary>Custom field</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the link may not create a cycle. Example of a cycle: A is linked to B, B is linked to C, and C is linked to A.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_Cyclic"/>
    public virtual bool Cyclic { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the link is directional, i.e. links &quot;Link A to B&quot; and &quot;Link B to B&quot; are two different links.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_Directional"/>
    public virtual bool Directional { get; set; }
    /// <summary>The name of the link from the ticket view at the end of the link</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_EndName"/>
    public virtual string EndName { get; set; }
    /// <summary>The order of link types in menus</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_MenuOrder"/>
    public virtual int MenuOrder { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the target ticket may not contain more than one link.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_OneToMany"/>
    public virtual bool OneToMany { get; set; }
    /// <summary>System link type. When defining a custom link type, always use the value 1.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_TicketRelationTypeBehaviorId"/>
    public virtual int TicketRelationTypeBehaviorId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketRelationType.html#Alvao_API_Common_Model_Database_TicketRelationType_id"/>
    [Key]
    public virtual int id { get; set; }
}
