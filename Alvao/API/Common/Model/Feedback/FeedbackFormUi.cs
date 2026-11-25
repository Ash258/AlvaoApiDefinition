using System.Text.Json.Serialization;

namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html"/>
public class FeedbackFormUi {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html#Alvao_API_Common_Model_Feedback_FeedbackFormUi_CancelText"/>
    [JsonPropertyName("cancelText")]
    public string CancelText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html#Alvao_API_Common_Model_Feedback_FeedbackFormUi_Description"/>
    [JsonPropertyName("description")]
    public string Description { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html#Alvao_API_Common_Model_Feedback_FeedbackFormUi_Fields"/>
    [JsonPropertyName("fields")]
    public List<FeedbackFormField> Fields { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html#Alvao_API_Common_Model_Feedback_FeedbackFormUi_SubmitText"/>
    [JsonPropertyName("submitText")]
    public string SubmitText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormUi.html#Alvao_API_Common_Model_Feedback_FeedbackFormUi_Title"/>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}
