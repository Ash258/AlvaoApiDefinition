using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket tag type</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html"/>
[Table("dbo.TicketTagType")]
public class TicketTagType {
    /// <summary>Tag color (HEX)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_Color"/>
    public virtual string Color { get; set; }
    /// <summary>Tag name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
