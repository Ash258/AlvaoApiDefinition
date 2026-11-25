using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notifications sent.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html"/>
[Table("dbo.SamAlert")]
public class SamAlert {
    /// <summary>Computer</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ComputerId"/>
    /// <remarks>Column <c>ComputerId</c>: int, not null. References <see cref="tblNode"/>.</remarks>
    public virtual int ComputerId { get; set; }
    /// <summary>Product</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ProductId"/>
    /// <remarks>Column <c>ProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    public virtual int ProductId { get; set; }
    /// <summary>Recipients</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_Recipients"/>
    /// <remarks>Column <c>Recipients</c>: nvarchar(max), null.</remarks>
    public virtual string Recipients { get; set; }
    /// <summary>Date on which the system determined the problem was resolved.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_ResolvedDate"/>
    /// <remarks>Column <c>ResolvedDate</c>: datetime, null.</remarks>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <summary>Notification type</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SamAlertRuleId"/>
    /// <remarks>Column <c>SamAlertRuleId</c>: int, not null. References <see cref="SamAlertRule"/>.</remarks>
    public virtual int SamAlertRuleId { get; set; }
    /// <summary>Date on which the notification was sent</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SentDate"/>
    /// <remarks>Column <c>SentDate</c>: datetime, not null.</remarks>
    public virtual DateTime SentDate { get; set; }
    /// <summary>Sequence number of notification</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_SequenceNum"/>
    /// <remarks>Column <c>SequenceNum</c>: int, not null.</remarks>
    public virtual int SequenceNum { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SamAlert.html#Alvao_API_Common_Model_Database_SamAlert_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
