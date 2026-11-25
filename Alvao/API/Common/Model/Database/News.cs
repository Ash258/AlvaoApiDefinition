using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>News.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html"/>
[Table("dbo.News")]
public class News {
    /// <summary>User who created the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_CreatedByPersonId"/>
    /// <remarks>Column <c>CreatedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Creation date of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_CreatedDate"/>
    /// <remarks>Column <c>CreatedDate</c>: datetime, not null.</remarks>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>HTML text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_HtmlText"/>
    /// <remarks>Column <c>HtmlText</c>: nvarchar(max), null.</remarks>
    public virtual string HtmlText { get; set; }
    /// <summary>1 = important news post. Alerts for important unread news are displayed on every WA page.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Important"/>
    /// <remarks>Column <c>Important</c>: bit, not null.</remarks>
    public virtual bool Important { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_IsSample"/>
    /// <remarks>Column <c>IsSample</c>: bit, not null.</remarks>
    public virtual bool IsSample { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_LocaleId"/>
    /// <remarks>Column <c>LocaleId</c>: int, null. References <see cref="tLocale"/>.</remarks>
    public virtual int? LocaleId { get; set; }
    /// <summary>News post display order.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Order"/>
    /// <remarks>Column <c>Order</c>: int, not null.</remarks>
    public virtual int Order { get; set; }
    /// <summary>
    /// 1 = news post displayed to users of all tenants. This option can only be enabled in the ALVAO provider's
    /// database.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_PublishToTenants"/>
    /// <remarks>Column <c>PublishToTenants</c>: bit, not null.</remarks>
    public virtual bool PublishToTenants { get; set; }
    /// <summary>Date and time of the last sending of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_SentDate"/>
    /// <remarks>Column <c>SentDate</c>: datetime, null.</remarks>
    public virtual DateTime? SentDate { get; set; }
    /// <summary>Date until which the news post shall be displayed.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_ShowEndDate"/>
    /// <remarks>Column <c>ShowEndDate</c>: datetime, null.</remarks>
    public virtual DateTime? ShowEndDate { get; set; }
    /// <summary>1 = also show to requesters of selected services; 0 = show only to members of service teams</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_ShowToRequesters"/>
    /// <remarks>Column <c>ShowToRequesters</c>: bit, not null.</remarks>
    public virtual bool ShowToRequesters { get; set; }
    /// <summary>Name of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Subject"/>
    /// <remarks>Column <c>Subject</c>: nvarchar(max), not null.</remarks>
    public virtual string Subject { get; set; }
    /// <summary>Text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_Text"/>
    /// <remarks>Column <c>Text</c>: nvarchar(max), null.</remarks>
    public virtual string Text { get; set; }
    /// <summary>Primary table key.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.News.html#Alvao_API_Common_Model_Database_News_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
