using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products categories (OS).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductCategory.html"/>
[Table("dbo.vProductCategory")]
public class vProductCategory {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductCategory.html#Alvao_API_Common_Model_Database_vProductCategory_intProductCategoryId"/>
    public virtual int intProductCategoryId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductCategory.html#Alvao_API_Common_Model_Database_vProductCategory_txtProductCategory"/>
    public virtual string txtProductCategory { get; set; }
}
