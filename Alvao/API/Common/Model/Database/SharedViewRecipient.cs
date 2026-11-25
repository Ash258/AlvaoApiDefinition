using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table of users and groups which the view is shared with.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html"/>
[Table("dbo.SharedViewRecipient")]
public class SharedViewRecipient {
    /// <summary>A person who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, null. References <see cref="tPerson"/>.</remarks>
    public virtual int? PersonId { get; set; }
    /// <summary>The group of persons who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_RoleId"/>
    /// <remarks>Column <c>RoleId</c>: int, null. References <see cref="tRole"/>.</remarks>
    public virtual int? RoleId { get; set; }
    /// <summary>A foreign key to the SharedView table.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_SharedViewId"/>
    /// <remarks>Column <c>SharedViewId</c>: int, not null. References <see cref="SharedView"/>.</remarks>
    public virtual int SharedViewId { get; set; }
    /// <summary>Record identifier.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
