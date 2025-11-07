using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Feedback on knowledge.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KnowledgeFeedback.html"/>
[Table("dbo.KnowledgeFeedback")]
public class KnowledgeFeedback {
    /// <summary>Knowledge (tArticle.iArticleId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KnowledgeFeedback.html#Alvao_API_Common_Model_Database_KnowledgeFeedback_KnowledgeId"/>
    [ExplicitKey]
    public virtual int KnowledgeId { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KnowledgeFeedback.html#Alvao_API_Common_Model_Database_KnowledgeFeedback_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Rating of knowledge.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.KnowledgeFeedback.html#Alvao_API_Common_Model_Database_KnowledgeFeedback_Rating"/>
    public virtual bool? Rating { get; set; }
}
