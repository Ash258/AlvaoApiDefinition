using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Use of an e-mail address for sending the message by a specific user.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html"/>
[Table("dbo.PersonEmailUsage")]
public class PersonEmailUsage {
    /// <summary>Time of the last use of the email address.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_LastUsed"/>
    public virtual DateTime LastUsed { get; set; }
    /// <summary>The user who used the e-mail address.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_UsedByPersonId"/>
    public virtual int UsedByPersonId { get; set; }
    /// <summary>Used e-mail address for sending the message.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_UsedEmail"/>
    public virtual string UsedEmail { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonEmailUsage.html#Alvao_API_Common_Model_Database_PersonEmailUsage_id"/>
    [Key]
    public virtual int id { get; set; }
}
