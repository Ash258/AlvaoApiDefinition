using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping attributes from AD to AM properties. This configuration is used by ImportAD.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html"/>
[Table("dbo.tblADMap")]
public class tblADMap {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_bolKey"/>
    /// <remarks>Column <c>bolKey</c>: bit, not null.</remarks>
    public virtual bool bolKey { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_lintClassId"/>
    /// <remarks>Column <c>lintClassId</c>: int, null. References <see cref="tblClass"/>.</remarks>
    [ExplicitKey]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_lintKindId"/>
    /// <remarks>Column <c>lintKindId</c>: int, null. References <see cref="tblKind"/>.</remarks>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_txtADAttr"/>
    /// <remarks>Column <c>txtADAttr</c>: nvarchar(255), null.</remarks>
    public virtual string txtADAttr { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_txtADClass"/>
    /// <remarks>Column <c>txtADClass</c>: nvarchar(255), null.</remarks>
    public virtual string txtADClass { get; set; }
}
