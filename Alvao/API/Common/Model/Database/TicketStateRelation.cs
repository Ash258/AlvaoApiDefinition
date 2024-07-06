using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Allowed transitions among ticket statuses, see dbo.TicketState.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateRelation.htm"/>
[TableAttribute("dbo.TicketStateRelation")]
public class TicketStateRelation
{
    public virtual int BeginTicketStateId { get; set; }
    public virtual int EndTicketStateId { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }

    public TicketStateRelation() { }
}
