using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Software profiles - membership of products in profiles.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html"/>
[Table("dbo.tSwProfileProduct")]
public class tSwProfileProduct {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liMemberSwProfileId"/>
    public virtual int? liMemberSwProfileId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liProductId"/>
    public virtual int liProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liSwPresenceId"/>
    public virtual int liSwPresenceId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tSwProfileProduct.html#Alvao_API_Common_Model_Database_tSwProfileProduct_liSwProfileId"/>
    [ExplicitKey]
    public virtual int liSwProfileId { get; set; }
}
