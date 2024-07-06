using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Used people's passwords.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonPasswordHistory.htm"/>
[TableAttribute("dbo.PersonPasswordHistory")]
public class PersonPasswordHistory
{
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Hash of password used.</summary>
    public virtual string Password { get; set; }
    /// <summary>Person Id.</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Password setting date.</summary>
    public virtual DateTime SinceDate { get; set; }

    public PersonPasswordHistory() { }
}
