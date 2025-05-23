using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products categories (OS).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vProductCategory.htm"/>
[TableAttribute("dbo.vProductCategory")]
public class vProductCategory
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProductCategory_intProductCategoryId.htm"/>
    public virtual int intProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vProductCategory_txtProductCategory.htm"/>
    public virtual string txtProductCategory { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vProductCategory__ctor.htm"/>
    public vProductCategory() { }
}
