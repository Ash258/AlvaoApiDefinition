using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Email subscriptions</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html"/>
[Table("dbo.EmailSubscription")]
public class EmailSubscription {
    /// <summary>Email if it was inserted without user</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_Email"/>
    public virtual string Email { get; set; }
    /// <summary>Email subscription (EmailSubscriptionType.Id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_EmailSubscriptionTypeId"/>
    public virtual int EmailSubscriptionTypeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>Role (tRole.tRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_RoleId"/>
    public virtual int? RoleId { get; set; }
}
