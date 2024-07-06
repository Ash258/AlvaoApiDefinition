using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// System processes.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTypeBehavior.htm"/>
[TableAttribute("dbo.TicketTypeBehavior")]
public class TicketTypeBehavior
{
    public virtual string _TicketTypeBehavior { get; set; }
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }

    public TicketTypeBehavior() { }
}
