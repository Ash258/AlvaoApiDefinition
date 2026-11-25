using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>column values on ticket template.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html"/>
[Table("dbo.TicketTemplateColumnValue")]
public class TicketTemplateColumnValue {
    /// <summary>Column Id.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html#Alvao_API_Common_Model_Database_TicketTemplateColumnValue_ColumnId"/>
    /// <remarks>Column <c>ColumnId</c>: int, not null. References <see cref="tColumn"/>.</remarks>
    public virtual int ColumnId { get; set; }
    /// <summary>Value stored in the column.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html#Alvao_API_Common_Model_Database_TicketTemplateColumnValue_DefaultValue"/>
    /// <remarks>Column <c>DefaultValue</c>: nvarchar(max), not null.</remarks>
    public virtual string DefaultValue { get; set; }
    /// <summary>Value saved in a column in HTML.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html#Alvao_API_Common_Model_Database_TicketTemplateColumnValue_DefaultValueHtml"/>
    /// <remarks>Column <c>DefaultValueHtml</c>: nvarchar(max), null.</remarks>
    public virtual string DefaultValueHtml { get; set; }
    /// <summary>Id of template to which the column belongs.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html#Alvao_API_Common_Model_Database_TicketTemplateColumnValue_TicketTemplateId"/>
    /// <remarks>Column <c>TicketTemplateId</c>: int, not null. References <see cref="TicketTemplate"/>.</remarks>
    public virtual int TicketTemplateId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketTemplateColumnValue.html#Alvao_API_Common_Model_Database_TicketTemplateColumnValue_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
