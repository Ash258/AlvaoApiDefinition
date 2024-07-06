using System.Globalization;
using System.Net;

namespace Alvao.API.AI;

public class AIClient
{
    /// <summary>Get or set the culture used for the AI responses.</summary>
    public CultureInfo Culture { get; set; }
    /// <summary>Get the last error response from the Azure API.</summary>
    public string LastErrorResponse { get; }
    /// <summary>Get the last status code from the Azure API.</summary>
    public HttpStatusCode LastStatusCode { get; }

    /// <summary>Create a new instance of the AI client.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_AI_AIClient__ctor.htm"/>
    public AIClient() { }

    /// <param name="uri"> </param>
    /// <param name="data"> </param>
    public HttpResponseMessage GetAzureResponse(
        string uri,
        Object data
    )
    { throw new System.NotImplementedException(); }

    /// <param name="text"> </param>
    public EmbeddingCreateResponse GetEmbeddingResponse(
        string text
    )
    { throw new System.NotImplementedException(); }

    /// <param name="subject"> </param>
    /// <param name="body"> </param>
    public string GetSolutionProposal(
        string subject,
        string body
    )
    { throw new System.NotImplementedException(); }

    /// <param name="text"> </param>
    public string GetSummaryForShortText(
        string text
    )
    { throw new System.NotImplementedException(); }

    /// <param name="model"> </param>
    /// <param name="text"> </param>
    public string GetSummaryFromChatCompletions(
        string model,
        string text
    )
    { throw new System.NotImplementedException(); }
}
