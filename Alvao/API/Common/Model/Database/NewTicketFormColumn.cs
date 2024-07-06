using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Column order on a New Ticket Form
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_NewTicketFormColumn.htm"/>
[TableAttribute("dbo.NewTicketFormColumn")]
public class NewTicketFormColumn
{
    /// <summary>Link to column</summary>
    public virtual int ColumnId { get; set; }
    /// <summary>Entity ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Column order on a New Ticket Form</summary>
    public virtual int Order { get; set; }
    /// <summary>Marking the item obligation.</summary>
    public virtual bool Required { get; set; }
    /// <summary>Link to service</summary>
    public virtual int SectionId { get; set; }

    public NewTicketFormColumn() { }
}
