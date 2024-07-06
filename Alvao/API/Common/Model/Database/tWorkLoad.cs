using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Employee labor contracts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tWorkLoad.htm"/>
[TableAttribute("dbo.tWorkLoad")]
public class tWorkLoad
{
    /// <summary>Labor contract end date + 1 (UTC). NULL represents a labor contract for an indefinite period.</summary>
    public virtual DateTime? dEnd { get; set; }
    /// <summary>Labor contract start date (UTC)</summary>
    public virtual DateTime dStart { get; set; }
    /// <summary>Number of work hours per day.</summary>
    public virtual double iWorkHoursPerDay { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int iWorkLoadId { get; set; }
    /// <summary>ID of the person assigned this labor contract</summary>
    public virtual int liPersonId { get; set; }

    public tWorkLoad() { }
}
