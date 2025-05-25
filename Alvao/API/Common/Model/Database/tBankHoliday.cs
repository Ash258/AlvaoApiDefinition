using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>National holidays.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html"/>
[Table("dbo.tBankHoliday")]
public class tBankHoliday {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_dBankHoliday"/>
    public virtual DateTime dBankHoliday { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_iBankHolidayId"/>
    [Key]
    public virtual int iBankHolidayId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_liBankHolidayRegionId"/>
    public virtual int? liBankHolidayRegionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHoliday.html#Alvao_API_Common_Model_Database_tBankHoliday_sBankHoliday"/>
    public virtual string sBankHoliday { get; set; }
}
