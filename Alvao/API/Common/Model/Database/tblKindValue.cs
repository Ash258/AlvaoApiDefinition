using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Value lists for the properties of objects.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html"/>
[Table("dbo.tblKindValue")]
public class tblKindValue {
    /// <summary>System item identification</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_KindValueBehaviorId"/>
    /// <remarks>Column <c>KindValueBehaviorId</c>: int, null.</remarks>
    public virtual int? KindValueBehaviorId { get; set; }
    /// <summary>definition of property - tblKind</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_lintKindId"/>
    /// <remarks>Column <c>lintKindId</c>: int, not null. References <see cref="tblKind"/>.</remarks>
    [ExplicitKey]
    public virtual int lintKindId { get; set; }
    /// <summary>Value</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_txtValue"/>
    /// <remarks>Column <c>txtValue</c>: nvarchar(255), null.</remarks>
    public virtual string txtValue { get; set; }
}
