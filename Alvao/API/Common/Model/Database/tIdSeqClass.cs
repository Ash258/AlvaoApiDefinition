using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequences - definitions for types of objects.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html"/>
[Table("dbo.tIdSeqClass")]
public class tIdSeqClass {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html#Alvao_API_Common_Model_Database_tIdSeqClass_liClassId"/>
    public virtual int? liClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html#Alvao_API_Common_Model_Database_tIdSeqClass_liIdSeqId"/>
    [ExplicitKey]
    public virtual int liIdSeqId { get; set; }
}
