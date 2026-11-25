using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - product statuses.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html"/>
[Table("dbo.tSwPresence")]
public class tSwPresence {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html#Alvao_API_Common_Model_Database_tSwPresence_iSwPresenceId"/>
    /// <remarks>Column <c>iSwPresenceId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html#Alvao_API_Common_Model_Database_tSwPresence_sSwPresence"/>
    /// <remarks>Column <c>sSwPresence</c>: nvarchar(255), not null.</remarks>
    public virtual string sSwPresence { get; set; }
}
