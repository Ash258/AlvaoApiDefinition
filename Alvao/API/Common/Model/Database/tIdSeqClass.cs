using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Numeric sequences - definitions for types of objects.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html"/>
[Table("dbo.tIdSeqClass")]
public class tIdSeqClass {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html#Alvao_API_Common_Model_Database_tIdSeqClass_liClassId"/>
    /// <remarks>Column <c>liClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    public virtual int? liClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tIdSeqClass.html#Alvao_API_Common_Model_Database_tIdSeqClass_liIdSeqId"/>
    /// <remarks>Column <c>liIdSeqId</c>: int, not null. References <see cref="tblIdSeq"/>.</remarks>
    [ExplicitKey]
    public virtual int liIdSeqId { get; set; }
}
