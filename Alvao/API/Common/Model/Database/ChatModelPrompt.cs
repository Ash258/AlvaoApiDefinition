using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Prompt texts for specific chat completion models</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModelPrompt.html"/>
[Table("dbo.ChatModelPrompt")]
public class ChatModelPrompt {
    /// <summary>Chat model ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModelPrompt.html#Alvao_API_Common_Model_Database_ChatModelPrompt_ChatModelId"/>
    /// <remarks>Column <c>ChatModelId</c>: int, not null. References <see cref="ChatModel"/>.</remarks>
    [ExplicitKey]
    public virtual int ChatModelId { get; set; }
    /// <summary>
    /// Prompt ID: 1 - Ticket Summary 2 - Ticket Keywords 3 - Ticket Solution Proposal 4 - Ticket Description 5 -
    /// Chatbot
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModelPrompt.html#Alvao_API_Common_Model_Database_ChatModelPrompt_PromptId"/>
    /// <remarks>Column <c>PromptId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int PromptId { get; set; }
    /// <summary>Prompt text</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ChatModelPrompt.html#Alvao_API_Common_Model_Database_ChatModelPrompt_Text"/>
    /// <remarks>Column <c>Text</c>: nvarchar(max), not null.</remarks>
    public virtual string Text { get; set; }
}
