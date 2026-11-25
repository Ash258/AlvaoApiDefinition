namespace Alvao.API.Common.Model.Feedback;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html"/>
public class FeedbackResponseModel {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html#Alvao_API_Common_Model_Feedback_FeedbackResponseModel_AnswersJson"/>
    public string AnswersJson { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html#Alvao_API_Common_Model_Feedback_FeedbackResponseModel_FormGuid"/>
    public Guid FormGuid { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html#Alvao_API_Common_Model_Feedback_FeedbackResponseModel_Id"/>
    public int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html#Alvao_API_Common_Model_Feedback_FeedbackResponseModel_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Feedback.FeedbackResponseModel.html#Alvao_API_Common_Model_Feedback_FeedbackResponseModel_SubmittedDate"/>
    public DateTime SubmittedDate { get; set; }
}
