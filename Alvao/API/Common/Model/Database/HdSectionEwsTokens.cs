using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Tokens for logging in to MS Exchange.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_HdSectionEwsTokens.htm"/>
[TableAttribute("dbo.HdSectionEwsTokens")]
public class HdSectionEwsTokens {
    /// <summary>Access token</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionEwsTokens_AccessToken.htm"/>
    public virtual string AccessToken { get; set; }
    /// <summary>Access token expiration (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionEwsTokens_AccessTokenExpiration.htm"/>
    public virtual DateTime? AccessTokenExpiration { get; set; }
    /// <summary>Service ID (see tHdSection.iHdSectionId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionEwsTokens_HdSectionId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int HdSectionId { get; set; }
    /// <summary>Error message and from the last login to the mailbox. If it contains NULL, the last login was successful.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionEwsTokens_LastErrorMessage.htm"/>
    public virtual string LastErrorMessage { get; set; }
    /// <summary>Refresh token</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_HdSectionEwsTokens_RefreshToken.htm"/>
    public virtual string RefreshToken { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_HdSectionEwsTokens__ctor.htm"/>
    public HdSectionEwsTokens() { }
}
