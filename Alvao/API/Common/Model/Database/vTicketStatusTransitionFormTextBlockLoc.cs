using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of localizations for text blocks on ticket status transition forms.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html"/>
[Table("dbo.vTicketStatusTransitionFormTextBlockLoc")]
public class vTicketStatusTransitionFormTextBlockLoc {
    /// <summary>Number of columns the item occupies. (1 half row, 2 whole row).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_ColSpan"/>
    public virtual int? ColSpan { get; set; }
    /// <summary>Column on which the item is displayed (0 left, 1 right).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_Column"/>
    public virtual int? Column { get; set; }
    /// <summary>Entity ID (TicketStatusTransitionFormTextBlock.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_Id"/>
    public virtual int Id { get; set; }
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Row on which the item is displayed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_Order"/>
    public virtual int Order { get; set; }
    /// <summary>Ticket status ID (TicketState.id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_StatusId"/>
    public virtual int StatusId { get; set; }
    /// <summary>Localized text in HTML.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.vTicketStatusTransitionFormTextBlockLoc.html#Alvao_API_Common_Model_Database_vTicketStatusTransitionFormTextBlockLoc_TextHtml"/>
    public virtual string TextHtml { get; set; }
}
