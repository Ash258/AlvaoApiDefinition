using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - sub-profiles.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html"/>
[Table("dbo.tSwProfileSwProfile")]
public class tSwProfileSwProfile {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html#Alvao_API_Common_Model_Database_tSwProfileSwProfile_liMemberSwProfileId"/>
    public virtual int liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileSwProfile.html#Alvao_API_Common_Model_Database_tSwProfileSwProfile_liSwProfileId"/>
    [ExplicitKey]
    public virtual int liSwProfileId { get; set; }
}
