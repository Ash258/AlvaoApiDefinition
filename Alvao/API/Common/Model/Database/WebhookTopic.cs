using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Webhook topics
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_WebhookTopic.htm"/>
[TableAttribute("dbo.WebhookTopic")]
public class WebhookTopic
{
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebhookTopic_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Webhook topic name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_WebhookTopic_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_WebhookTopic__ctor.htm"/>
    public WebhookTopic() { }
}
