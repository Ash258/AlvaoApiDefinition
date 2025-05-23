using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Status of the products</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ProductState.htm"/>
[TableAttribute("dbo.ProductState")]
public class ProductState
{
    /// <summary>Product status - written</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProductState__ProductState.htm"/>
    public virtual string _ProductState { get; set; }
    /// <summary>Product status - numerical (Primary key)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProductState_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>txtDesc</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ProductState_txtDesc.htm"/>
    public virtual string txtDesc { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ProductState__ctor.htm"/>
    public ProductState() { }
}
