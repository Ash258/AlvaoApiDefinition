using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Translations of custom fields values specified in ticket templates.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc.htm"/>
[TableAttribute("dbo.vTicketTemplateColumnValueLoc")]
public class vTicketTemplateColumnValueLoc
{
    public virtual int ColumnId { get; set; }
    public virtual string DataType { get; set; }
    public virtual string DefaultValue { get; set; }
    public virtual int id { get; set; }
    public virtual string LocalizedDefaultValue { get; set; }
    public virtual int TicketTemplateColumnValueLocaleId { get; set; }
    public virtual int TicketTemplateId { get; set; }

    public vTicketTemplateColumnValueLoc() { }
}
