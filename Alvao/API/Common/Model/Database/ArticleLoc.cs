using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html"/>
[Table("dbo.ArticleLoc")]
public class ArticleLoc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Annotation"/>
    /// <remarks>Column <c>Annotation</c>: nvarchar(max), null.</remarks>
    public virtual string Annotation { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_ArticleId"/>
    /// <remarks>Column <c>ArticleId</c>: int, not null. References <see cref="tArticle"/>.</remarks>
    public virtual int ArticleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_HtmlText"/>
    /// <remarks>Column <c>HtmlText</c>: nvarchar(max), null.</remarks>
    public virtual string HtmlText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null. References <see cref="tLocale"/>.</remarks>
    public virtual int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(1024), null.</remarks>
    public virtual string Name { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Text"/>
    /// <remarks>Column <c>Text</c>: nvarchar(max), null.</remarks>
    public virtual string Text { get; set; }
}
