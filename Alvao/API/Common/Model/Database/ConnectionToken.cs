using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Valid safety token table.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html"/>
[Table("dbo.ConnectionToken")]
public class ConnectionToken {
    /// <summary>Token.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_Token"/>
    public virtual string Token { get; set; }
    /// <summary>Valid to.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_ValidTo"/>
    public virtual DateTime ValidTo { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.ConnectionToken.html#Alvao_API_Common_Model_Database_ConnectionToken_id"/>
    [Key]
    public virtual int id { get; set; }
}
