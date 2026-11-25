using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>National holidays.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html"/>
[Table("dbo.tBankHoliday")]
public class tBankHoliday {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_dBankHoliday"/>
    /// <remarks>Column <c>dBankHoliday</c>: datetime, not null.</remarks>
    public virtual DateTime dBankHoliday { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_iBankHolidayId"/>
    /// <remarks>Column <c>iBankHolidayId</c>: int, not null.</remarks>
    [Key]
    public virtual int iBankHolidayId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_liBankHolidayRegionId"/>
    /// <remarks>Column <c>liBankHolidayRegionId</c>: int, null. References <see cref="tBankHolidayRegion"/>.</remarks>
    public virtual int? liBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_sBankHoliday"/>
    /// <remarks>Column <c>sBankHoliday</c>: nvarchar(255), null.</remarks>
    public virtual string sBankHoliday { get; set; }
}
