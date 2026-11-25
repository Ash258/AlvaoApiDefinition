using System.Net;
using Alvao.API.AI.Model;

namespace Alvao.API.AI.Infrastructure;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html"/>
[Obsolete("Use FoundryAIClient instead. This class is retained for backward compatibility with custom applications.")]
public class AIClient {
    /// <summary>Get the last error response from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_LastErrorResponse"/>
    public string LastErrorResponse { get; }
    /// <summary>Get the last status code from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_LastStatusCode"/>
    public HttpStatusCode LastStatusCode { get; }

    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetAzureResponse_System_String_System_Object_"/>
    public HttpResponseMessage GetAzureResponse(string uri, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetAzureResponseAsync_System_String_System_Object_System_Threading_CancellationToken_"/>
    public Task<HttpResponseMessage> GetAzureResponseAsync(string uri, object data, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetChoicesText_System_Collections_Generic_IEnumerable_Alvao_API_AI_Model_ChatChoiceResponse__"/>
    public static string GetChoicesText(IEnumerable<ChatChoiceResponse> choices) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetChoicesText_System_Collections_Generic_IEnumerable_Alvao_API_AI_Model_ChoiceResponse__"/>
    public static string GetChoicesText(IEnumerable<ChoiceResponse> choices) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetEmbeddingResponse_System_String_System_Object_"/>
    public EmbeddingCreateResponse GetEmbeddingResponse(string model, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetKeywords_System_String_System_Object_"/>
    public (string textResponse, UsageResponse usageResponse) GetKeywords(string model, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetResponseText_Alvao_API_AI_Model_ChatCompletionCreateResponse_"/>
    public static string GetResponseText(ChatCompletionCreateResponse response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetResponseText_Alvao_API_AI_Model_CompletionCreateResponse_"/>
    public string GetResponseText(CompletionCreateResponse response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetResult__1_System_Net_Http_HttpResponseMessage_"/>
    public T GetResult<T>(HttpResponseMessage response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetSolutionProposal_System_String_System_Object_"/>
    public (string textResponse, UsageResponse usageResponse) GetSolutionProposal(string model, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetSummaryForShortText_System_Object_"/>
    public (string textResponse, UsageResponse usageResponse) GetSummaryForShortText(object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.AI.Infrastructure.AIClient.html#Alvao_API_AI_Infrastructure_AIClient_GetSummaryFromChatCompletions_System_String_System_Object_"/>
    public (string textResponse, UsageResponse usageResponse) GetSummaryFromChatCompletions(string model, object data) { throw new NotImplementedException(); }
}
