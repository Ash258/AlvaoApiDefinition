using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Network search setting.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNetScanRange.htm"/>
[TableAttribute("dbo.tblNetScanRange")]
public class tblNetScanRange
{
    public virtual DateTime? dteLastScan { get; set; }
    public virtual long? intFromIP { get; set; }
    [KeyAttribute]
    public virtual int intRangeId { get; set; }
    public virtual long? intToIP { get; set; }
    public virtual double? nPeriodHours { get; set; }
    public virtual string txtCollector { get; set; }

    public tblNetScanRange() { }
}
