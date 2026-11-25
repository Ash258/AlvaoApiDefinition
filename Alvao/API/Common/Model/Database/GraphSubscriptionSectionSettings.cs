using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Link between service and MS Graph subscription record.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html"/>
[Table("dbo.GraphSubscriptionSectionSettings")]
public class GraphSubscriptionSectionSettings {
    /// <summary>Client state for verifying change notifications.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_ClientState"/>
    /// <remarks>Column <c>ClientState</c>: nvarchar(128), not null.</remarks>
    public virtual string ClientState { get; set; }
    /// <summary>Subscription ID (GraphSubscription.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_GraphSubscriptionId"/>
    /// <remarks>Column <c>GraphSubscriptionId</c>: int, null. References <see cref="GraphSubscription"/>.</remarks>
    public virtual int? GraphSubscriptionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Service ID (tHdSection.iHdSectionId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_SectionId"/>
    /// <remarks>Column <c>SectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int SectionId { get; set; }
}
