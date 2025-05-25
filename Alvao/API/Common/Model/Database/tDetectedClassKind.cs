using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Detected properties of the computer components.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDetectedClassKind.html"/>
[Table("dbo.tDetectedClassKind")]
public class tDetectedClassKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDetectedClassKind.html#Alvao_API_Common_Model_Database_tDetectedClassKind_liClassId"/>
    [ExplicitKey]
    public virtual int liClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tDetectedClassKind.html#Alvao_API_Common_Model_Database_tDetectedClassKind_liKindId"/>
    public virtual int liKindId { get; set; }
}
