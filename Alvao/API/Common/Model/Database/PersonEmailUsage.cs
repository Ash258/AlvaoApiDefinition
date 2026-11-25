using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Use of an email address for sending the message by a specific user.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html"/>
[Table("dbo.PersonEmailUsage")]
public class PersonEmailUsage {
    /// <summary>Time of the last use of the email address.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_LastUsed"/>
    /// <remarks>Column <c>LastUsed</c>: datetime, not null.</remarks>
    public virtual DateTime LastUsed { get; set; }
    /// <summary>The user who used the email address.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_UsedByPersonId"/>
    /// <remarks>Column <c>UsedByPersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int UsedByPersonId { get; set; }
    /// <summary>Used email address for sending the message.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_UsedEmail"/>
    /// <remarks>Column <c>UsedEmail</c>: nvarchar(255), not null.</remarks>
    public virtual string UsedEmail { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
