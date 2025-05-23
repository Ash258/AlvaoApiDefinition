using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Network search setting.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblNetScanRange.htm"/>
[TableAttribute("dbo.tblNetScanRange")]
public class tblNetScanRange
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_dteLastScan.htm"/>
    public virtual DateTime? dteLastScan { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_intFromIP.htm"/>
    public virtual long? intFromIP { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_intRangeId.htm"/>
    [KeyAttribute]
    public virtual int intRangeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_intToIP.htm"/>
    public virtual long? intToIP { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_nPeriodHours.htm"/>
    public virtual double? nPeriodHours { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblNetScanRange_txtCollector.htm"/>
    public virtual string txtCollector { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblNetScanRange__ctor.htm"/>
    public tblNetScanRange() { }
}
