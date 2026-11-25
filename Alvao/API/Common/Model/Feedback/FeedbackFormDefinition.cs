using System.Text.Json.Serialization;

namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html"/>
public class FeedbackFormDefinition {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_Audience"/>
    [JsonPropertyName("audience")]
    public FeedbackFormAudience Audience { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_FromAlvaoVersion"/>
    [JsonPropertyName("fromAlvaoVersion")]
    public string FromAlvaoVersion { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_FromUtc"/>
    [JsonPropertyName("fromUtc")]
    public DateTime FromUtc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_Id"/>
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_ToUtc"/>
    [JsonPropertyName("toUtc")]
    public DateTime ToUtc { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_Ui"/>
    [JsonPropertyName("ui")]
    public FeedbackFormUi Ui { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormDefinition.html#Alvao_API_Common_Model_Feedback_FeedbackFormDefinition_Url"/>
    [JsonPropertyName("url")]
    public FeedbackFormUrl Url { get; set; }
}
