using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Feedback responses</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html"/>
[Table("dbo.FeedbackResponse")]
public class FeedbackResponse {
    /// <summary>Form responses</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_AnswersJson"/>
    /// <remarks>Column <c>AnswersJson</c>: nvarchar(max), not null.</remarks>
    public virtual string AnswersJson { get; set; }
    /// <summary>Feedback form GUID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_FormGuid"/>
    /// <remarks>Column <c>FormGuid</c>: uniqueidentifier, not null.</remarks>
    public virtual Guid FormGuid { get; set; }
    /// <summary>Feedback response ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Person ID that filled in the form</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Date when the form was submitted</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.FeedbackResponse.html#Alvao_API_Common_Model_Database_FeedbackResponse_SubmittedDate"/>
    /// <remarks>Column <c>SubmittedDate</c>: datetime, not null.</remarks>
    public virtual DateTime SubmittedDate { get; set; }
}
