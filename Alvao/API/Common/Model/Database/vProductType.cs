using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Products types.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductType.html"/>
[Table("dbo.vProductType")]
public class vProductType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductType.html#Alvao_API_Common_Model_Database_vProductType_intProductTypeId"/>
    public virtual int intProductTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vProductType.html#Alvao_API_Common_Model_Database_vProductType_txtProductType"/>
    public virtual string txtProductType { get; set; }
}
