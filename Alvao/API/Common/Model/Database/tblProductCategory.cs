using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// ID of the products categories (OS). Text in tblDict.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblProductCategory.htm"/>
[TableAttribute("dbo.tblProductCategory")]
public class tblProductCategory
{
    [ExplicitKeyAttribute]
    public virtual int intProductCategoryId { get; set; }

    public tblProductCategory() { }
}
