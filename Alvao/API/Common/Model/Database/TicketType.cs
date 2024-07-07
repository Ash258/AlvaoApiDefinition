using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Processes. Among others, the process defines possible ticket statuses, solving process, custom ticket items, etc.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketType.htm"/>
[TableAttribute("dbo.TicketType")]
public class TicketType
{
    /// <summary>Process name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType__TicketType.htm"/>
    public virtual string _TicketType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_BackResolveDeadlineHours.htm"/>
    public virtual double? BackResolveDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_CustomField1.htm"/>
    public virtual int? CustomField1 { get; set; }
    /// <summary>Description of the process</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_Description.htm"/>
    public virtual string Description { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Process type ID (TicketTypeBehavior.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_TicketTypeBehaviorId.htm"/>
    public virtual int TicketTypeBehaviorId { get; set; }
    /// <summary>ID of the effect of tickets with this process on the health of objects in the given tickets (TicketTypeNodeHealthImpact.id).1=no effect, 2=incident, 3=change.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketType_TicketTypeNodeHealthImpactId.htm"/>
    public virtual int TicketTypeNodeHealthImpactId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketType__ctor.htm"/>
    public TicketType() { }
}
