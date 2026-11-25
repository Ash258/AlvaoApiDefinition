using Microsoft.Kiota.Abstractions.Authentication;

namespace Alvao.API.Common.Model.Article;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html"/>
public class ArticleSearchSetting {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_AuthenticationProvider"/>
    public IAuthenticationProvider AuthenticationProvider { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_IncludeSubordinate"/>
    public bool IncludeSubordinate { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_IsSemanticSearch"/>
    public bool IsSemanticSearch { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_PersonId"/>
    public int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_SearchInRoot"/>
    public bool SearchInRoot { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_SearchText"/>
    public string SearchText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_SectionId"/>
    public int? SectionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_SimilarityPercent"/>
    public double? SimilarityPercent { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Article.ArticleSearchSetting.html#Alvao_API_Common_Model_Article_ArticleSearchSetting_TopCount"/>
    public int TopCount { get; set; }
}
