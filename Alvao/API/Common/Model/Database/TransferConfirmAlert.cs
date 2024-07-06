using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Sent alerts to sign the handover protocols.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlert.htm"/>
[TableAttribute("dbo.TransferConfirmAlert")]
public class TransferConfirmAlert
{
    /// <summary>Document ID.</summary>
    public virtual int DocumentId { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Kind of alert.</summary>
    public virtual int RuleId { get; set; }
    /// <summary>Date of sending the alert.</summary>
    public virtual DateTime SentDate { get; set; }

    public TransferConfirmAlert() { }
}
