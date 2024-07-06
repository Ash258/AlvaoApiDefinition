using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Calendar of days
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDay.htm"/>
[TableAttribute("dbo.tDay")]
public class tDay
{
    [ExplicitKeyAttribute]
    public virtual DateTime dDay { get; set; }

    public tDay() { }
}
