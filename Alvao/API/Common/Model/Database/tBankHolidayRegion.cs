using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Local national holiday regions.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHolidayRegion.htm"/>
[TableAttribute("dbo.tBankHolidayRegion")]
public class tBankHolidayRegion
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHolidayRegion_iBankHolidayRegionId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int iBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tBankHolidayRegion_sBankHolidayRegion.htm"/>
    public virtual string sBankHolidayRegion { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tBankHolidayRegion__ctor.htm"/>
    public tBankHolidayRegion() { }
}
