using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA notifications for requester inactivity.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html"/>
[Table("dbo.vSlaAlertInactiveRequesters")]
public class vSlaAlertInactiveRequesters {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveRequesters_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveRequesters_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveRequesters_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveRequesters_liSlaAlertRuleId"/>
    public virtual int liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInactiveRequesters.html#Alvao_API_Common_Model_Database_vSlaAlertInactiveRequesters_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
