using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for the expiration of the ticket deadline.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html"/>
[Table("dbo.vSlaAlertDeadline")]
public class vSlaAlertDeadline {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_dHdTicketDeadline"/>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_iSlaAlertRuleId"/>
    public virtual int iSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertDeadline.html#Alvao_API_Common_Model_Database_vSlaAlertDeadline_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
