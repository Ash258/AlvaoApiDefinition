using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html"/>
[Table("dbo.TicketStatusTransitionFormTextBlock")]
public class TicketStatusTransitionFormTextBlock {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_ColSpan"/>
    /// <remarks>Column <c>ColSpan</c>: int, null.</remarks>
    public virtual int? ColSpan { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Column"/>
    /// <remarks>Column <c>Column</c>: int, null.</remarks>
    public virtual int? Column { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_StatusId"/>
    /// <remarks>Column <c>StatusId</c>: int, not null. References <see cref="TicketState"/>.</remarks>
    public virtual int StatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_TextHtml"/>
    /// <remarks>Column <c>TextHtml</c>: nvarchar(max), null.</remarks>
    public virtual string TextHtml { get; set; }
}
