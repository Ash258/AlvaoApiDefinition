using System.Globalization;
using System.Net;

namespace Alvao.API.AI;

public class AIClient
{
    public CultureInfo Culture { get; set; }
    public string LastErrorResponse { get; }
    public HttpStatusCode LastStatusCode { get; }
}
