using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html"/>
[Table("dbo.TicketStatusTransitionFormTextBlock")]
public class TicketStatusTransitionFormTextBlock {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_ColSpan"/>
    public virtual int? ColSpan { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Column"/>
    public virtual int? Column { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_Order"/>
    public virtual int Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_StatusId"/>
    public virtual int StatusId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormTextBlock.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormTextBlock_TextHtml"/>
    public virtual string TextHtml { get; set; }
}
