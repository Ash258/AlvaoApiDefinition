using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Valid safety token table.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_ConnectionToken.htm"/>
[TableAttribute("dbo.ConnectionToken")]
public class ConnectionToken
{
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ConnectionToken_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Token.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ConnectionToken_Token.htm"/>
    public virtual string Token { get; set; }
    /// <summary>Valid to.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_ConnectionToken_ValidTo.htm"/>
    public virtual DateTime ValidTo { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_ConnectionToken__ctor.htm"/>
    public ConnectionToken() { }
}
