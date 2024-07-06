using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Types of detections (HW, SW).
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDetectKind.htm"/>
[TableAttribute("dbo.vDetectKind")]
public class vDetectKind
{
    public virtual int intDetectKindId { get; set; }
    public virtual string txtDetectKind { get; set; }

    public vDetectKind() { }
}
