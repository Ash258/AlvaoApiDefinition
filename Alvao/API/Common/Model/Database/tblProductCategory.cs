using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// ID of the products categories (OS). Text in tblDict.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProductCategory.htm"/>
[TableAttribute("dbo.tblProductCategory")]
public class tblProductCategory
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblProductCategory_intProductCategoryId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intProductCategoryId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblProductCategory__ctor.htm"/>
    public tblProductCategory() { }
}
