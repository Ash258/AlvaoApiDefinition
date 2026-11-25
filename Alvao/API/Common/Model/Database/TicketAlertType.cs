using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SLA alert type</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html"/>
[Table("dbo.TicketAlertType")]
public class TicketAlertType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.TicketAlertTypeId.html#fields"/>
    public enum TicketAlertTypeId {
        Inactive = 0,
        FirstReaction = 1,
        Deadline = 2,
        InternalTarget = 3,
        TaskDueDate = 4,
    }

    /// <summary>Alert text without parameter</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateNoParams"/>
    /// <remarks>Column <c>MsgTemplateNoParams</c>: nvarchar(max), null.</remarks>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Alert text with parameter</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_MsgTemplateParam1"/>
    /// <remarks>Column <c>MsgTemplateParam1</c>: nvarchar(max), null.</remarks>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <summary>Alert name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(max), not null.</remarks>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertType.html#Alvao_API_Common_Model_Database_TicketAlertType_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
