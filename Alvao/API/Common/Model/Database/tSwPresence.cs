using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - product statuses.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html"/>
[Table("dbo.tSwPresence")]
public class tSwPresence {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html#Alvao_API_Common_Model_Database_tSwPresence_iSwPresenceId"/>
    [ExplicitKey]
    public virtual int iSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwPresence.html#Alvao_API_Common_Model_Database_tSwPresence_sSwPresence"/>
    public virtual string sSwPresence { get; set; }
}
