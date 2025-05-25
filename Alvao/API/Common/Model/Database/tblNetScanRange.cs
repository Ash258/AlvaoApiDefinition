using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Network search setting.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html"/>
[Table("dbo.tblNetScanRange")]
public class tblNetScanRange {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_dteLastScan"/>
    public virtual DateTime? dteLastScan { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_intFromIP"/>
    public virtual long? intFromIP { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_intRangeId"/>
    [Key]
    public virtual int intRangeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_intToIP"/>
    public virtual long? intToIP { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_nPeriodHours"/>
    public virtual double? nPeriodHours { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblNetScanRange.html#Alvao_API_Common_Model_Database_tblNetScanRange_txtCollector"/>
    public virtual string txtCollector { get; set; }
}
