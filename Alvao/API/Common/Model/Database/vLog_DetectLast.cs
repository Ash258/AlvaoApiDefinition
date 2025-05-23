using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Last record in the detection log.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLog_DetectLast.htm"/>
[TableAttribute("dbo.vLog_DetectLast")]
public class vLog_DetectLast
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLog_DetectLast_lintDetectId.htm"/>
    public virtual int? lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vLog_DetectLast_lintMaxLogId.htm"/>
    public virtual int? lintMaxLogId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vLog_DetectLast__ctor.htm"/>
    public vLog_DetectLast() { }
}
