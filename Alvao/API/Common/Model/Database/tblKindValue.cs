using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Value lists for the properties of objects.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html"/>
[Table("dbo.tblKindValue")]
public class tblKindValue {
    /// <summary>System item identification</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_KindValueBehaviorId"/>
    public virtual int? KindValueBehaviorId { get; set; }
    /// <summary>definition of property - tblKind</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_lintKindId"/>
    [ExplicitKey]
    public virtual int lintKindId { get; set; }
    /// <summary>Value</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblKindValue.html#Alvao_API_Common_Model_Database_tblKindValue_txtValue"/>
    public virtual string txtValue { get; set; }
}
