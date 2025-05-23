using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Ticket log records for notification sent for an unresolved issue or upcoming deadline.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tSlaAlert.htm"/>
[TableAttribute("dbo.tSlaAlert")]
public class tSlaAlert
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_dHdTicketDeadline.htm"/>
    public virtual DateTime? dHdTicketDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_dSent.htm"/>
    public virtual DateTime dSent { get; set; }
    /// <summary>The expiration deadline of first response.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_FirstReactionDeadline.htm"/>
    public virtual DateTime? FirstReactionDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Internal target date.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_InternalTargetDeadline.htm"/>
    public virtual DateTime? InternalTargetDeadline { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_liHdTicketId.htm"/>
    public virtual int liHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_liSlaAlertRuleId.htm"/>
    public virtual int? liSlaAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_sError.htm"/>
    public virtual string sError { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tSlaAlert_sTo.htm"/>
    public virtual string sTo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tSlaAlert__ctor.htm"/>
    public tSlaAlert() { }
}
