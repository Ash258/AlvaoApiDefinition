using System.Globalization;
using System.Net;
using Alvao.API.AI.Model;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html"/>
public class AIClient {
    /// <summary>Get or set the culture used for the AI responses.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_Culture"/>
    public CultureInfo Culture { get; set; }
    /// <summary>Get the last error response from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_LastErrorResponse"/>
    public string LastErrorResponse { get; }
    /// <summary>Get the last status code from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_LastStatusCode"/>
    public HttpStatusCode LastStatusCode { get; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetAzureResponse_System_String_System_Object_"/>
    public HttpResponseMessage GetAzureResponse(string uri, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetAzureResponseAsync_System_String_System_Object_"/>
    public Task<HttpResponseMessage> GetAzureResponseAsync(string uri, object data) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetChoicesText_System_Collections_Generic_IEnumerable_Alvao_API_AI_Model_ChatChoiceResponse__"/>
    public static string GetChoicesText(IEnumerable<ChatChoiceResponse> choices) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetChoicesText_System_Collections_Generic_IEnumerable_Alvao_API_AI_Model_ChoiceResponse__"/>
    public static string GetChoicesText(IEnumerable<ChoiceResponse> choices) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetEmbeddingResponse_System_String_"/>
    public EmbeddingCreateResponse GetEmbeddingResponse(string text) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetKeywords_System_String_System_String_"/>
    public string GetKeywords(string model, string text) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetResponseText_Alvao_API_AI_Model_ChatCompletionCreateResponse_"/>
    public static string GetResponseText(ChatCompletionCreateResponse response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetResponseText_Alvao_API_AI_Model_CompletionCreateResponse_"/>
    public string GetResponseText(CompletionCreateResponse response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetResult__1_System_Net_Http_HttpResponseMessage_"/>
    public T GetResult<T>(HttpResponseMessage response) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetSolutionProposal_System_String_System_String_"/>
    public string GetSolutionProposal(string subject, string body) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetSummaryForShortText_System_String_"/>
    public string GetSummaryForShortText(string text) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.AI.AIClient.html#Alvao_API_AI_AIClient_GetSummaryFromChatCompletions_System_String_System_String_"/>
    public string GetSummaryFromChatCompletions(string model, string text) { throw new NotImplementedException(); }
}
