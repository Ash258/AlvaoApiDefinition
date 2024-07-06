using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Services to which the given solver created tickets last using the New Ticket Form.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_OperatorServiceUsage.htm"/>
[TableAttribute("dbo.OperatorServiceUsage")]
public class OperatorServiceUsage
{
    /// <summary>Used service ID while registering the ticket</summary>
    public virtual int HdSectionId { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Service last use time</summary>
    public virtual DateTime LastUsed { get; set; }
    /// <summary>The solver who used the given service while registering the ticket.</summary>
    public virtual int PersonId { get; set; }

    public OperatorServiceUsage() { }
}
