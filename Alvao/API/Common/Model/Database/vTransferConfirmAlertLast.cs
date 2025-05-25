using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last sent alerts of unsigned handover protocols.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTransferConfirmAlertLast.html"/>
[Table("dbo.vTransferConfirmAlertLast")]
public class vTransferConfirmAlertLast {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTransferConfirmAlertLast.html#Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_DocumentId"/>
    public virtual int DocumentId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTransferConfirmAlertLast.html#Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_RuleId"/>
    public virtual int RuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTransferConfirmAlertLast.html#Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_SentDate"/>
    public virtual DateTime SentDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vTransferConfirmAlertLast.html#Alvao_API_Common_Model_Database_vTransferConfirmAlertLast_id"/>
    public virtual int id { get; set; }
}
