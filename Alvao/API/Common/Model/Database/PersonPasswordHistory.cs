using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Used people's passwords.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonPasswordHistory.html"/>
[Table("dbo.PersonPasswordHistory")]
public class PersonPasswordHistory {
    /// <summary>Hash of password used.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonPasswordHistory.html#Alvao_API_Common_Model_Database_PersonPasswordHistory_Password"/>
    public virtual string Password { get; set; }
    /// <summary>Person Id.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonPasswordHistory.html#Alvao_API_Common_Model_Database_PersonPasswordHistory_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Password setting date.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonPasswordHistory.html#Alvao_API_Common_Model_Database_PersonPasswordHistory_SinceDate"/>
    public virtual DateTime SinceDate { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonPasswordHistory.html#Alvao_API_Common_Model_Database_PersonPasswordHistory_id"/>
    [Key]
    public virtual int id { get; set; }
}
