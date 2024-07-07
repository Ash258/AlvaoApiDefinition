using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Last sent alerts of unsigned handover protocols.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast.htm"/>
[TableAttribute("dbo.vTransferConfirmAlertLast")]
public class vTransferConfirmAlertLast
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_DocumentId.htm"/>
    public virtual int DocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_RuleId.htm"/>
    public virtual int RuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_SentDate.htm"/>
    public virtual DateTime SentDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast__ctor.htm"/>
    public vTransferConfirmAlertLast() { }
}
