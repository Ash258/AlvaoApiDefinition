using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last record in the detection log.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLog_DetectLast.html"/>
[Table("dbo.vLog_DetectLast")]
public class vLog_DetectLast {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLog_DetectLast.html#Alvao_API_Common_Model_Database_vLog_DetectLast_lintDetectId"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vLog_DetectLast.html#Alvao_API_Common_Model_Database_vLog_DetectLast_lintMaxLogId"/>
    public virtual int? lintMaxLogId { get; set; }
}
