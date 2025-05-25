using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - exceptions for the computer.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html"/>
[Table("dbo.tNodeProduct")]
public class tNodeProduct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liNodeId"/>
    [ExplicitKey]
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liProductId"/>
    public virtual int? liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tNodeProduct.html#Alvao_API_Common_Model_Database_tNodeProduct_liSwPresenceId"/>
    public virtual int liSwPresenceId { get; set; }
}
