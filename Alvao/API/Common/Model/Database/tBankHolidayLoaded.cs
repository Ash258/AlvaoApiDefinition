using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// National holiday blocks included in the database. A block is a list of holidays belonging to one region and///           year.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHolidayLoaded.htm"/>
[TableAttribute("dbo.tBankHolidayLoaded")]
public class tBankHolidayLoaded
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHolidayLoaded_dRevision.htm"/>
    public virtual DateTime dRevision { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHolidayLoaded_iYear.htm"/>
    public virtual int iYear { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHolidayLoaded_liBankHolidayRegionId.htm"/>
    public virtual int liBankHolidayRegionId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tBankHolidayLoaded__ctor.htm"/>
    public tBankHolidayLoaded() { }
}
