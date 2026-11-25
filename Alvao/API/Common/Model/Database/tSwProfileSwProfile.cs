using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - sub-profiles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html"/>
[Table("dbo.tSwProfileSwProfile")]
public class tSwProfileSwProfile {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html#Alvao_API_Common_Model_Database_tSwProfileSwProfile_liMemberSwProfileId"/>
    /// <remarks>Column <c>liMemberSwProfileId</c>: int, not null. References <see cref="tSwProfile"/>.</remarks>
    public virtual int liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html#Alvao_API_Common_Model_Database_tSwProfileSwProfile_liSwProfileId"/>
    /// <remarks>Column <c>liSwProfileId</c>: int, not null. References <see cref="tSwProfile"/>.</remarks>
    [ExplicitKey]
    public virtual int liSwProfileId { get; set; }
}
