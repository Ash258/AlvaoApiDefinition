using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table for temporary storage of read messages for custom actions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html"/>
[Table("dbo.ReceivedMessage")]
public class ReceivedMessage {
    /// <summary>Date and time of message storage in the database.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_Created"/>
    /// <remarks>Column <c>Created</c>: datetime, not null.</remarks>
    public virtual DateTime Created { get; set; }
    /// <summary>Message in EML format.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_EmlMail"/>
    /// <remarks>Column <c>EmlMail</c>: varbinary, not null.</remarks>
    public virtual byte[] EmlMail { get; set; }
    /// <summary>Message ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ReceivedMessage.html#Alvao_API_Common_Model_Database_ReceivedMessage_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
