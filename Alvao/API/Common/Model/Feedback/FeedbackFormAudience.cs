using System.Text.Json.Serialization;

namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormAudience.html"/>
public class FeedbackFormAudience {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormAudience.html#Alvao_API_Common_Model_Feedback_FeedbackFormAudience_OnlyRequester"/>
    [JsonPropertyName("onlyRequester")]
    public int OnlyRequester { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormAudience.html#Alvao_API_Common_Model_Feedback_FeedbackFormAudience_RequiredModules"/>
    [JsonPropertyName("requiredModules")]
    public List<string> RequiredModules { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormAudience.html#Alvao_API_Common_Model_Feedback_FeedbackFormAudience_RoleBehaviorIds"/>
    [JsonPropertyName("roleBehaviorIds")]
    public List<int> RoleBehaviorIds { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackFormAudience.html#Alvao_API_Common_Model_Feedback_FeedbackFormAudience_SolverOnAnyService"/>
    [JsonPropertyName("solverOnAnyService")]
    public int SolverOnAnyService { get; set; }
}
