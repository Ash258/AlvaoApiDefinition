using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Employee labor contracts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWorkLoad.htm"/>
[TableAttribute("dbo.tWorkLoad")]
public class tWorkLoad
{
    /// <summary>Labor contract end date + 1 (UTC). NULL represents a labor contract for an indefinite period.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkLoad_dEnd.htm"/>
    public virtual DateTime? dEnd { get; set; }
    /// <summary>Labor contract start date (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkLoad_dStart.htm"/>
    public virtual DateTime dStart { get; set; }
    /// <summary>Number of work hours per day.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkLoad_iWorkHoursPerDay.htm"/>
    public virtual double iWorkHoursPerDay { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkLoad_iWorkLoadId.htm"/>
    [KeyAttribute]
    public virtual int iWorkLoadId { get; set; }
    /// <summary>ID of the person assigned this labor contract</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tWorkLoad_liPersonId.htm"/>
    public virtual int liPersonId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tWorkLoad__ctor.htm"/>
    public tWorkLoad() { }
}
