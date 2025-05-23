using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of detections (HW, SW).</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vDetectKind.htm"/>
[TableAttribute("dbo.vDetectKind")]
public class vDetectKind
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectKind_intDetectKindId.htm"/>
    public virtual int intDetectKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vDetectKind_txtDetectKind.htm"/>
    public virtual string txtDetectKind { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vDetectKind__ctor.htm"/>
    public vDetectKind() { }
}
