using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Sent alerts to sign the handover protocols.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TransferConfirmAlert.htm"/>
[TableAttribute("dbo.TransferConfirmAlert")]
public class TransferConfirmAlert {
    /// <summary>Document ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlert_DocumentId.htm"/>
    public virtual int DocumentId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlert_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Kind of alert.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlert_RuleId.htm"/>
    public virtual int RuleId { get; set; }
    /// <summary>Date of sending the alert.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TransferConfirmAlert_SentDate.htm"/>
    public virtual DateTime SentDate { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TransferConfirmAlert__ctor.htm"/>
    public TransferConfirmAlert() { }
}
