using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Status of the products
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ProductState.htm"/>
[TableAttribute("dbo.ProductState")]
public class ProductState
{
    /// <summary>Product status - written</summary>
    public virtual string _ProductState { get; set; }
    /// <summary>Product status - numerical (Primary key)</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>txtDesc</summary>
    public virtual string txtDesc { get; set; }

    public ProductState() { }
}
