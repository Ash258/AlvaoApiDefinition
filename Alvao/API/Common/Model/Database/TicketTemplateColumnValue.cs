using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// column values on ticket template.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketTemplateColumnValue.htm"/>
[TableAttribute("dbo.TicketTemplateColumnValue")]
public class TicketTemplateColumnValue
{
    /// <summary>Column Id.</summary>
    public virtual int ColumnId { get; set; }
    /// <summary>Value stored in the column.</summary>
    public virtual string DefaultValue { get; set; }
    /// <summary>Value saved in a column in HTML.</summary>
    public virtual string DefaultValueHtml { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Id of template to which the column belongs.</summary>
    public virtual int TicketTemplateId { get; set; }

    public TicketTemplateColumnValue() { }
}
