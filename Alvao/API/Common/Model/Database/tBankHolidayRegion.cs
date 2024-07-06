using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Local national holiday regions.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHolidayRegion.htm"/>
[TableAttribute("dbo.tBankHolidayRegion")]
public class tBankHolidayRegion
{
    [ExplicitKeyAttribute]
    public virtual int iBankHolidayRegionId { get; set; }
    public virtual string sBankHolidayRegion { get; set; }

    public tBankHolidayRegion() { }
}
