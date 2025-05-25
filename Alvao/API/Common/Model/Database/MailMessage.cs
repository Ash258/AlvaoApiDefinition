using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Outgoing email queue.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html"/>
[Table("dbo.MailMessage")]
public class MailMessage {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_EmlMail"/>
    public virtual byte[] EmlMail { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_LastAttemptTime"/>
    public virtual DateTime? LastAttemptTime { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_LastErrorMsg"/>
    public virtual string LastErrorMsg { get; set; }
    /// <summary>Priority in the queue for sending. Larger numbers represent higher priority. The default value is 10000. Recommended values:</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_Priority"/>
    public virtual int? Priority { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_SendAttempts"/>
    public virtual int? SendAttempts { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.MailMessage.html#Alvao_API_Common_Model_Database_MailMessage_id"/>
    [Key]
    public virtual int id { get; set; }
}
