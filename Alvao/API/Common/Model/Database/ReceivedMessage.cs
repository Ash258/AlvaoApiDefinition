using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table for temporary storage of read messages for custom actions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html"/>
[Table("dbo.ReceivedMessage")]
public class ReceivedMessage {
    /// <summary>Date and time of message storage in the database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_Created"/>
    public virtual DateTime Created { get; set; }
    /// <summary>Message in EML format.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_EmlMail"/>
    public virtual byte[] EmlMail { get; set; }
    /// <summary>Message ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_id"/>
    [Key]
    public virtual int id { get; set; }
}
