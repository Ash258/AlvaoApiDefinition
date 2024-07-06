using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Use of an e-mail address for sending the message by a specific user.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonEmailUsage.htm"/>
[TableAttribute("dbo.PersonEmailUsage")]
public class PersonEmailUsage
{
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time of the last use of the email address.</summary>
    public virtual DateTime LastUsed { get; set; }
    /// <summary>The user who used the e-mail address.</summary>
    public virtual int UsedByPersonId { get; set; }
    /// <summary>Used e-mail address for sending the message.</summary>
    public virtual string UsedEmail { get; set; }

    public PersonEmailUsage() { }
}
