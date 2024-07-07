using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of employee absence records.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tTimeOffKind.htm"/>
[TableAttribute("dbo.tTimeOffKind")]
public class tTimeOffKind
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOffKind_iTimeOffKindId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iTimeOffKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOffKind_sTimeOffKind.htm"/>
    public virtual string sTimeOffKind { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tTimeOffKind__ctor.htm"/>
    public tTimeOffKind() { }
}
