using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the products categories (OS). Text in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductCategory.html"/>
[Table("dbo.tblProductCategory")]
public class tblProductCategory {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductCategory.html#Alvao_API_Common_Model_Database_tblProductCategory_intProductCategoryId"/>
    [ExplicitKey]
    public virtual int intProductCategoryId { get; set; }
}
