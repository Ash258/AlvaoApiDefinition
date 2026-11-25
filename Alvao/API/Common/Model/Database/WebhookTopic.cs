using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Webhook topics</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html"/>
[Table("dbo.WebhookTopic")]
public class WebhookTopic {
    /// <summary>Webhook topic name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html#Alvao_API_Common_Model_Database_WebhookTopic_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.WebhookTopic.html#Alvao_API_Common_Model_Database_WebhookTopic_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
