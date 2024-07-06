using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// National holidays.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHoliday.htm"/>
[TableAttribute("dbo.tBankHoliday")]
public class tBankHoliday
{
    public virtual DateTime dBankHoliday { get; set; }
    [KeyAttribute]
    public virtual int iBankHolidayId { get; set; }
    public virtual int? liBankHolidayRegionId { get; set; }
    public virtual string sBankHoliday { get; set; }

    public tBankHoliday() { }
}
