using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Detected properties of the computer components.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDetectedClassKind.htm"/>
[TableAttribute("dbo.tDetectedClassKind")]
public class tDetectedClassKind
{
    [ExplicitKeyAttribute]
    public virtual int liClassId { get; set; }
    public virtual int liKindId { get; set; }

    public tDetectedClassKind() { }
}
