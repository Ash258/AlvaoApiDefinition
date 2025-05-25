using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tokens for logging in to MS Exchange.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html"/>
[Table("dbo.HdSectionEwsTokens")]
public class HdSectionEwsTokens {
    /// <summary>Access token</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html#Alvao_API_Common_Model_Database_HdSectionEwsTokens_AccessToken"/>
    public virtual string AccessToken { get; set; }
    /// <summary>Access token expiration (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html#Alvao_API_Common_Model_Database_HdSectionEwsTokens_AccessTokenExpiration"/>
    public virtual DateTime? AccessTokenExpiration { get; set; }
    /// <summary>Service ID (see tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html#Alvao_API_Common_Model_Database_HdSectionEwsTokens_HdSectionId"/>
    [ExplicitKey]
    public virtual int HdSectionId { get; set; }
    /// <summary>Error message and from the last login to the mailbox. If it contains NULL, the last login was successful.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html#Alvao_API_Common_Model_Database_HdSectionEwsTokens_LastErrorMessage"/>
    public virtual string LastErrorMessage { get; set; }
    /// <summary>Refresh token</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.HdSectionEwsTokens.html#Alvao_API_Common_Model_Database_HdSectionEwsTokens_RefreshToken"/>
    public virtual string RefreshToken { get; set; }
}
