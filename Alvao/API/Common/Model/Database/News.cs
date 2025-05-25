using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>News.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html"/>
[Table("dbo.News")]
public class News {
    /// <summary>User who created the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_CreatedByPersonId"/>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Creation date of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_CreatedDate"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>HTML text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_HtmlText"/>
    public virtual string HtmlText { get; set; }
    /// <summary>1 = important news post. Alerts for important unread news are displayed on every WA page.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Important"/>
    public virtual bool Important { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_LocaleId"/>
    public virtual int? LocaleId { get; set; }
    /// <summary>News post display order.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Order"/>
    public virtual int Order { get; set; }
    /// <summary>1 = news post displayed to users of all tenants. This option can only be enabled in the ALVAO provider's database.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_PublishToTenants"/>
    public virtual bool PublishToTenants { get; set; }
    /// <summary>Date and time of the last sending of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_SentDate"/>
    public virtual DateTime? SentDate { get; set; }
    /// <summary>Date until which the news post shall be displayed.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_ShowEndDate"/>
    public virtual DateTime? ShowEndDate { get; set; }
    /// <summary>1 = also show to requesters of selected services; 0 = show only to members of service teams</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_ShowToRequesters"/>
    public virtual bool ShowToRequesters { get; set; }
    /// <summary>Name of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Subject"/>
    public virtual string Subject { get; set; }
    /// <summary>Text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Text"/>
    public virtual string Text { get; set; }
    /// <summary>Primary table key.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_id"/>
    [Key]
    public virtual int id { get; set; }
}
