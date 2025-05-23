using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Column order on a New Ticket Form</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewTicketFormColumn.htm"/>
[TableAttribute("dbo.NewTicketFormColumn")]
public class NewTicketFormColumn {
    /// <summary>Link to column</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormColumn_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Entity ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormColumn_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Column order on a New Ticket Form</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormColumn_Order.htm"/>
    public virtual int Order { get; set; }
    /// <summary>Marking the item obligation.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormColumn_Required.htm"/>
    public virtual bool Required { get; set; }
    /// <summary>Link to service</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_NewTicketFormColumn_SectionId.htm"/>
    public virtual int SectionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_NewTicketFormColumn__ctor.htm"/>
    public NewTicketFormColumn() { }
}
