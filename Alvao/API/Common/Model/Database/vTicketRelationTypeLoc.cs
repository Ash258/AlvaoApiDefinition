using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of ticket link types in all used languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketRelationTypeLoc.htm"/>
[TableAttribute("dbo.vTicketRelationTypeLoc")]
public class vTicketRelationTypeLoc
{
    /// <summary>Start of link (name).</summary>
    public virtual string BeginName { get; set; }
    /// <summary>Custom field</summary>
    public virtual int? CustomField1 { get; set; }
    /// <summary>If creating circular tasks is permitted. 1 = Yes, 0 = No.</summary>
    public virtual bool Cyclic { get; set; }
    /// <summary>If the link is directional or non-directional. 1 = directional, 0 = non-directional.</summary>
    public virtual bool Directional { get; set; }
    /// <summary>End of link (name).</summary>
    public virtual string EndName { get; set; }
    /// <summary>Record ID</summary>
    public virtual int id { get; set; }
    /// <summary>Localized name of the beginning of the link</summary>
    public virtual string LocalizedBeginName { get; set; }
    /// <summary>Localized name of the end of the link</summary>
    public virtual string LocalizedEndName { get; set; }
    /// <summary>The order of link types in menus</summary>
    public virtual int MenuOrder { get; set; }
    /// <summary>If the link type is OneToMany. 1 = OneToMany, 0 = ManyToMany.</summary>
    public virtual bool OneToMany { get; set; }
    /// <summary>Language localization ID</summary>
    public virtual int RelationTypeLocaleId { get; set; }
    /// <summary>System link type. When defining a custom link type, always use the value 1.</summary>
    public virtual int TicketRelationTypeBehaviorId { get; set; }

    public vTicketRelationTypeLoc() { }
}
