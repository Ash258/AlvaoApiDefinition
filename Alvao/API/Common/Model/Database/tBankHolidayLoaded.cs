using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// National holiday blocks included in the database. A block is a list of holidays belonging to one region and///           year.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tBankHolidayLoaded.htm"/>
[TableAttribute("dbo.tBankHolidayLoaded")]
public class tBankHolidayLoaded
{
    public virtual DateTime dRevision { get; set; }
    public virtual int iYear { get; set; }
    public virtual int liBankHolidayRegionId { get; set; }

    public tBankHolidayLoaded() { }
}
