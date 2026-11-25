using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Scheduled evaluation of HW and SW by detection.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html"/>
[Table("dbo.tblDetectAction")]
public class tblDetectAction {
    /// <summary>If the value is 1, the request was created manually by the Evaluate immediately command.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_ManualRq"/>
    /// <remarks>Column <c>ManualRq</c>: bit, not null.</remarks>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_intDetectActionId"/>
    /// <remarks>Column <c>intDetectActionId</c>: int, not null.</remarks>
    [Key]
    public virtual int intDetectActionId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_lintDetectActionKindId"/>
    /// <remarks>Column <c>lintDetectActionKindId</c>: int, not null.</remarks>
    public virtual int lintDetectActionKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_lintDetectId"/>
    /// <remarks>Column <c>lintDetectId</c>: int, not null. References <see cref="tblDetect"/>.</remarks>
    public virtual int lintDetectId { get; set; }
}
