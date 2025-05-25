using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of processes used in all used languages.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html"/>
[Table("dbo.vTicketTypeLoc")]
public class vTicketTypeLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_BackResolveDeadlineHours"/>
    public virtual double? BackResolveDeadlineHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_CustomField1"/>
    public virtual int? CustomField1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_Description"/>
    public virtual string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_LocalizedType"/>
    public virtual string LocalizedType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketType"/>
    public virtual string TicketType { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketTypeBehaviorId"/>
    public virtual int TicketTypeBehaviorId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_TicketTypeLocaleId"/>
    public virtual int TicketTypeLocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTicketTypeLoc.html#Alvao_API_Common_Model_Database_vTicketTypeLoc_id"/>
    public virtual int id { get; set; }
}
