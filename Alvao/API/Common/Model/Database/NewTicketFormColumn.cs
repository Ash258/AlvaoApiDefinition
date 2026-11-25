using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Column order on a New Ticket Form</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html"/>
[Table("dbo.NewTicketFormColumn")]
public class NewTicketFormColumn {
    /// <summary>Column on which the item is displayed (0 left, 1 right)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_Column"/>
    /// <remarks>Column <c>Column</c>: int, null.</remarks>
    public virtual int? Column { get; set; }
    /// <summary>Link to column</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int ColumnId { get; set; }
    /// <summary>Row on which the item is displayed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>Marking the item obligation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_Required"/>
    /// <remarks>Column <c>Required</c>: bit, not null.</remarks>
    public virtual bool Required { get; set; }
    /// <summary>Link to service</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int SectionId { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormColumn.html#Alvao_API_Common_Model_Database_NewTicketFormColumn_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
