using System.Net.Mail;

namespace Alvao.API.Common;

/// <summary>
/// Facade class grouping mail methods.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Email.htm"/>
public static class Email
{
    public enum MailQueuePriority
    {
        Low = 5_000,
        Standard = 10_000,
        High = 15_000,
    }



    /// <summary>Queues mail message by inserting it into database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Email_Queue.htm"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    public static void Queue(
        MailMessage message,
        Email.MailQueuePriority queuePriority = Email.MailQueuePriority.Standard
    )
    { throw new System.NotImplementedException(); }

    /// <summary>Queues mail message by inserting it into database. QueueMailMessage is deprecated, please use Queue instead.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Email_QueueMailMessage.htm"/>
    /// <param name="message">Message to queue</param>
    /// <param name="queuePriority">Priority of this message in sending queue</param>
    [ObsoleteAttribute("QueueMailMessage is deprecated, please use Queue instead.")]
    public static void QueueMailMessage(
        MailMessage message,
        Email.MailQueuePriority queuePriority = Email.MailQueuePriority.Standard
    )
    { throw new System.NotImplementedException(); }
}
