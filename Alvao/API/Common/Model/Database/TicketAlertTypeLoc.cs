using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Language localization cache of SLA alert type, see TicketAlertType</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertTypeLoc.html"/>
[Table("dbo.TicketAlertTypeLoc")]
public class TicketAlertTypeLoc {
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertTypeLoc.html#Alvao_API_Common_Model_Database_TicketAlertTypeLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized alert text without parameter</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertTypeLoc.html#Alvao_API_Common_Model_Database_TicketAlertTypeLoc_MsgTemplateNoParams"/>
    public virtual string MsgTemplateNoParams { get; set; }
    /// <summary>Localized alert text with parameter</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertTypeLoc.html#Alvao_API_Common_Model_Database_TicketAlertTypeLoc_MsgTemplateParam1"/>
    public virtual string MsgTemplateParam1 { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TicketAlertTypeLoc.html#Alvao_API_Common_Model_Database_TicketAlertTypeLoc_TicketAlertTypeId"/>
    [ExplicitKey]
    public virtual int TicketAlertTypeId { get; set; }
}
