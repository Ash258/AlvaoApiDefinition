using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Last record in the detection log.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vLog_DetectLast.htm"/>
[TableAttribute("dbo.vLog_DetectLast")]
public class vLog_DetectLast
{
    public virtual int? lintDetectId { get; set; }
    public virtual int? lintMaxLogId { get; set; }

    public vLog_DetectLast() { }
}
