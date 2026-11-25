using Alvao.API.AI.Model;

namespace Alvao.API.AI.Infrastructure.Interfaces;

/// <summary>
/// Async client for sending requests to Azure OpenAI. Implemented by FoundryAIClient; extracted so consumers can be
/// unit tested without depending on the Azure.AI.OpenAI SDK types directly.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClient.html"/>
public interface IAIClient {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClient.html#Alvao_API_AI_Infrastructure_Interfaces_IAIClient_GetChatCompletionAsync_System_String_System_String_System_String_System_Int32_System_Threading_CancellationToken_"/>
    Task<(string textResponse, UsageResponse usage)> GetChatCompletionAsync(string model, string systemMessage, string userMessage, int maxResponseTokenCount, CancellationToken cancellationToken);
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.Interfaces.IAIClient.html#Alvao_API_AI_Infrastructure_Interfaces_IAIClient_GetEmbeddingResponseAsync_System_String_System_String_System_Nullable_System_Int32__System_Threading_CancellationToken_"/>
    Task<EmbeddingCreateResponse> GetEmbeddingResponseAsync(string model, string input, int? dimensions, CancellationToken cancellationToken);
}
