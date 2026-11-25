using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Column order on a Ticket status transition form</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html"/>
[Table("dbo.TicketStatusTransitionFormColumn")]
public class TicketStatusTransitionFormColumn {
    /// <summary>Column on which the item is displayed (0 left, 1 right)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_Column"/>
    public virtual int? Column { get; set; }
    /// <summary>Link to column (tColumn.iColumnId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Row on which the item is displayed</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_Order"/>
    public virtual int Order { get; set; }
    /// <summary>Marking the item obligation.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_Required"/>
    public virtual bool Required { get; set; }
    /// <summary>Id of the status (TicketState.id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketStatusTransitionFormColumn.html#Alvao_API_Common_Model_Database_TicketStatusTransitionFormColumn_StatusId"/>
    public virtual int StatusId { get; set; }
}
