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
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Webhook topic name</summary>
    public virtual string Name { get; set; }

    public WebhookTopic() { }
}
