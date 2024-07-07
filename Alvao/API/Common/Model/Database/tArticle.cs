using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Article in Knowledge Base.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tArticle.htm"/>
[TableAttribute("dbo.tArticle")]
public class tArticle
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_dArticleCreated.htm"/>
    public virtual DateTime? dArticleCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_dArticleModified.htm"/>
    public virtual DateTime? dArticleModified { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_HtmlArticle.htm"/>
    public virtual string HtmlArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinary.htm"/>
    public virtual byte[] HtmlArticleBinary { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinaryExt.htm"/>
    public virtual string HtmlArticleBinaryExt { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_iArticleId.htm"/>
    [KeyAttribute]
    public virtual int iArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_liArticleAuthorPersonId.htm"/>
    public virtual int? liArticleAuthorPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_mArticle.htm"/>
    public virtual string mArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_mArticleAnnotation.htm"/>
    public virtual string mArticleAnnotation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_ModifierPersonId.htm"/>
    public virtual int? ModifierPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_Order.htm"/>
    public virtual int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_Published.htm"/>
    public virtual bool? Published { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_sArticle.htm"/>
    public virtual string sArticle { get; set; }
    /// <summary>Contains embedding vector calculated from the article text.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tArticle_SimilarityVector.htm"/>
    public virtual string SimilarityVector { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tArticle__ctor.htm"/>
    public tArticle() { }
}
