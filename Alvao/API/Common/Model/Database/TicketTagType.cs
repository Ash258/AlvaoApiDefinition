using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket tag type
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTagType.htm"/>
[TableAttribute("dbo.TicketTagType")]
public class TicketTagType
{
    /// <summary>Tag color (HEX)</summary>
    public virtual string Color { get; set; }
    /// <summary>Record ID</summary>
    [ExplicitKeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Tag name</summary>
    public virtual string Name { get; set; }

    public TicketTagType() { }
}
