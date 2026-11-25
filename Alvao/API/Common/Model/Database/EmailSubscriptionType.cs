using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Email subscription type</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscriptionType.html"/>
[Table("dbo.EmailSubscriptionType")]
public class EmailSubscriptionType {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscriptionType.html#Alvao_API_Common_Model_Database_EmailSubscriptionType_Id"/>
    [ExplicitKey]
    public virtual int Id { get; set; }
    /// <summary>Email subscription type name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscriptionType.html#Alvao_API_Common_Model_Database_EmailSubscriptionType_Name"/>
    public virtual string Name { get; set; }
}
