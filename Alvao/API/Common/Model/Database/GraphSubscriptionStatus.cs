using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Microsoft Graph subscription status for change notifications.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionStatus.html"/>
[Table("dbo.GraphSubscriptionStatus")]
public class GraphSubscriptionStatus {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionStatus.GraphSubscriptionStatusId.html#fields"/>
    public enum GraphSubscriptionStatusId {
        Active = 1,
        NewlyActivated = 2,
        ServiceConfigurationChanged = 3,
        ReauthorizationRequired = 4,
        SubscriptionRemoved = 5,
        Missed = 6,
        Expired = 7,
    }

    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionStatus.html#Alvao_API_Common_Model_Database_GraphSubscriptionStatus_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Status name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionStatus.html#Alvao_API_Common_Model_Database_GraphSubscriptionStatus_Name"/>
    public virtual string Name { get; set; }
}
