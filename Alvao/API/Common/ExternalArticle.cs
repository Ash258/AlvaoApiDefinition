using Alvao.API.Common.Model;
using Alvao.API.Common.Model.Article;

namespace Alvao.API.Common;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.ExternalArticle.html"/>
public static class ExternalArticle {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.ExternalArticle.html#Alvao_API_Common_ExternalArticle_Get_System_Int32_"/>
    public static Alvao.API.Common.Model.Database.ExternalArticle Get(int id) { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.ExternalArticle.html#Alvao_API_Common_ExternalArticle_GetAll"/>
    public static IEnumerable<Alvao.API.Common.Model.Database.ExternalArticle> GetAll() { throw new NotImplementedException(); }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.ExternalArticle.html#Alvao_API_Common_ExternalArticle_SearchAsync_Alvao_API_Common_Model_Article_ArticleSearchSetting_System_Threading_CancellationToken_"/>
    public static Task<IEnumerable<ExternalArticleModel>> SearchAsync(ArticleSearchSetting searchSettings, CancellationToken cancellationToken = default) { throw new NotImplementedException(); }
}
