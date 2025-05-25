using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Mapping attributes from AD to AM properties. This configuration is used by ImportAD.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html"/>
[Table("dbo.tblADMap")]
public class tblADMap {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_bolKey"/>
    public virtual bool bolKey { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_lintClassId"/>
    [ExplicitKey]
    public virtual int? lintClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_lintKindId"/>
    public virtual int? lintKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_txtADAttr"/>
    public virtual string txtADAttr { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblADMap.html#Alvao_API_Common_Model_Database_tblADMap_txtADClass"/>
    public virtual string txtADClass { get; set; }
}
