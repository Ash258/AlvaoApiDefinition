using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - membership of products in profiles.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html"/>
[Table("dbo.tSwProfileProduct")]
public class tSwProfileProduct {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liMemberSwProfileId"/>
    /// <remarks>Column <c>liMemberSwProfileId</c>: int, null. References <see cref="tSwProfile"/>.</remarks>
    public virtual int? liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liProductId"/>
    /// <remarks>Column <c>liProductId</c>: int, not null. References <see cref="tblProduct"/>.</remarks>
    [ExplicitKey]
    public virtual int liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liSwPresenceId"/>
    /// <remarks>Column <c>liSwPresenceId</c>: int, not null. References <see cref="tSwPresence"/>.</remarks>
    public virtual int liSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liSwProfileId"/>
    /// <remarks>Column <c>liSwProfileId</c>: int, not null. References <see cref="tSwProfile"/>.</remarks>
    [ExplicitKey]
    public virtual int liSwProfileId { get; set; }
}
