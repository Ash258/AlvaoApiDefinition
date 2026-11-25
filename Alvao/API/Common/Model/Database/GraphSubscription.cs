using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Microsoft Graph subscriptions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html"/>
[Table("dbo.GraphSubscription")]
public class GraphSubscription {
    /// <summary>
    /// Indicates the type of change in the subscribed resource that raises a change notification. The supported values
    /// are: created, updated, deleted.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_ChangeType"/>
    /// <remarks>Column <c>ChangeType</c>: nvarchar(25), null.</remarks>
    public virtual string ChangeType { get; set; }
    /// <summary>
    /// Checks that the change notification came from the service by comparing the value of the clientState property
    /// sent with the subscription with the value of the clientState property received with each change notification.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_ClientState"/>
    /// <remarks>Column <c>ClientState</c>: nvarchar(128), not null.</remarks>
    public virtual string ClientState { get; set; }
    /// <summary>
    /// Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of
    /// time from subscription creation that varies for the resource subscribed to. Any value under 45 minutes after the
    /// time of the request is automatically set to 45 minutes after the request time.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_ExpirationDateTime"/>
    /// <remarks>Column <c>ExpirationDateTime</c>: datetime, null.</remarks>
    public virtual DateTime? ExpirationDateTime { get; set; }
    /// <summary>Microsoft Graph subscription status ID (GraphSubscriptionStatus.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_GraphSubscriptionStatusId"/>
    /// <remarks>
    /// Column <c>GraphSubscriptionStatusId</c>: int, not null. References <see cref="GraphSubscriptionStatus"/>.
    /// </remarks>
    public virtual int GraphSubscriptionStatusId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Date of the last status change.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_LastStatusChangeDate"/>
    /// <remarks>Column <c>LastStatusChangeDate</c>: datetime, null.</remarks>
    public virtual DateTime? LastStatusChangeDate { get; set; }
    /// <summary>
    /// Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by
    /// notificationUrl, supports. The possible values are: v1_0, v1_1, v1_2, v1_3.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_LastSupportedTlsVersion"/>
    /// <remarks>Column <c>LastSupportedTlsVersion</c>: nvarchar(10), null.</remarks>
    public virtual string LastSupportedTlsVersion { get; set; }
    /// <summary>
    /// The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved,
    /// reauthorizationRequired, and missed notifications.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_LifecycleNotificationUrl"/>
    /// <remarks>Column <c>LifecycleNotificationUrl</c>: nvarchar(2048), null.</remarks>
    public virtual string LifecycleNotificationUrl { get; set; }
    /// <summary>OData query options for specifying value for the targeting resource.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_NotificationQueryOptions"/>
    /// <remarks>Column <c>NotificationQueryOptions</c>: nvarchar(255), null.</remarks>
    public virtual string NotificationQueryOptions { get; set; }
    /// <summary>
    /// The URL of the endpoint that receives the change notifications. This URL must make use of the HTTPS protocol.
    /// </summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_NotificationUrl"/>
    /// <remarks>Column <c>NotificationUrl</c>: nvarchar(2048), null.</remarks>
    public virtual string NotificationUrl { get; set; }
    /// <summary>Resource that is monitored for changes.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_Resource"/>
    /// <remarks>Column <c>Resource</c>: nvarchar(100), not null.</remarks>
    public virtual string Resource { get; set; }
    /// <summary>Unique identifier for the subscription.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscription.html#Alvao_API_Common_Model_Database_GraphSubscription_SubscriptionId"/>
    /// <remarks>Column <c>SubscriptionId</c>: nvarchar(50), not null.</remarks>
    public virtual string SubscriptionId { get; set; }
}
