using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM notifications sent.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SamAlert.htm"/>
[TableAttribute("dbo.SamAlert")]
public class SamAlert
{
    /// <summary>Computer</summary>
    public virtual int ComputerId { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Product</summary>
    public virtual int ProductId { get; set; }
    /// <summary>Recipients</summary>
    public virtual string Recipients { get; set; }
    /// <summary>Date on which the system determined the problem was resolved.</summary>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <summary>Notification type</summary>
    public virtual int SamAlertRuleId { get; set; }
    /// <summary>Date on which the notification was sent</summary>
    public virtual DateTime SentDate { get; set; }
    /// <summary>Sequence number of notification</summary>
    public virtual int SequenceNum { get; set; }

    public SamAlert() { }
}
