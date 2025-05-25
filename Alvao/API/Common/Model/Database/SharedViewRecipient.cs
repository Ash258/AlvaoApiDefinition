using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table of users and groups which the view is shared with.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html"/>
[Table("dbo.SharedViewRecipient")]
public class SharedViewRecipient {
    /// <summary>A person who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_PersonId"/>
    public virtual int? PersonId { get; set; }
    /// <summary>The group of persons who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_RoleId"/>
    public virtual int? RoleId { get; set; }
    /// <summary>A foreign key to the SharedView table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_SharedViewId"/>
    public virtual int SharedViewId { get; set; }
    /// <summary>Record identifier.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedViewRecipient.html#Alvao_API_Common_Model_Database_SharedViewRecipient_id"/>
    [Key]
    public virtual int id { get; set; }
}
