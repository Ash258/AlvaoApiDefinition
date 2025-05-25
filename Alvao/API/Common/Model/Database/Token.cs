using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For internal use</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Token.html"/>
[Table("dbo.Token")]
public class Token {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_AccessToken"/>
    public virtual string AccessToken { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_Expiration"/>
    public virtual DateTime Expiration { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_PersonId"/>
    [ExplicitKey]
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_Scope"/>
    public virtual string Scope { get; set; }
}
