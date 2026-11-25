using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Outgoing email queue.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html"/>
[Table("dbo.MailMessage")]
public class MailMessage {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_EmlMail"/>
    /// <remarks>Column <c>EmlMail</c>: varbinary, not null.</remarks>
    public virtual byte[] EmlMail { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_LastAttemptTime"/>
    /// <remarks>Column <c>LastAttemptTime</c>: datetime, null.</remarks>
    public virtual DateTime? LastAttemptTime { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_LastErrorMsg"/>
    /// <remarks>Column <c>LastErrorMsg</c>: nvarchar(max), null.</remarks>
    public virtual string LastErrorMsg { get; set; }
    /// <summary>
    /// Priority in the queue for sending. Larger numbers represent higher priority. The default value is 10000.
    /// Recommended values:
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_Priority"/>
    /// <remarks>Column <c>Priority</c>: int, null.</remarks>
    public virtual int? Priority { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_SendAttempts"/>
    /// <remarks>Column <c>SendAttempts</c>: int, null.</remarks>
    public virtual int? SendAttempts { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
