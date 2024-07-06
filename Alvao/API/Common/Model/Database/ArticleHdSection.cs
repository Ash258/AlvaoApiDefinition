using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Assigning articles from the knowledge base to services.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ArticleHdSection.htm"/>
[TableAttribute("dbo.ArticleHdSection")]
public class ArticleHdSection
{
    public virtual int? ArticleId { get; set; }
    [KeyAttribute]
    public virtual int id { get; set; }
    public virtual int? SectionId { get; set; }

    public ArticleHdSection() { }
}
