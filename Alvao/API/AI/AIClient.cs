using System.Globalization;
using System.Net;

namespace Alvao.API.AI;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_AI_AIClient.htm"/>
public class AIClient
{
    /// <summary>Get or set the culture used for the AI responses.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_AIClient_Culture.htm"/>
    public CultureInfo Culture { get; set; }
    /// <summary>Get the last error response from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_AIClient_LastErrorResponse.htm"/>
    public string LastErrorResponse { get; }
    /// <summary>Get the last status code from the Azure API.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_AI_AIClient_LastStatusCode.htm"/>
    public HttpStatusCode LastStatusCode { get; }

    /// <summary>Create a new instance of the AI client.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient__ctor.htm"/>
    public AIClient() { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient_GetAzureResponse.htm"/>
    ///
    /// <param name="uri"> </param>
    /// <param name="data"> </param>
    public HttpResponseMessage GetAzureResponse(
        string uri,
        Object data
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient_GetEmbeddingResponse.htm"/>
    ///
    /// <param name="text"> </param>
    public EmbeddingCreateResponse GetEmbeddingResponse(
        string text
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient_GetSolutionProposal.htm"/>
    ///
    /// <param name="subject"> </param>
    /// <param name="body"> </param>
    public string GetSolutionProposal(
        string subject,
        string body
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient_GetSummaryForShortText.htm"/>
    ///
    /// <param name="text"> </param>
    public string GetSummaryForShortText(
        string text
    )
    { throw new System.NotImplementedException(); }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient_GetSummaryFromChatCompletions.htm"/>
    ///
    /// <param name="model"> </param>
    /// <param name="text"> </param>
    public string GetSummaryFromChatCompletions(
        string model,
        string text
    )
    { throw new System.NotImplementedException(); }
}
