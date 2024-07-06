using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Processes. Among others, the process defines possible ticket statuses, solving process, custom ticket items,///           etc.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketType.htm"/>
[TableAttribute("dbo.TicketType")]
public class TicketType
{
    /// <summary>Process name</summary>
    public virtual string _TicketType { get; set; }
    public virtual double? BackResolveDeadlineHours { get; set; }
    public virtual int? CustomField1 { get; set; }
    /// <summary>Description of the process</summary>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Process type ID (TicketTypeBehavior.id)</summary>
    public virtual int TicketTypeBehaviorId { get; set; }
    /// <summary>ID of the effect of tickets with this process on the health of objects in the given tickets (TicketTypeNodeHealthImpact.id).1=no effect, 2=incident, 3=change.</summary>
    public virtual int TicketTypeNodeHealthImpactId { get; set; }

    public TicketType() { }
}
