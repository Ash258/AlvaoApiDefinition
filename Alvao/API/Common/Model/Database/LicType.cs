using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>License types.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicType.html"/>
[Table("dbo.LicType")]
public class LicType {
    /// <summary>Type name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicType.html#Alvao_API_Common_Model_Database_LicType__LicType"/>
    public virtual string _LicType { get; set; }
    /// <summary>Item ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LicType.html#Alvao_API_Common_Model_Database_LicType_id"/>
    [ExplicitKey]
    public virtual int id { get; set; }
}
