using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html"/>
[Table("dbo.ArticleLoc")]
public class ArticleLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Annotation"/>
    public virtual string Annotation { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_ArticleId"/>
    public virtual int ArticleId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_HtmlText"/>
    public virtual string HtmlText { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Id"/>
    [Key]
    public virtual int Id { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Name"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ArticleLoc.html#Alvao_API_Common_Model_Database_ArticleLoc_Text"/>
    public virtual string Text { get; set; }

}
