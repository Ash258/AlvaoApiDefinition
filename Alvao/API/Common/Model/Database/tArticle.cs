using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Article in Knowledge Base.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tArticle.htm"/>
[TableAttribute("dbo.tArticle")]
public class tArticle
{
    public virtual DateTime? dArticleCreated { get; set; }
    public virtual DateTime? dArticleModified { get; set; }
    public virtual string HtmlArticle { get; set; }
    public virtual byte[] HtmlArticleBinary { get; set; }
    public virtual string HtmlArticleBinaryExt { get; set; }
    [KeyAttribute]
    public virtual int iArticleId { get; set; }
    public virtual int? liArticleAuthorPersonId { get; set; }
    public virtual string mArticle { get; set; }
    public virtual string mArticleAnnotation { get; set; }
    public virtual int? ModifierPersonId { get; set; }
    public virtual int? Order { get; set; }
    public virtual bool? Published { get; set; }
    public virtual DateTime? Removed { get; set; }
    public virtual string sArticle { get; set; }
    /// <summary>Contains embedding vector calculated from the article text.</summary>
    public virtual string SimilarityVector { get; set; }

    public tArticle() { }
}
