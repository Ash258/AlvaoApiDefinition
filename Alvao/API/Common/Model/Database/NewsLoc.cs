using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html"/>
[Table("dbo.NewsLoc")]
public class NewsLoc {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_HtmlText"/>
    public virtual string HtmlText { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Id"/>
    [Key]
    public virtual int Id { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_LocaleId"/>
    public virtual int LocaleId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_NewsId"/>
    public virtual int NewsId { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Subject"/>
    public virtual string Subject { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.NewsLoc.html#Alvao_API_Common_Model_Database_NewsLoc_Text"/>
    public virtual string Text { get; set; }

}
