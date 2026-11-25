using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Article in Knowledge Base.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html"/>
[Table("dbo.tArticle")]
public class tArticle {
    /// <summary>ID of an article from external services</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_ExternalArticleId"/>
    /// <remarks>Column <c>ExternalArticleId</c>: nvarchar(255), null.</remarks>
    public virtual string ExternalArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticle"/>
    /// <remarks>Column <c>HtmlArticle</c>: nvarchar(max), null.</remarks>
    public virtual string HtmlArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinary"/>
    /// <remarks>Column <c>HtmlArticleBinary</c>: varbinary, null.</remarks>
    public virtual byte[] HtmlArticleBinary { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_HtmlArticleBinaryExt"/>
    /// <remarks>Column <c>HtmlArticleBinaryExt</c>: nvarchar(10), null.</remarks>
    public virtual string HtmlArticleBinaryExt { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, null. References <see cref="tLocale"/>.</remarks>
    public virtual int? LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_ModifierPersonId"/>
    /// <remarks>Column <c>ModifierPersonId</c>: int, null.</remarks>
    public virtual int? ModifierPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Order"/>
    /// <remarks>Column <c>Order</c>: int, null.</remarks>
    public virtual int? Order { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Published"/>
    /// <remarks>Column <c>Published</c>: bit, null.</remarks>
    public virtual bool? Published { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_Removed"/>
    /// <remarks>Column <c>Removed</c>: datetime, null.</remarks>
    public virtual DateTime? Removed { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_dArticleCreated"/>
    /// <remarks>Column <c>dArticleCreated</c>: datetime, null.</remarks>
    public virtual DateTime? dArticleCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_dArticleModified"/>
    /// <remarks>Column <c>dArticleModified</c>: datetime, null.</remarks>
    public virtual DateTime? dArticleModified { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_iArticleId"/>
    /// <remarks>Column <c>iArticleId</c>: int, not null.</remarks>
    [Key]
    public virtual int iArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_liArticleAuthorPersonId"/>
    /// <remarks>Column <c>liArticleAuthorPersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? liArticleAuthorPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_mArticle"/>
    /// <remarks>Column <c>mArticle</c>: nvarchar(max), null.</remarks>
    public virtual string mArticle { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_mArticleAnnotation"/>
    /// <remarks>Column <c>mArticleAnnotation</c>: nvarchar(max), null.</remarks>
    public virtual string mArticleAnnotation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tArticle.html#Alvao_API_Common_Model_Database_tArticle_sArticle"/>
    /// <remarks>Column <c>sArticle</c>: nvarchar(1024), null.</remarks>
    public virtual string sArticle { get; set; }
}
