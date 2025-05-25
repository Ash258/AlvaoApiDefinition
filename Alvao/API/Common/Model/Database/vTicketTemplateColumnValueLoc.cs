using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Translations of custom fields values specified in ticket templates.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html"/>
[Table("dbo.vTicketTemplateColumnValueLoc")]
public class vTicketTemplateColumnValueLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_ColumnId"/>
    public virtual int ColumnId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_DataType"/>
    public virtual string DataType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_DefaultValue"/>
    public virtual string DefaultValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_LocalizedDefaultValue"/>
    public virtual string LocalizedDefaultValue { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_TicketTemplateColumnValueLocaleId"/>
    public virtual int TicketTemplateColumnValueLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_TicketTemplateId"/>
    public virtual int TicketTemplateId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTemplateColumnValueLoc.html#Alvao_API_Common_Model_Database_vTicketTemplateColumnValueLoc_id"/>
    public virtual int id { get; set; }
}
