using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Webhook topics</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html"/>
[Table("dbo.WebhookTopic")]
public class WebhookTopic {
    /// <summary>Webhook topic name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html#Alvao_API_Common_Model_Database_WebhookTopic_Name"/>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html#Alvao_API_Common_Model_Database_WebhookTopic_id"/>
    [Key]
    public virtual int id { get; set; }
}
