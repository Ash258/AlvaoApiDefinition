using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Status of the products</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProductState.html"/>
[Table("dbo.ProductState")]
public class ProductState {
    /// <summary>Product status - written</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProductState.html#Alvao_API_Common_Model_Database_ProductState__ProductState"/>
    public virtual string _ProductState { get; set; }
    /// <summary>Product status - numerical (Primary key)</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProductState.html#Alvao_API_Common_Model_Database_ProductState_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
    /// <summary>txtDesc</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ProductState.html#Alvao_API_Common_Model_Database_ProductState_txtDesc"/>
    /// <remarks>Column <c>txtDesc</c>: nvarchar(255), not null.</remarks>
    public virtual string txtDesc { get; set; }
}
