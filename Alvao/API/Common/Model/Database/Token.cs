using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>For internal use</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Token.html"/>
[Table("dbo.Token")]
public class Token {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_AccessToken"/>
    /// <remarks>Column <c>AccessToken</c>: nvarchar(max), not null.</remarks>
    public virtual string AccessToken { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_Expiration"/>
    /// <remarks>Column <c>Expiration</c>: datetime, not null.</remarks>
    public virtual DateTime Expiration { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_PersonId"/>
    /// <remarks>Column <c>PersonId</c>: int, not null. References <see cref="tPerson"/>.</remarks>
    [ExplicitKey]
    public virtual int PersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Token.html#Alvao_API_Common_Model_Database_Token_Scope"/>
    /// <remarks>Column <c>Scope</c>: nvarchar(2048), not null.</remarks>
    [ExplicitKey]
    public virtual string Scope { get; set; }
}
