using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notifications sent.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html"/>
[Table("dbo.SamAlert")]
public class SamAlert {
    /// <summary>Computer</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ComputerId"/>
    public virtual int ComputerId { get; set; }
    /// <summary>Product</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ProductId"/>
    public virtual int ProductId { get; set; }
    /// <summary>Recipients</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_Recipients"/>
    public virtual string Recipients { get; set; }
    /// <summary>Date on which the system determined the problem was resolved.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ResolvedDate"/>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <summary>Notification type</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SamAlertRuleId"/>
    public virtual int SamAlertRuleId { get; set; }
    /// <summary>Date on which the notification was sent</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SentDate"/>
    public virtual DateTime SentDate { get; set; }
    /// <summary>Sequence number of notification</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SequenceNum"/>
    public virtual int SequenceNum { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_id"/>
    [Key]
    public virtual int id { get; set; }
}
