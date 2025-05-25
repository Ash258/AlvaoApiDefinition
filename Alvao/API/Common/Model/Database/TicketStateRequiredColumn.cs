using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Required items for individual ticket statuses, see dbo.TicketState.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRequiredColumn.html"/>
[Table("dbo.TicketStateRequiredColumn")]
public class TicketStateRequiredColumn {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRequiredColumn.html#Alvao_API_Common_Model_Database_TicketStateRequiredColumn_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRequiredColumn.html#Alvao_API_Common_Model_Database_TicketStateRequiredColumn_TicketStateId"/>
    public virtual int TicketStateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketStateRequiredColumn.html#Alvao_API_Common_Model_Database_TicketStateRequiredColumn_id"/>
    [Key]
    public virtual int id { get; set; }
}
