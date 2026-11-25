using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Valid safety token table.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html"/>
[Table("dbo.ConnectionToken")]
public class ConnectionToken {
    /// <summary>Token.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_Token"/>
    /// <remarks>Column <c>Token</c>: varchar, not null.</remarks>
    public virtual string Token { get; set; }
    /// <summary>Valid to.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_ValidTo"/>
    /// <remarks>Column <c>ValidTo</c>: datetime, not null.</remarks>
    public virtual DateTime ValidTo { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
