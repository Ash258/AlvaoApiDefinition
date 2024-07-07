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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_ComputerId.htm"/>
    public virtual int ComputerId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Product</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_ProductId.htm"/>
    public virtual int ProductId { get; set; }
    /// <summary>Recipients</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_Recipients.htm"/>
    public virtual string Recipients { get; set; }
    /// <summary>Date on which the system determined the problem was resolved.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_ResolvedDate.htm"/>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <summary>Notification type</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_SamAlertRuleId.htm"/>
    public virtual int SamAlertRuleId { get; set; }
    /// <summary>Date on which the notification was sent</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_SentDate.htm"/>
    public virtual DateTime SentDate { get; set; }
    /// <summary>Sequence number of notification</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SamAlert_SequenceNum.htm"/>
    public virtual int SequenceNum { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SamAlert__ctor.htm"/>
    public SamAlert() { }
}
