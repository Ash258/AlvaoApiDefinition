using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM notification - last unresolved notifications sent
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSamAlertLast.htm"/>
[TableAttribute("dbo.vSamAlertLast")]
public class vSamAlertLast
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_ComputerId.htm"/>
    public virtual int ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_ProductId.htm"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_Recipients.htm"/>
    public virtual string Recipients { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_ResolvedDate.htm"/>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_SamAlertRuleId.htm"/>
    public virtual int SamAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_SentDate.htm"/>
    public virtual DateTime SentDate { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vSamAlertLast_SequenceNum.htm"/>
    public virtual int SequenceNum { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vSamAlertLast__ctor.htm"/>
    public vSamAlertLast() { }
}
