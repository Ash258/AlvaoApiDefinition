using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket tag type</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html"/>
[Table("dbo.TicketTagType")]
public class TicketTagType {
    /// <summary>Tag color</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_Color"/>
    /// <remarks>Column <c>Color</c>: nvarchar(10), not null.</remarks>
    public virtual string Color { get; set; }
    /// <summary>Tag name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(70), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTagType.html#Alvao_API_Common_Model_Database_TicketTagType_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
