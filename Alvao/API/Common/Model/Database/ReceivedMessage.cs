using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Table for temporary storage of read messages for custom actions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ReceivedMessage.htm"/>
[TableAttribute("dbo.ReceivedMessage")]
public class ReceivedMessage
{
    /// <summary>Date and time of message storage in the database.</summary>
    public virtual DateTime Created { get; set; }
    /// <summary>Message in EML format.</summary>
    public virtual byte[] EmlMail { get; set; }
    /// <summary>Message ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }

    public ReceivedMessage() { }
}
