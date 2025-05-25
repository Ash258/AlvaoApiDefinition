using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Assigning articles from the knowledge base to services.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleHdSection.html"/>
[Table("dbo.ArticleHdSection")]
public class ArticleHdSection {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleHdSection.html#Alvao_API_Common_Model_Database_ArticleHdSection_ArticleId"/>
    public virtual int? ArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleHdSection.html#Alvao_API_Common_Model_Database_ArticleHdSection_SectionId"/>
    public virtual int? SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleHdSection.html#Alvao_API_Common_Model_Database_ArticleHdSection_id"/>
    [Key]
    public virtual int id { get; set; }
}
