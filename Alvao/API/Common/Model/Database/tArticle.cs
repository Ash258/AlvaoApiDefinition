using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Article in Knowledge Base.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html"/>
[Table("dbo.tArticle")]
public class tArticle {
    /// <summary>ID of an article from external services</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_ExternalArticleId"/>
    public virtual int? ExternalArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticle"/>
    public virtual string HtmlArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinary"/>
    public virtual byte[] HtmlArticleBinary { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinaryExt"/>
    public virtual string HtmlArticleBinaryExt { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_LocaleId"/>
    public virtual int? LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_ModifierPersonId"/>
    public virtual int? ModifierPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Order"/>
    public virtual int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Published"/>
    public virtual bool? Published { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Contains embedding vector calculated from the article text.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_SimilarityVector"/>
    public virtual string SimilarityVector { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_dArticleCreated"/>
    public virtual DateTime? dArticleCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_dArticleModified"/>
    public virtual DateTime? dArticleModified { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_iArticleId"/>
    [Key]
    public virtual int iArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_liArticleAuthorPersonId"/>
    public virtual int? liArticleAuthorPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_mArticle"/>
    public virtual string mArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_mArticleAnnotation"/>
    public virtual string mArticleAnnotation { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_sArticle"/>
    public virtual string sArticle { get; set; }
}
