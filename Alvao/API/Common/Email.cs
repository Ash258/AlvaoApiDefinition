using Rebex;

namespace Alvao.API.Common;

/// <summary>Facade class grouping mail methods.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.html"/>
public static class Email {
    /// <summary>Priority for mail messages in queue.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.MailQueuePriority.html#fields"/>
    public enum MailQueuePriority {
        High = 15000,
        Low = 5000,
        Standard = 10000,
    }
    /// <summary>Queues mail message by inserting it into database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.html#Alvao_API_Common_Email_Queue_Rebex_Mail_MailMessage_Alvao_API_Common_Email_MailQueuePriority_"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    public static void Queue(Rebex.Mail.MailMessage message, Email.MailQueuePriority queuePriority = MailQueuePriority.Standard) { throw new System.NotImplementedException(); }
    /// <summary>Queues mail message by inserting it into database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.html#Alvao_API_Common_Email_Queue_System_Net_Mail_MailMessage_Alvao_API_Common_Email_MailQueuePriority_"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    public static void Queue(System.Net.Mail.MailMessage message, Email.MailQueuePriority queuePriority = MailQueuePriority.Standard) { throw new System.NotImplementedException(); }
    /// <summary>Queues mail message by inserting it into database. QueueMailMessage is deprecated, please use Queue instead.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.html#Alvao_API_Common_Email_QueueMailMessage_Rebex_Mail_MailMessage_Alvao_API_Common_Email_MailQueuePriority_"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    [Obsolete("QueueMailMessage is deprecated, please use Queue instead.")]
    public static void QueueMailMessage(Rebex.Mail.MailMessage message, Email.MailQueuePriority queuePriority = MailQueuePriority.Standard) { throw new System.NotImplementedException(); }
    /// <summary>
    /// <example>
    /// <code>
    /// System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
    /// msg.From = new MailAddress("emailFrom@email.com"); //Add sender email address
    /// msg.To.Add(new MailAddress("emailTo@email.com")); //Add recipient email address
    /// msg.Subject = "Subject of email";
    /// msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString("Message in plaintext", System.Text.Encoding.UTF8, "text/plain")); //Email body in plantext
    /// msg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString("Message in HTML", System.Text.Encoding.UTF8, "text/html")); //Email body in HTML
    /// Alvao.API.Common.Email.Queue(msg);
    /// </code>
    /// </example>
    /// </summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Email.html#Alvao_API_Common_Email_QueueMailMessage_System_Net_Mail_MailMessage_Alvao_API_Common_Email_MailQueuePriority_"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    [Obsolete("QueueMailMessage is deprecated, please use Queue instead.")]
    public static void QueueMailMessage(System.Net.Mail.MailMessage message, Email.MailQueuePriority queuePriority = MailQueuePriority.Standard) { throw new System.NotImplementedException(); }
}
