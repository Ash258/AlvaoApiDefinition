using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Sent alerts to sign the handover protocols.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlert.html"/>
[Table("dbo.TransferConfirmAlert")]
public class TransferConfirmAlert {
    /// <summary>Document ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlert.html#Alvao_API_Common_Model_Database_TransferConfirmAlert_DocumentId"/>
    public virtual int DocumentId { get; set; }
    /// <summary>Kind of alert.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlert.html#Alvao_API_Common_Model_Database_TransferConfirmAlert_RuleId"/>
    public virtual int RuleId { get; set; }
    /// <summary>Date of sending the alert.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlert.html#Alvao_API_Common_Model_Database_TransferConfirmAlert_SentDate"/>
    public virtual DateTime SentDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.TransferConfirmAlert.html#Alvao_API_Common_Model_Database_TransferConfirmAlert_id"/>
    [Key]
    public virtual int id { get; set; }
}
