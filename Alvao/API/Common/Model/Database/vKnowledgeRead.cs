using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Knowledge that a user can read in services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKnowledgeRead.html"/>
[Table("dbo.vKnowledgeRead")]
public class vKnowledgeRead {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKnowledgeRead.html#Alvao_API_Common_Model_Database_vKnowledgeRead_ArticleId"/>
    public virtual int? ArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKnowledgeRead.html#Alvao_API_Common_Model_Database_vKnowledgeRead_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vKnowledgeRead.html#Alvao_API_Common_Model_Database_vKnowledgeRead_SectionId"/>
    public virtual int? SectionId { get; set; }
}
