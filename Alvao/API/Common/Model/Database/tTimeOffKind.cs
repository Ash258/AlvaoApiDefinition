using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of employee absence records.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOffKind.html"/>
[Table("dbo.tTimeOffKind")]
public class tTimeOffKind {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOffKind.html#Alvao_API_Common_Model_Database_tTimeOffKind_iTimeOffKindId"/>
    [ExplicitKey]
    public virtual int iTimeOffKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tTimeOffKind.html#Alvao_API_Common_Model_Database_tTimeOffKind_sTimeOffKind"/>
    public virtual string sTimeOffKind { get; set; }
}
