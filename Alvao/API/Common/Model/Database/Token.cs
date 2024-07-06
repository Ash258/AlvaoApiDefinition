using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// For internal use
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Token.htm"/>
[TableAttribute("dbo.Token")]
public class Token
{
    public virtual string AccessToken { get; set; }
    public virtual DateTime Expiration { get; set; }
    [ExplicitKeyAttribute]
    public virtual int PersonId { get; set; }
    public virtual string Scope { get; set; }

    public Token() { }
}
