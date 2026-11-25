using System.Text.Json.Serialization;

namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html"/>
public class FeedbackFormField {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html#Alvao_API_Common_Model_Feedback_FeedbackFormField_Label"/>
    [JsonPropertyName("label")]
    public string Label { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html#Alvao_API_Common_Model_Feedback_FeedbackFormField_Name"/>
    [JsonPropertyName("name")]
    public string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html#Alvao_API_Common_Model_Feedback_FeedbackFormField_Options"/>
    [JsonPropertyName("options")]
    public List<string> Options { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html#Alvao_API_Common_Model_Feedback_FeedbackFormField_Required"/>
    [JsonPropertyName("required")]
    public bool Required { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormField.html#Alvao_API_Common_Model_Feedback_FeedbackFormField_Type"/>
    [JsonPropertyName("type")]
    public string Type { get; set; }
}
