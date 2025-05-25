using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SLA alert type</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html"/>
[Table("dbo.TicketAlertType")]
public class TicketAlertType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.TicketAlertTypeId.html#fields"/>
    public enum TicketAlertTypeId {
        Deadline = 2,
        FirstReaction = 1,
        Inactive = 0,
        InternalTarget = 3,
    }
    /// <summary>Alert text without parameter</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateNoParams"/>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Alert text with parameter</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateParam1"/>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <summary>Alert name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_Name"/>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
