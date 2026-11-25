using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the product types (commercial, freeware, ...) (software product library).</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductType.html"/>
[Table("dbo.tblProductType")]
public class tblProductType {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblProductType.html#Alvao_API_Common_Model_Database_tblProductType_intProductTypeId"/>
    /// <remarks>Column <c>intProductTypeId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int intProductTypeId { get; set; }
}
