using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Link between service and MS Graph subscription record.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html"/>
[Table("dbo.GraphSubscriptionSectionSettings")]
public class GraphSubscriptionSectionSettings {
    /// <summary>Client state for verifying change notifications.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_ClientState"/>
    public virtual string ClientState { get; set; }
    /// <summary>Subscription ID (GraphSubscription.Id).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_GraphSubscriptionId"/>
    public virtual int? GraphSubscriptionId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Service ID (tHdSection.iHdSectionId).</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.GraphSubscriptionSectionSettings.html#Alvao_API_Common_Model_Database_GraphSubscriptionSectionSettings_SectionId"/>
    public virtual int SectionId { get; set; }
}
