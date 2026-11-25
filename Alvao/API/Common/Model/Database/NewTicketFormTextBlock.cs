using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Text block order on a New Ticket Form</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html"/>
[Table("dbo.NewTicketFormTextBlock")]
public class NewTicketFormTextBlock {
    /// <summary>Number of columns the item occupies. (1 half row, 2 whole row)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_ColSpan"/>
    /// <remarks>Column <c>ColSpan</c>: int, null.</remarks>
    public virtual int? ColSpan { get; set; }
    /// <summary>Column on which the item is displayed (0 left, 1 right)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_Column"/>
    /// <remarks>Column <c>Column</c>: int, null.</remarks>
    public virtual int? Column { get; set; }
    /// <summary>Row on which the item is displayed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>Id of the service (tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int SectionId { get; set; }
    /// <summary>Text in HTML</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_TextHtml"/>
    /// <remarks>Column <c>TextHtml</c>: nvarchar(max), null.</remarks>
    public virtual string TextHtml { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewTicketFormTextBlock.html#Alvao_API_Common_Model_Database_NewTicketFormTextBlock_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
