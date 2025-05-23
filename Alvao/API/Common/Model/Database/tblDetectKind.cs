using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the types of detection (HW, SW). Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectKind.htm"/>
[TableAttribute("dbo.tblDetectKind")]
public class tblDetectKind
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectKind_intDetectKindId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intDetectKindId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetectKind__ctor.htm"/>
    public tblDetectKind() { }
}
