using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// National holidays.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHoliday.htm"/>
[TableAttribute("dbo.tBankHoliday")]
public class tBankHoliday
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHoliday_dBankHoliday.htm"/>
    public virtual DateTime dBankHoliday { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHoliday_iBankHolidayId.htm"/>
    [KeyAttribute]
    public virtual int iBankHolidayId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHoliday_liBankHolidayRegionId.htm"/>
    public virtual int? liBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHoliday_sBankHoliday.htm"/>
    public virtual string sBankHoliday { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tBankHoliday__ctor.htm"/>
    public tBankHoliday() { }
}
