using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Email subscriptions</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html"/>
[Table("dbo.EmailSubscription")]
public class EmailSubscription {
    /// <summary>Email if it was inserted without user</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_Email"/>
    /// <remarks>Column <c>Email</c>: nvarchar(max), null.</remarks>
    public virtual string Email { get; set; }
    /// <summary>Email subscription (EmailSubscriptionType.Id)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_EmailSubscriptionTypeId"/>
    /// <remarks>
    /// Column <c>EmailSubscriptionTypeId</c>: int, not null. References <see cref="EmailSubscriptionType"/>.
    /// </remarks>
    public virtual int EmailSubscriptionTypeId { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_Id"/>
    /// <remarks>Column <c>Id</c>: int, not null.</remarks>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Person (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>Role (tRole.tRoleId)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.EmailSubscription.html#Alvao_API_Common_Model_Database_EmailSubscription_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? RoleId { get; set; }
}
