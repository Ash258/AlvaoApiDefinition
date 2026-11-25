using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - exceptions for the computer.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html"/>
[Table("dbo.tNodeProduct")]
public class tNodeProduct {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liNodeId"/>
    /// <remarks>Column <c>liNodeId</c>: int, null. References <see cref="tblNode"/>.</remarks>
    [ExplicitKey]
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liProductId"/>
    /// <remarks>Column <c>liProductId</c>: int, null. References <see cref="tblProduct"/>.</remarks>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liSwPresenceId"/>
    /// <remarks>Column <c>liSwPresenceId</c>: int, not null. References <see cref="tSwPresence"/>.</remarks>
    public virtual int liSwPresenceId { get; set; }
}
