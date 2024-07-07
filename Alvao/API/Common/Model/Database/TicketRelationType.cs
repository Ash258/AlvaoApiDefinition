using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of links between tickets.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketRelationType.htm"/>
[TableAttribute("dbo.TicketRelationType")]
public class TicketRelationType
{
    public enum RelationId
    {
        RelatesTo = 1,
        ParentOf_ChildOf = 2,
        PrecedesBefore_FollowsAfter = 3,
        Blocks_IsBlockedBy = 4,
        IsDuplicateBy_Duplicated = 5,
    }

    /// <summary>The name of the link from the ticket view at the beginning of the link</summary>
    public virtual string BeginName { get; set; }
    /// <summary>Custom field</summary>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the link may not create a cycle. Example of a cycle: A is linked to B, B is linked to C, and C is linked to A.</summary>
    public virtual bool Cyclic { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the link is directional, i.e. links "Link A to B" and "Link B to B" are two different links.</summary>
    public virtual bool Directional { get; set; }
    /// <summary>The name of the link from the ticket view at the end of the link</summary>
    public virtual string EndName { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The order of link types in menus</summary>
    public virtual int MenuOrder { get; set; }
    /// <summary>Permitted values are 0 and 1. If set to 1, the target ticket may not contain more than one link.</summary>
    public virtual bool OneToMany { get; set; }
    /// <summary>System link type. When defining a custom link type, always use the value 1.</summary>
    public virtual int TicketRelationTypeBehaviorId { get; set; }

    public TicketRelationType() { }
}
