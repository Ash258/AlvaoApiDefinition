using System.Text.Json.Serialization;

namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUrl.html"/>
public class FeedbackFormUrl {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUrl.html#Alvao_API_Common_Model_Feedback_FeedbackFormUrl_Pattern"/>
    [JsonPropertyName("pattern")]
    public string Pattern { get; set; }
}
