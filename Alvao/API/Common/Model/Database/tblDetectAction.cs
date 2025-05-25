using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Scheduled evaluation of HW and SW by detection.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html"/>
[Table("dbo.tblDetectAction")]
public class tblDetectAction {
    /// <summary>If the value is 1, the request was created manually by the Evaluate immediately command.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_ManualRq"/>
    public virtual bool ManualRq { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_intDetectActionId"/>
    [Key]
    public virtual int intDetectActionId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_lintDetectActionKindId"/>
    public virtual int lintDetectActionKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_lintDetectId"/>
    public virtual int lintDetectId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tblDetectAction.html#Alvao_API_Common_Model_Database_tblDetectAction_txtCollector"/>
    public virtual string txtCollector { get; set; }
}
