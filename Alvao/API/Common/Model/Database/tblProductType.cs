using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the products types (commercial, freeware, ...) (software products library).</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductType.html"/>
[Table("dbo.tblProductType")]
public class tblProductType {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblProductType.html#Alvao_API_Common_Model_Database_tblProductType_intProductTypeId"/>
    [ExplicitKey]
    public virtual int intProductTypeId { get; set; }
}
