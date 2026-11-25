using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Services to which the given solver created tickets last using the New Ticket Form.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.OperatorServiceUsage.html"/>
[Table("dbo.OperatorServiceUsage")]
public class OperatorServiceUsage {
    /// <summary>Used service ID while registering the ticket</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.OperatorServiceUsage.html#Alvao_API_Common_Model_Database_OperatorServiceUsage_HdSectionId"/>
    /// <remarks>Column <c>HdSectionId</c>: int, not null. References <see cref="tHdSection"/>.</remarks>
    public virtual int HdSectionId { get; set; }
    /// <summary>Service last use time</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.OperatorServiceUsage.html#Alvao_API_Common_Model_Database_OperatorServiceUsage_LastUsed"/>
    /// <remarks>Column <c>LastUsed</c>: datetime, not null.</remarks>
    public virtual DateTime LastUsed { get; set; }
    /// <summary>The solver who used the given service while registering the ticket.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.OperatorServiceUsage.html#Alvao_API_Common_Model_Database_OperatorServiceUsage_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    public virtual int PersonId { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.OperatorServiceUsage.html#Alvao_API_Common_Model_Database_OperatorServiceUsage_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
