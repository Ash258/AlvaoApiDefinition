using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom fields values specified in ticket templates.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc.htm"/>
[TableAttribute("dbo.vTicketTemplateColumnValueLoc")]
public class vTicketTemplateColumnValueLoc
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_DataType.htm"/>
    public virtual string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_DefaultValue.htm"/>
    public virtual string DefaultValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_LocalizedDefaultValue.htm"/>
    public virtual string LocalizedDefaultValue { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_TicketTemplateColumnValueLocaleId.htm"/>
    public virtual int TicketTemplateColumnValueLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_TicketTemplateId.htm"/>
    public virtual int TicketTemplateId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc__ctor.htm"/>
    public vTicketTemplateColumnValueLoc() { }
}
