using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Required items for individual ticket statuses, see dbo.TicketState.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketStateRequiredColumn.htm"/>
[TableAttribute("dbo.TicketStateRequiredColumn")]
public class TicketStateRequiredColumn {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRequiredColumn_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRequiredColumn_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketStateRequiredColumn_TicketStateId.htm"/>
    public virtual int TicketStateId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketStateRequiredColumn__ctor.htm"/>
    public TicketStateRequiredColumn() { }
}
