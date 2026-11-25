using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// National holiday blocks included in the database. A block is a list of holidays belonging to one region and year.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html"/>
[Table("dbo.tBankHolidayLoaded")]
public class tBankHolidayLoaded {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_dRevision"/>
    /// <remarks>Column <c>dRevision</c>: datetime, not null.</remarks>
    public virtual DateTime dRevision { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_iYear"/>
    /// <remarks>Column <c>iYear</c>: int, not null.</remarks>
    public virtual int iYear { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tBankHolidayLoaded.html#Alvao_API_Common_Model_Database_tBankHolidayLoaded_liBankHolidayRegionId"/>
    /// <remarks>
    /// Column <c>liBankHolidayRegionId</c>: int, not null. References <see cref="tBankHolidayRegion"/>.
    /// </remarks>
    public virtual int liBankHolidayRegionId { get; set; }
}
