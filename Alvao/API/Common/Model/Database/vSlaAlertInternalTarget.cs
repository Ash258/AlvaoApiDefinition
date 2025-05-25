using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Individual SLA alerts for the expiration of tickets internal target date.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html"/>
[Table("dbo.vSlaAlertInternalTarget")]
public class vSlaAlertInternalTarget {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_InternalTarget"/>
    public virtual string InternalTarget { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_InternalTargetDeadline"/>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_fSummarySendHour"/>
    public virtual double? fSummarySendHour { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_iSlaAlertRuleId"/>
    public virtual int iSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_liHdTicketId"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_liSectionId"/>
    public virtual int liSectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSlaAlertInternalTarget.html#Alvao_API_Common_Model_Database_vSlaAlertInternalTarget_liSlaId"/>
    public virtual int liSlaId { get; set; }
}
