using Alvao.API.AI.Infrastructure.Interfaces;
using Alvao.API.AI.Model;

namespace Alvao.API.AI.Infrastructure;

/// <summary>Async client for sending requests to Azure OpenAI using the official Azure.AI.OpenAI SDK.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.FoundryAIClient.html"/>
public class FoundryAIClient : IAIClient {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.FoundryAIClient.html#Alvao_API_AI_Infrastructure_FoundryAIClient_GetChatCompletionAsync_System_String_System_String_System_String_System_Int32_System_Threading_CancellationToken_"/>
    public Task<(string textResponse, UsageResponse usage)> GetChatCompletionAsync(string model, string systemMessage, string userMessage, int maxResponseTokenCount, CancellationToken cancellationToken) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.FoundryAIClient.html#Alvao_API_AI_Infrastructure_FoundryAIClient_GetEmbeddingResponseAsync_System_String_System_String_System_Nullable_System_Int32__System_Threading_CancellationToken_"/>
    public Task<EmbeddingCreateResponse> GetEmbeddingResponseAsync(string model, string input, int? dimensions, CancellationToken cancellationToken) { throw new NotImplementedException(); }
}
