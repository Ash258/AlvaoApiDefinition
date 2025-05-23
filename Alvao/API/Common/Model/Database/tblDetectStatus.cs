using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>ID of the detections statuses. Texts in tblDict.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tblDetectStatus.htm"/>
[TableAttribute("dbo.tblDetectStatus")]
public class tblDetectStatus
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tblDetectStatus_intDetectStatusId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int intDetectStatusId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tblDetectStatus__ctor.htm"/>
    public tblDetectStatus() { }
}
