using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>National holiday blocks included in the database. A block is a list of holidays belonging to one region and year.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html"/>
[Table("dbo.tBankHolidayLoaded")]
public class tBankHolidayLoaded {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_dRevision"/>
    public virtual DateTime dRevision { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_iYear"/>
    public virtual int iYear { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_liBankHolidayRegionId"/>
    public virtual int liBankHolidayRegionId { get; set; }
}
