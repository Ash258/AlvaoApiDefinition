using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Local national holiday regions.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html"/>
[Table("dbo.tBankHolidayRegion")]
public class tBankHolidayRegion {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html#Alvao_API_Common_Model_Database_tBankHolidayRegion_iBankHolidayRegionId"/>
    [ExplicitKey]
    public virtual int iBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html#Alvao_API_Common_Model_Database_tBankHolidayRegion_sBankHolidayRegion"/>
    public virtual string sBankHolidayRegion { get; set; }
}
