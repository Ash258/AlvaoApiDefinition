using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// News.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_News.htm"/>
[TableAttribute("dbo.News")]
public class News
{
    /// <summary>User who created the news post.</summary>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Creation date of the news post.</summary>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>HTML text of the news post.</summary>
    public virtual string HtmlText { get; set; }
    /// <summary>Primary table key.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = important news post. Alerts for important unread news are displayed on every WA page.</summary>
    public virtual bool Important { get; set; }
    /// <summary>News post display order.</summary>
    public virtual int Order { get; set; }
    /// <summary>1 = news post displayed to users of all tenants. This option can only be enabled in the ALVAO provider's database.</summary>
    public virtual bool PublishToTenants { get; set; }
    /// <summary>Date and time of the last sending of the news post.</summary>
    public virtual DateTime? SentDate { get; set; }
    /// <summary>Date until which the news post shall be displayed.</summary>
    public virtual DateTime? ShowEndDate { get; set; }
    /// <summary>1 = also show to requesters of selected services; 0 = show only to members of service teams</summary>
    public virtual bool ShowToRequesters { get; set; }
    /// <summary>Name of the news post.</summary>
    public virtual string Subject { get; set; }
    /// <summary>Text of the news post.</summary>
    public virtual string Text { get; set; }

    public News() { }
}
