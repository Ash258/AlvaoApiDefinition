using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html"/>
[Table("dbo.NewsLoc")]
public class NewsLoc {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_HtmlText"/>
    /// <remarks>Column <c>HtmlText</c>: nvarchar(max), null.</remarks>
    public virtual string HtmlText { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, not null. References <see cref="tLocale"/>.</remarks>
    public virtual int LocaleId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_NewsId"/>
    /// <remarks>Column <c>NewsId</c>: int, not null. References <see cref="News"/>.</remarks>
    public virtual int NewsId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Subject"/>
    /// <remarks>Column <c>Subject</c>: nvarchar(max), not null.</remarks>
    public virtual string Subject { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Text"/>
    /// <remarks>Column <c>Text</c>: nvarchar(max), null.</remarks>
    public virtual string Text { get; set; }
}
