using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Outgoing email queue.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_MailMessage.htm"/>
[TableAttribute("dbo.MailMessage")]
public class MailMessage
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_EmlMail.htm"/>
    public virtual byte[] EmlMail { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_LastAttemptTime.htm"/>
    public virtual DateTime? LastAttemptTime { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_LastErrorMsg.htm"/>
    public virtual string LastErrorMsg { get; set; }
    /// <summary>Priority in the queue for sending. Larger numbers represent higher priority. The default value is 10000. Recommended values: - Urgent messages (e.g., synchronization messages between systems) = 15000 - Standard notifications and alerts = 10000 - Messages sent in bulk = 5000</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_Priority.htm"/>
    public virtual int? Priority { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_MailMessage_SendAttempts.htm"/>
    public virtual int? SendAttempts { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_MailMessage__ctor.htm"/>
    public MailMessage() { }
}
