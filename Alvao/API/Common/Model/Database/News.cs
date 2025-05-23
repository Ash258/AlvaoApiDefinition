using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>News.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_News.htm"/>
[TableAttribute("dbo.News")]
public class News {
    /// <summary>User who created the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_CreatedByPersonId.htm"/>
    public virtual int CreatedByPersonId { get; set; }
    /// <summary>Creation date of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_CreatedDate.htm"/>
    public virtual DateTime CreatedDate { get; set; }
    /// <summary>HTML text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_HtmlText.htm"/>
    public virtual string HtmlText { get; set; }
    /// <summary>Primary table key.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>1 = important news post. Alerts for important unread news are displayed on every WA page.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_Important.htm"/>
    public virtual bool Important { get; set; }
    /// <summary>News post display order.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_Order.htm"/>
    public virtual int Order { get; set; }
    /// <summary>1 = news post displayed to users of all tenants. This option can only be enabled in the ALVAO provider's database.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_PublishToTenants.htm"/>
    public virtual bool PublishToTenants { get; set; }
    /// <summary>Date and time of the last sending of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_SentDate.htm"/>
    public virtual DateTime? SentDate { get; set; }
    /// <summary>Date until which the news post shall be displayed.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_ShowEndDate.htm"/>
    public virtual DateTime? ShowEndDate { get; set; }
    /// <summary>1 = also show to requesters of selected services; 0 = show only to members of service teams</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_ShowToRequesters.htm"/>
    public virtual bool ShowToRequesters { get; set; }
    /// <summary>Name of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_Subject.htm"/>
    public virtual string Subject { get; set; }
    /// <summary>Text of the news post.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_News_Text.htm"/>
    public virtual string Text { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_News__ctor.htm"/>
    public News() { }
}
