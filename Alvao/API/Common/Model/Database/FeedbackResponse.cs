using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Feedback responses</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html"/>
[Table("dbo.FeedbackResponse")]
public class FeedbackResponse {
    /// <summary>Form responses</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_AnswersJson"/>
    public virtual string AnswersJson { get; set; }
    /// <summary>Feedback form GUID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_FormGuid"/>
    public virtual Guid FormGuid { get; set; }
    /// <summary>Feedback response ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Person ID that filled in the form</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Date when the form was submitted</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_SubmittedDate"/>
    public virtual DateTime SubmittedDate { get; set; }
}
