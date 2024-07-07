using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Allowed transitions among ticket statuses, see dbo.TicketState.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateRelation.htm"/>
[TableAttribute("dbo.TicketStateRelation")]
public class TicketStateRelation
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRelation_BeginTicketStateId.htm"/>
    public virtual int BeginTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRelation_EndTicketStateId.htm"/>
    public virtual int EndTicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRelation_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketStateRelation__ctor.htm"/>
    public TicketStateRelation() { }
}
