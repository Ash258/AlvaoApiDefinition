using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of employee absence records.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tTimeOffKind.htm"/>
[TableAttribute("dbo.tTimeOffKind")]
public class tTimeOffKind
{
    [ExplicitKeyAttribute]
    public virtual int iTimeOffKindId { get; set; }
    public virtual string sTimeOffKind { get; set; }

    public tTimeOffKind() { }
}
