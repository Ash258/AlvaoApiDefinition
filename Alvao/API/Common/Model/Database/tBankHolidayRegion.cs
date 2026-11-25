using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Local national holiday regions.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html"/>
[Table("dbo.tBankHolidayRegion")]
public class tBankHolidayRegion {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html#Alvao_API_Common_Model_Database_tBankHolidayRegion_CountryCode"/>
    /// <remarks>Column <c>CountryCode</c>: nvarchar(2), null.</remarks>
    public virtual string CountryCode { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html#Alvao_API_Common_Model_Database_tBankHolidayRegion_iBankHolidayRegionId"/>
    /// <remarks>Column <c>iBankHolidayRegionId</c>: int, not null.</remarks>
    [ExplicitKey]
    public virtual int iBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayRegion.html#Alvao_API_Common_Model_Database_tBankHolidayRegion_sBankHolidayRegion"/>
    /// <remarks>Column <c>sBankHolidayRegion</c>: nvarchar(255), not null.</remarks>
    public virtual string sBankHolidayRegion { get; set; }
}
