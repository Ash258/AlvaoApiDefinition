using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Last sent alerts of unsigned handover protocols.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTransferConfirmAlertLast.htm"/>
[TableAttribute("dbo.vTransferConfirmAlertLast")]
public class vTransferConfirmAlertLast
{
    public virtual int DocumentId { get; set; }
    public virtual int id { get; set; }
    public virtual int RuleId { get; set; }
    public virtual DateTime SentDate { get; set; }

    public vTransferConfirmAlertLast() { }
}
