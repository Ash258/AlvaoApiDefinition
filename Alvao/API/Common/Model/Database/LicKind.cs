using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>&quot;CAL/Licensing&quot; list, i.e. per device, per user, etc.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicKind.html"/>
[Table("dbo.LicKind")]
public class LicKind {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicKind.html#Alvao_API_Common_Model_Database_LicKind__LicKind"/>
    public virtual string _LicKind { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.LicKind.html#Alvao_API_Common_Model_Database_LicKind_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int id { get; set; }
}
