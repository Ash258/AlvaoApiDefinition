using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Calendar of days</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tDay.htm"/>
[TableAttribute("dbo.tDay")]
public class tDay
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tDay_dDay.htm"/>
    [ExplicitKeyAttribute]
    public virtual DateTime dDay { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tDay__ctor.htm"/>
    public tDay() { }
}
